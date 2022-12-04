using Authentication.Models;
using HomeWork17.Application.Auth.Models;
using HomeWork17.Application.Settings;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace HomeWork17.Application.Auth.Services
{
    public class TokenService : ITokenService
    {
        private readonly IAppSettings _appSettings;

        public TokenService(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public string BuildToken(UserModel user)
        {
            var claims = GetClaims(user);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),

                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private List<Claim> GetClaims(UserModel user)
        {
            var claims = new Claim[]
           {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName.ToString())
           };

            var newClaim = claims.ToList();

            foreach (var role in user.Roles.RoleName)
            {
                newClaim.Add(new Claim(ClaimTypes.Role, role));
            }

            return newClaim;
        }
    }
}
