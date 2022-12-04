using Authentication.Models;
using Authentication.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.Services
{
    public interface ITokenService
    {
        string BuildToken(UserModel users);
    }
}
