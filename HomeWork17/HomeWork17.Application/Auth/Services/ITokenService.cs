using Authentication.Models;
using Authentication.Models.Users;
using HomeWork17.Application.Auth.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork17.Application.Auth.Services
{
    public interface ITokenService
    {
        string BuildToken(UserModel users);
    }
}
