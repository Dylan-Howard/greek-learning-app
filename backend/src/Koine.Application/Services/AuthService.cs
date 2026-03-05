// Koine.Application/Services/AuthService.cs
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Koine.Application.DTOs.Auth;
using Koine.Application.Interfaces;
using Koine.Domain.Entities;

namespace Koine.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public AuthService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<LoginResponseDto?> LoginAsync(LoginRequestDto loginDto)
        {
            var user = await _unitOfWork.Users.GetByEmailAsync(loginDto.Email);
            if (user == null) return null;

            // Verify password (you'll need to implement proper password hashing)
            if (!VerifyPassword(loginDto.Password, user.PasswordHash))
                return null;

            user.LastLogin = DateTime.UtcNow;
            await _unitOfWork.Users.UpdateAsync(user);
            await _unitOfWork.SaveChangesAsync();

            var token = GenerateJwtToken(user);

            return new LoginResponseDto
            {
                Token = token,
                User = new UserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    Username = user.Username,
                    DisplayName = user.DisplayName,
                    TotalExperience = user.TotalExperience
                }
            };
        }

        public async Task<UserDto?> RegisterAsync(string email, string username, string password)
        {
            // Check if user already exists
            var existingUser = await _unitOfWork.Users.GetByEmailAsync(email);
            if (existingUser != null) return null;

            var existingUsername = await _unitOfWork.Users.GetByUsernameAsync(username);
            if (existingUsername != null) return null;

            var user = new User
            {
                Email = email,
                Username = username,
                PasswordHash = HashPassword(password),
                TotalExperience = 0,
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.SaveChangesAsync();

            // Create initial progress record
            await _unitOfWork.UserProgress.GetOrCreateByUserIdAsync(user.Id);

            return new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.Username,
                DisplayName = user.DisplayName,
                TotalExperience = user.TotalExperience
            };
        }

        public async Task<UserDto?> GetUserFromTokenAsync(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]!);

                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = _configuration["JwtSettings:Issuer"],
                    ValidAudience = _configuration["JwtSettings:Audience"],
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);

                var user = await _unitOfWork.Users.GetByIdAsync(userId);
                if (user == null) return null;

                return new UserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    Username = user.Username,
                    DisplayName = user.DisplayName,
                    TotalExperience = user.TotalExperience
                };
            }
            catch
            {
                return null;
            }
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]!);
            
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.Username)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                Issuer = _configuration["JwtSettings:Issuer"],
                Audience = _configuration["JwtSettings:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private string HashPassword(string password)
        {
            // TODO: Implement proper password hashing (BCrypt, Argon2, etc.)
            // This is just a placeholder
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }

        private bool VerifyPassword(string password, string hash)
        {
            // TODO: Implement proper password verification
            // This is just a placeholder
            var testHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
            return testHash == hash;
        }
    }
}
