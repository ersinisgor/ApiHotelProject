using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.MessageCategoryDto;
using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:11888/api/MessageCategory");

			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDto>>(jsonData);

			var defaultOption = new SelectListItem()
			{
				Text = "Subject Category",
				Value = "0"
			};

			var values2 = values.Select(x => new SelectListItem
			{
				Text = x.MessageCategoryName,
				Value = x.MessageCategoryID.ToString()
			})
															.ToList();
			values2.Insert(0, defaultOption);

			ViewBag.categories = values2;
			return View();

		}

		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
		{
			createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createContactDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			await client.PostAsync("http://localhost:11888/api/Contact", stringContent);
			return RedirectToAction("Index", "Default");
		}
	}
}
