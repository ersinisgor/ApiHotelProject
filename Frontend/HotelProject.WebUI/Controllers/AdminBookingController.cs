using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class AdminBookingController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AdminBookingController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:11888/api/Booking");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var value = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
				return View(value);
			}

			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateBooking(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:11888/api/Booking/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateBookingDto>(jsonData);
				return View(values);
			}

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateBookingDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("http://localhost:11888/api/Booking/UpdateBooking", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();
		}

		public async Task<IActionResult> ChangeBookingStatusToApproved(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:11888/api/Booking/BookingApprove/?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		public async Task<IActionResult> ChangeBookingStatusToCancelled(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:11888/api/Booking/BookingCancel/?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		public async Task<IActionResult> ChangeBookingStatusToPending(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:11888/api/Booking/BookingPending/?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		public async Task<IActionResult> ChangeBookingStatusToCallCustomer(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:11888/api/Booking/BookingCallCustomer/?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

	}
}
