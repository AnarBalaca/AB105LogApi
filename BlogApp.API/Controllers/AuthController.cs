using BlogApp.Business.Services.Interfaces;
using BlogApp.Core.DTOs.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAccountService _accountService;


        public AuthController(IAccountService accountService)
        {
            _accountService = accountService;
        }



        
        [HttpPost("[action]")]

        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (registerDto == null) {

                return BadRequest();
            }

            var data = await _accountService.Register(registerDto);


            if (!data) 
            {
                return BadRequest();
            }
            return StatusCode(StatusCodes.Status201Created, data);

        
        }

    }
}
