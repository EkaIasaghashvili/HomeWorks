using Authentication.Models.Login;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.Services
{
    public interface IloginService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
    }
}
