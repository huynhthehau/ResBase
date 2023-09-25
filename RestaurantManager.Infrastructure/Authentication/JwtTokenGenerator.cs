using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RestaurantManager.Application.Common.Interfaces.Authentication;
using RestaurantManager.Application.Common.Interfaces.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RestaurantManager.Infrastructure.Authentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly JwtSettings _jwtSettings;

        public JwtTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtOptions)
        {
            this._dateTimeProvider = dateTimeProvider;
            this._jwtSettings = jwtOptions.Value;
        }
        public string GenerateToken(Guid userId)
        {
            var siginingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtSettings.Secret)
                ),SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,userId.ToString())
            };
            var securityToken = new JwtSecurityToken(issuer: _jwtSettings.Issuer,
                                                        audience: _jwtSettings.Audience,
                                                     expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                                                     claims: claims,
                                                     signingCredentials:siginingCredentials);
            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
