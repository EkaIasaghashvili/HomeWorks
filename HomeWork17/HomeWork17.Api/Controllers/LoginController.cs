using HomeWork17.Application.Auth.Models.Login;
using HomeWork17.Application.Auth.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork17.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        public readonly IloginService _loginService;
        public LoginController(IloginService loginSevice)
        {
            _loginService = loginSevice;
        }

        [HttpPost("Login")]
        public ActionResult Login(AuthenticateRequest model)
        {
            var response = _loginService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "UserName or password is incorrect" });

            return Ok(response);
        }
    }
}
