using Core;
using Core.Interfaces;


namespace WebApi.Controllers
{
	[ApiController]
	[Route("[Controllers]")]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}
		//esto solo deberia tirar un string
		[HttpPost("user/login")]
		public async Task<IActionResult> Authenticate([FromBody] User user)
		{
			var token = await _userService.AuthenticateUserAsync(user.Email, user.Password);
			if (token == null)
				return Unauthorized();

			return Ok(token);
		}

	}
}
