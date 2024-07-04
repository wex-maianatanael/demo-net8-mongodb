using Demo.Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserApplicationService _userAppService;

        public UsersController(ILogger<UsersController> logger, IUserApplicationService userAppService)
        {
            _logger = logger;
            _userAppService = userAppService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var response = await _userAppService.GetAllAsync();
            return Ok(response);
        }
    }
}
