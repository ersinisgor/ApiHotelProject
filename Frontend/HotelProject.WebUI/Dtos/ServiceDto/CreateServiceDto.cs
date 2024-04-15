using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
	public class CreateServiceDto
	{
		[Required(ErrorMessage = "Please enter service icon link")]
		public string ServiceIcon { get; set; }
		[Required(ErrorMessage = "Please enter service title")]
		[StringLength(100, ErrorMessage = "Service title must be at least 100 characters")]
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
