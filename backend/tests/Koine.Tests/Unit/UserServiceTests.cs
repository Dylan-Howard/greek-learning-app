using Koine.Application.DTOs.Users;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class UserServiceTests
{
    [Test]
    public async Task CreateUserAsync_ReturnsNull_WhenRequiredFieldsMissing()
    {
        var uow = new Mock<IUnitOfWork>();
        var userRepo = new Mock<IUserRepository>();
        var progressRepo = new Mock<IUserProgressRepository>();

        uow.SetupGet(x => x.Users).Returns(userRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(progressRepo.Object);

        var service = new UserService(uow.Object);
        var result = await service.CreateUserAsync(new CreateUserDto
        {
            Email = "a@b.com",
            Username = "abc",
            Password = null,
        });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task CreateUserAsync_ReturnsNull_WhenEmailExists()
    {
        var uow = new Mock<IUnitOfWork>();
        var userRepo = new Mock<IUserRepository>();
        var progressRepo = new Mock<IUserProgressRepository>();

        userRepo.Setup(r => r.GetByEmailAsync("exists@koine.test")).ReturnsAsync(new User { Id = 1 });
        uow.SetupGet(x => x.Users).Returns(userRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(progressRepo.Object);

        var service = new UserService(uow.Object);
        var result = await service.CreateUserAsync(new CreateUserDto
        {
            Email = "exists@koine.test",
            Username = "exists",
            Password = "pw",
        });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task CreateUserAsync_CreatesUserAndProgress()
    {
        var uow = new Mock<IUnitOfWork>();
        var userRepo = new Mock<IUserRepository>();
        var progressRepo = new Mock<IUserProgressRepository>();

        userRepo.Setup(r => r.GetByEmailAsync(It.IsAny<string>())).ReturnsAsync((User?)null);
        userRepo.Setup(r => r.GetByUsernameAsync(It.IsAny<string>())).ReturnsAsync((User?)null);
        userRepo.Setup(r => r.AddAsync(It.IsAny<User>())).ReturnsAsync((User u) =>
        {
            u.Id = 22;
            return u;
        });

        progressRepo.Setup(r => r.GetOrCreateByUserIdAsync(22))
            .ReturnsAsync(new UserProgress { UserId = 22, UpdatedAt = DateTime.UtcNow });

        uow.SetupGet(x => x.Users).Returns(userRepo.Object);
        uow.SetupGet(x => x.UserProgress).Returns(progressRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new UserService(uow.Object);
        var result = await service.CreateUserAsync(new CreateUserDto
        {
            Email = "new@koine.test",
            Username = "new_user",
            Password = "safe_pw",
        });

        Assert.That(result, Is.Not.Null);
        Assert.That(result!.Id, Is.EqualTo(22));
        progressRepo.Verify(r => r.GetOrCreateByUserIdAsync(22), Times.Once);
    }

    [Test]
    public async Task UpdateUserSettingAsync_UpdatesExistingSetting()
    {
        var uow = new Mock<IUnitOfWork>();
        var userSettingRepo = new Mock<IUserSettingRepository>();

        var setting = new UserSetting
        {
            UserId = 1,
            SettingName = "translation",
            SettingValue = "esv",
        };

        userSettingRepo.Setup(r => r.GetByUserAndNameAsync(1, "translation")).ReturnsAsync(setting);
        uow.SetupGet(x => x.UserSettings).Returns(userSettingRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new UserService(uow.Object);
        var result = await service.UpdateUserSettingAsync(1, new UserSettingDto
        {
            SettingName = "translation",
            SettingValue = "niv",
        });

        Assert.That(result, Is.True);
        Assert.That(setting.SettingValue, Is.EqualTo("niv"));
        userSettingRepo.Verify(r => r.UpdateAsync(setting), Times.Once);
    }

    [Test]
    public async Task GetAllUsersAsync_ReturnsMappedUsers()
    {
        var uow = new Mock<IUnitOfWork>();
        var userRepo = new Mock<IUserRepository>();

        userRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<User>
        {
            new() { Id = 1, Email = "a@a.com", Username = "a" },
            new() { Id = 2, Email = "b@b.com", Username = "b", DisplayName = "Bee" },
        });
        uow.SetupGet(x => x.Users).Returns(userRepo.Object);

        var service = new UserService(uow.Object);
        var result = await service.GetAllUsersAsync();

        Assert.That(result, Has.Count.EqualTo(2));
        Assert.That(result[1].DisplayName, Is.EqualTo("Bee"));
    }

    [Test]
    public async Task GetUserByIdAsync_ReturnsNull_WhenNotFound()
    {
        var uow = new Mock<IUnitOfWork>();
        var userRepo = new Mock<IUserRepository>();

        userRepo.Setup(r => r.GetByIdAsync(77)).ReturnsAsync((User?)null);
        uow.SetupGet(x => x.Users).Returns(userRepo.Object);

        var service = new UserService(uow.Object);
        var result = await service.GetUserByIdAsync(77);

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task UpdateUserAsync_ReturnsNull_WhenMissing()
    {
        var uow = new Mock<IUnitOfWork>();
        var userRepo = new Mock<IUserRepository>();

        userRepo.Setup(r => r.GetByIdAsync(8)).ReturnsAsync((User?)null);
        uow.SetupGet(x => x.Users).Returns(userRepo.Object);

        var service = new UserService(uow.Object);
        var result = await service.UpdateUserAsync(8, new UpdateUserDto { DisplayName = "X" });

        Assert.That(result, Is.Null);
    }

    [Test]
    public async Task UpdateUserAsync_UpdatesFields_WhenFound()
    {
        var uow = new Mock<IUnitOfWork>();
        var userRepo = new Mock<IUserRepository>();
        var user = new User { Id = 9, Email = "old@a.com", Username = "old", DisplayName = "Old" };

        userRepo.Setup(r => r.GetByIdAsync(9)).ReturnsAsync(user);
        uow.SetupGet(x => x.Users).Returns(userRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new UserService(uow.Object);
        var result = await service.UpdateUserAsync(9, new UpdateUserDto
        {
            Email = "new@a.com",
            Username = "new",
            DisplayName = "New",
        });

        Assert.That(result, Is.Not.Null);
        Assert.That(user.Email, Is.EqualTo("new@a.com"));
        Assert.That(user.Username, Is.EqualTo("new"));
        Assert.That(user.DisplayName, Is.EqualTo("New"));
    }

    [Test]
    public async Task DeleteUserAsync_ReturnsTrue_WhenDeleted()
    {
        var uow = new Mock<IUnitOfWork>();
        var userRepo = new Mock<IUserRepository>();
        var user = new User { Id = 4 };

        userRepo.Setup(r => r.GetByIdAsync(4)).ReturnsAsync(user);
        uow.SetupGet(x => x.Users).Returns(userRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new UserService(uow.Object);
        var result = await service.DeleteUserAsync(4);

        Assert.That(result, Is.True);
        userRepo.Verify(r => r.DeleteAsync(user), Times.Once);
    }

    [Test]
    public async Task GetUserSettingsAsync_ReturnsMappedSettings()
    {
        var uow = new Mock<IUnitOfWork>();
        var settingRepo = new Mock<IUserSettingRepository>();

        settingRepo.Setup(r => r.GetByUserIdAsync(1)).ReturnsAsync(new List<UserSetting>
        {
            new() { UserId = 1, SettingName = "translation", SettingValue = "esv" },
        });
        uow.SetupGet(x => x.UserSettings).Returns(settingRepo.Object);

        var service = new UserService(uow.Object);
        var result = await service.GetUserSettingsAsync(1);

        Assert.That(result, Has.Count.EqualTo(1));
        Assert.That(result[0].SettingName, Is.EqualTo("translation"));
    }

    [Test]
    public async Task UpdateUserSettingAsync_AddsSetting_WhenMissing()
    {
        var uow = new Mock<IUnitOfWork>();
        var settingRepo = new Mock<IUserSettingRepository>();

        settingRepo.Setup(r => r.GetByUserAndNameAsync(3, "prefersDarkMode")).ReturnsAsync((UserSetting?)null);
        uow.SetupGet(x => x.UserSettings).Returns(settingRepo.Object);
        uow.Setup(x => x.SaveChangesAsync()).ReturnsAsync(1);

        var service = new UserService(uow.Object);
        var result = await service.UpdateUserSettingAsync(3, new UserSettingDto
        {
            SettingName = "prefersDarkMode",
            SettingValue = "false",
        });

        Assert.That(result, Is.True);
        settingRepo.Verify(r => r.AddAsync(It.Is<UserSetting>(s => s.UserId == 3 && s.SettingName == "prefersDarkMode")), Times.Once);
    }
}
