using HomeWork17.Application.Auth.Models.Login;

namespace HomeWork17.Application.Auth.Services
{
    public interface IloginService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
    }
}
