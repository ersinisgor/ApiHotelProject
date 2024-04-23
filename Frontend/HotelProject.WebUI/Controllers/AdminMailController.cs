using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MimeKit;


namespace HotelProject.WebUI.Controllers
{
	public class AdminMailController : Controller
	{
	private IConfiguration _configuration;

    public AdminMailController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    [HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(AdminMailViewModel model)
		{
			MimeMessage mimeMessage = new MimeMessage();

			MailboxAddress mailboxAddressfrom = new MailboxAddress("Hotelier Admin", _configuration["EmailConfig:Email"]);
			mimeMessage.From.Add(mailboxAddressfrom);

			MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = model.Body;
			mimeMessage.Body = bodyBuilder.ToMessageBody();

			mimeMessage.Subject = model.Subject;

      using (var client = new SmtpClient())
      {
        client.Connect("smtp.gmail.com", 587, false);
        client.Authenticate(_configuration["EmailConfig:Email"], _configuration["EmailConfig:Password"]);
        client.Send(mimeMessage);
        client.Disconnect(true);
      }

      return RedirectToAction("Index");
    }
	}
}
