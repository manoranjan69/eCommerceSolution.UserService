using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthController(IUserService userService)
        {
                _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult>Register(RegisterRequest registerrequest)
        {
            if (registerrequest==null)
            {
                return BadRequest("invalid request data");
            }

       AuthenticationResponse? authenticationResponse=   await  _userService.Register(registerrequest);
            if (authenticationResponse == null || authenticationResponse.Success==false) 
            { 
             return BadRequest(authenticationResponse);
            
            }

            return Ok(authenticationResponse);
           
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (loginRequest == null) {

                return BadRequest("Invalid Login details");
            }

             AuthenticationResponse ? authenticationResponse= await _userService.Login(loginRequest);
            if (authenticationResponse==null || authenticationResponse.Success==false)
            {
                return Unauthorized(authenticationResponse);
            }
            return Ok(authenticationResponse);
        }
    }
}
