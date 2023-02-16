using BidOneApi.Model;
using BidOneApi.Services;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;

namespace BidOneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, typeof(OkResult))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, typeof(void), Description = "Operation failed")]
        public async Task<IActionResult> SaveAsync([FromBody] User user)
        {
            await _userService.SaveAsync(user);
            return Ok();
        }
    }
}