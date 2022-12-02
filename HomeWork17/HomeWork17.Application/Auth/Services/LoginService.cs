using Authentication.Models.Users;
using HomeWork17.Application.Auth.Models;
using HomeWork17.Application.Auth.Models.Login;
using System;

namespace HomeWork17.Application.Auth.Services
{
    public class LoginService : IloginService
    {
        private readonly ITokenService _tokenService;

        public LoginService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            //check user userName and password in DB
            var user = new UserModel();
            if (model.UserName.Equals("Admin") && model.Password.Equals("Admin"))
            {
                user.Id = 1;
                user.UserName = model.UserName;
                user.Roles = new RoleModel() { Id = 1, RoleName = new string[] { "Admin", "User" } };
            }
            else
            {
                user.Id = 2;
                user.UserName = model.UserName;
                user.Roles = new RoleModel() { Id = 2, RoleName = new string[] { "User" } };
            }


            if (user == null) return null;

            var token = _tokenService.BuildToken(user);

            return new AuthenticateResponse(user, token);
        }
    }
}
