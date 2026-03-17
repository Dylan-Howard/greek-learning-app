using Koine.Application.DTOs.Features;
using Koine.Application.Interfaces;
using Koine.Application.Interfaces.Repositories;
using Koine.Application.Services;
using Koine.Domain.Entities;
using Moq;

namespace Koine.Tests.Unit;

[TestFixture]
public class FeatureServicesTests
{
    [Test]
    public async Task GrammaticalFeatureService_CreateUpdateDelete_Flow()
    {
        var unitOfWork = CreateUnitOfWork(out var gramRepo, out _);
        gramRepo.Setup(r => r.AddAsync(It.IsAny<GrammaticalFeature>()))
            .ReturnsAsync((GrammaticalFeature f) =>
            {
                f.Id = 5;
                return f;
            });
        gramRepo.Setup(r => r.GetByIdAsync(5)).ReturnsAsync(new GrammaticalFeature
        {
            Id = 5,
            Code = "AOR",
            Name = "Aorist",
            Category = "Verb",
            Definition = "Aorist definition",
            SortOrder = 1,
        });

        var service = new GrammaticalFeatureService(unitOfWork.Object);
        var created = await service.CreateFeatureAsync(new CreateGrammaticalFeatureDto
        {
            Code = "AOR",
            Name = "Aorist",
            Category = "Verb",
            Definition = "Aorist definition",
            SortOrder = 1,
        });

        Assert.That(created.Id, Is.EqualTo(5));

        var updated = await service.UpdateFeatureAsync(5, new UpdateGrammaticalFeatureDto
        {
            Code = "AOR",
            Name = "Aorist Updated",
            Category = "Verb",
            Definition = "Updated",
            SortOrder = 2,
        });

        Assert.That(updated, Is.Not.Null);
        Assert.That(updated!.Name, Is.EqualTo("Aorist Updated"));

        var deleted = await service.DeleteFeatureAsync(5);
        Assert.That(deleted, Is.True);
    }

    [Test]
    public async Task GrammaticalFeatureService_Getters_MapData()
    {
        var unitOfWork = CreateUnitOfWork(out var gramRepo, out _);
        gramRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<GrammaticalFeature>
        {
            new() { Id = 1, Code = "N", Name = "Noun", Category = "POS", Definition = "noun" },
        });
        gramRepo.Setup(r => r.GetByCodeAsync("N")).ReturnsAsync(new GrammaticalFeature
        {
            Id = 1,
            Code = "N",
            Name = "Noun",
            Category = "POS",
            Definition = "noun",
        });

        var service = new GrammaticalFeatureService(unitOfWork.Object);
        var all = await service.GetAllFeaturesAsync();
        var byCode = await service.GetFeatureByCodeAsync("N");

        Assert.That(all, Has.Count.EqualTo(1));
        Assert.That(byCode, Is.Not.Null);
        Assert.That(byCode!.Code, Is.EqualTo("N"));
    }

    [Test]
    public async Task SyntacticalFeatureService_CreateUpdateDelete_Flow()
    {
        var unitOfWork = CreateUnitOfWork(out _, out var synRepo);
        synRepo.Setup(r => r.AddAsync(It.IsAny<SyntacticalFeature>()))
            .ReturnsAsync((SyntacticalFeature f) =>
            {
                f.Id = 9;
                return f;
            });
        synRepo.Setup(r => r.GetByIdAsync(9)).ReturnsAsync(new SyntacticalFeature
        {
            Id = 9,
            Code = "SUBJ",
            Name = "Subject",
            Definition = "Subject function",
            SortOrder = 1,
        });

        var service = new SyntacticalFeatureService(unitOfWork.Object);
        var created = await service.CreateFeatureAsync(new CreateSyntacticalFeatureDto
        {
            Code = "SUBJ",
            Name = "Subject",
            Definition = "Subject function",
            SortOrder = 1,
        });
        Assert.That(created.Id, Is.EqualTo(9));

        var updated = await service.UpdateFeatureAsync(9, new UpdateSyntacticalFeatureDto
        {
            Code = "SUBJ",
            Name = "Subject Updated",
            Definition = "Updated",
            SortOrder = 2,
        });
        Assert.That(updated, Is.Not.Null);
        Assert.That(updated!.Name, Is.EqualTo("Subject Updated"));

        var deleted = await service.DeleteFeatureAsync(9);
        Assert.That(deleted, Is.True);
    }

    [Test]
    public async Task SyntacticalFeatureService_Getters_MapData()
    {
        var unitOfWork = CreateUnitOfWork(out _, out var synRepo);
        synRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<SyntacticalFeature>
        {
            new() { Id = 2, Code = "OBJ", Name = "Object", Definition = "object" },
        });
        synRepo.Setup(r => r.GetByCodeAsync("OBJ")).ReturnsAsync(new SyntacticalFeature
        {
            Id = 2,
            Code = "OBJ",
            Name = "Object",
            Definition = "object",
        });

        var service = new SyntacticalFeatureService(unitOfWork.Object);
        var all = await service.GetAllFeaturesAsync();
        var byCode = await service.GetFeatureByCodeAsync("OBJ");

        Assert.That(all, Has.Count.EqualTo(1));
        Assert.That(byCode, Is.Not.Null);
        Assert.That(byCode!.Code, Is.EqualTo("OBJ"));
    }

    private static Mock<IUnitOfWork> CreateUnitOfWork(
        out Mock<IGrammaticalFeatureRepository> grammaticalFeatures,
        out Mock<ISyntacticalFeatureRepository> syntacticalFeatures)
    {
        grammaticalFeatures = new Mock<IGrammaticalFeatureRepository>();
        syntacticalFeatures = new Mock<ISyntacticalFeatureRepository>();

        var unitOfWork = new Mock<IUnitOfWork>();
        unitOfWork.SetupGet(u => u.GrammaticalFeatures).Returns(grammaticalFeatures.Object);
        unitOfWork.SetupGet(u => u.SyntacticalFeatures).Returns(syntacticalFeatures.Object);
        unitOfWork.Setup(u => u.SaveChangesAsync()).ReturnsAsync(1);

        return unitOfWork;
    }
}
