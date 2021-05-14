using Microsoft.AspNetCore.Mvc;
using PM_SLABCODE.Models;
using PM_SLABCODE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM_SLABCODE.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IIdentityService _identityService;

        public AuthController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> LoginAsync([FromBody] LoginModel loginModel)
        {
            var result = await _identityService.LoginAsync(loginModel);
            return Ok(result);
        }
    }
}
