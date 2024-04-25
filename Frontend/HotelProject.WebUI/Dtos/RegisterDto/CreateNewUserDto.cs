using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
	public class CreateNewUserDto
	{
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Surname is required")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "User Name is required")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Mail is required")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm Password is required")]
		[Compare("Password", ErrorMessage = "Password and Confirm Password must be same")]
		public string ConfirmPassword { get; set; }

		public int WorkLocationID { get; set; } 
	}
}
