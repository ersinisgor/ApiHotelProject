﻿using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class AdminContactController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AdminContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Inbox()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:11888/api/Contact");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
				return View(values);
			}

			return View();
		}

		[HttpGet]
		public IActionResult AddSendMessage()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddSendMessage(CreateSendMessageDto createSendMessageDto)
		{
			createSendMessageDto.SenderMail = "admin@gmail.com";
			createSendMessageDto.SenderName = "Admin";
			createSendMessageDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createSendMessageDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:11888/api/SendMessage", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("SendBox");
			}

			return View();
		}


		public PartialViewResult SideBarAdminContactPartial()
		{
			return PartialView();
		}

		public PartialViewResult SideBarAdminContactCategoryPartial()
		{
			return PartialView();
		}
	}
}