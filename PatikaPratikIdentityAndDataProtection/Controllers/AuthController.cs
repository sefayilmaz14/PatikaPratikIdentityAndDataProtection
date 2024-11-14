using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaPratikIdentityAndDataProtection.DataProtection;
using PatikaPratikIdentityAndDataProtection.Dtos;
using PatikaPratikIdentityAndDataProtection.Models;
using PatikaPratikIdentityAndDataProtection.Services;

namespace PatikaPratikIdentityAndDataProtection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IDataProtection _protector;

        public AuthController(IUserService userService , IDataProtection protector)
        {
            _userService = userService;
            _protector = protector;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var addUserDto = new AddUserDto
            {
                Email = request.Email,
                Password = _protector.Protect(request.Password),
            };

           var result = await _userService.AddUser(addUserDto);

            if (result.IsSucceed)
                return Ok();
            else
                return BadRequest();
            
        }

       
    }
}
