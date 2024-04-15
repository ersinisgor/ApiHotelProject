using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class UpdateServiceDto
	{
		public int ServiceID { get; set; }

		[Required(ErrorMessage = "Please enter service icon link")]
		public string ServiceIcon { get; set; }

		[Required(ErrorMessage = "Please enter service title")]
		[StringLength(100, ErrorMessage = "Service title must be at least 100 characters")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Please enter service description")]
		[StringLength(500, ErrorMessage = "Service {0} must be at least {1} characters")]
		public string Description { get; set; }
	}
}
