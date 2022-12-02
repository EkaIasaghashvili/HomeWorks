using Authentication.Models;
using Authentication.Models.Users;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Authentication.Services
{
    public class TokenService : ITokenService
    {
        //private readonly AppSettings _appSettings;

        //public TokenService(AppSettings appSettings)
        //{
        //    _appSettings = appSettings;
        //}

        public string BuildToken(UserModel user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            //var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

            var claims = new Claim[]
            {
                new Claim("Id", user.Id.ToString()),
                new Claim("Name", user.Name.ToString()),
                new Claim("UserName", user.UserName.ToString()),
                new Claim("Type", user.Type.ToString())
            };

            var newClaim = claims.ToList();

            foreach (var role in user.Roles.RoleName)
            {
                newClaim.Add(new Claim(ClaimTypes.Role, role));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(newClaim),

                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
