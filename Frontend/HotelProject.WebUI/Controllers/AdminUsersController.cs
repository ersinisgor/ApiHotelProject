using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelProject.WebUI.Controllers
{
	public class AdminUsersController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public AdminUsersController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			var users = _userManager.Users.Select(x => new AppUser
						{
				Name = x.Name,
				Surname = x.Surname,
				City = x.City,
				ImageUrl = x.ImageUrl,
				WorkLocationID = x.WorkLocationID,
				WorkLocation = x.WorkLocation
			}).ToList();
			return View(users);
		}
	}
}
