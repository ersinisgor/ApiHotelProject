using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DefaultController : ControllerBase
	{
		[HttpGet("[action]")]
		public IActionResult CreateToken()
		{
			return Ok(new CreateToken().TokenCreate());
		}

		[HttpGet("[action]")]
		public IActionResult CreateAdminToken()
		{
			return Ok(new CreateToken().TokenCreateAdmin());
		}

		[Authorize]
		[HttpGet("[action]")]
		public IActionResult TestAuth()
		{
			return Ok("Authorized");
		}

		[Authorize(Roles ="admin,visitor")]
		[HttpGet("[action]")]
		public IActionResult TestAdminRole()
		{
			return Ok("Token successfull");
		}
	}
}
