using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork17.Application.Auth.Models.Login
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public RoleModel Roles { get; set; }

        public AuthenticateResponse(UserModel user, string token)
        {
            Id = user.Id;
            UserName = user.UserName;
            Token = token;
            Roles = user.Roles;
        }
    }

}
