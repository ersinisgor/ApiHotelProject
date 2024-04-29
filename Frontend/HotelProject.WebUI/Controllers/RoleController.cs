using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class RoleController : Controller
	{
		private readonly RoleManager<AppRole> _roleManager;

		public RoleController(RoleManager<AppRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public IActionResult Index()
		{
			var values = _roleManager.Roles.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddRole()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddRole(AddRoleViewModel addRoleViewModel)
		{
			AppRole role = new AppRole()
			{
				Name = addRoleViewModel.RoleName
			};
			var result = await _roleManager.CreateAsync(role);
			if (result.Succeeded)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		public async Task<IActionResult> DeleteRole(int id)
		{
			var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			await _roleManager.DeleteAsync(role);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateRole(int id)
		{
			var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel
			{
				RoleID = role.Id,
				RoleName = role.Name
			};
			return View(updateRoleViewModel);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateRole(UpdateRoleViewModel updateRoleViewModel)
		{
			var role = _roleManager.Roles.FirstOrDefault(x => x.Id == updateRoleViewModel.RoleID);
			role.Name = updateRoleViewModel.RoleName;
			await _roleManager.UpdateAsync(role);
			return RedirectToAction("Index");
		}
	}
}

