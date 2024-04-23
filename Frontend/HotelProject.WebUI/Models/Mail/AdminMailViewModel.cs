using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Models.Mail
{
	public class AdminMailViewModel
	{
        public string Name { get; set; }
        public string SenderMail { get; set; }
        [Required(ErrorMessage ="The Receiver Email must not be empty")]
        public string ReceiverMail { get; set; }
        [Required(ErrorMessage = "The Subject must not be empty")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "The Body must not be empty")]
        public string Body { get; set; }
    }
}
