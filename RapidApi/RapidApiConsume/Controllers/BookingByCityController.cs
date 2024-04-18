using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace RapidApiConsume.Controllers
{
	public class BookingByCityController : Controller
	{
		public async Task<IActionResult> Index(string cityID)
		{
			if (!string.IsNullOrEmpty(cityID))
			{
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={cityID}&search_type=CITY&arrival_date=2024-04-19&departure_date=2024-04-21&adults=1&children_age=0%2C17&room_qty=1&page_number=1&languagecode=en-us&currency_code=AED"),
					Headers =
	{
		{ "X-RapidAPI-Key", "13d2afcfd5mshbadf24aa040719ep12a2adjsn03878d1e4a78" },
		{ "X-RapidAPI-Host", "booking-com15.p.rapidapi.com" },
	},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
					return View(values.data.hotels.ToList());
				}
			}
			else
			{
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-2092174&search_type=CITY&arrival_date=2024-04-19&departure_date=2024-04-21&adults=1&children_age=0%2C17&room_qty=1&page_number=1&languagecode=en-us&currency_code=AED"),
					Headers =
	{
		{ "X-RapidAPI-Key", "13d2afcfd5mshbadf24aa040719ep12a2adjsn03878d1e4a78" },
		{ "X-RapidAPI-Host", "booking-com15.p.rapidapi.com" },
	},
				};
				using (var response = await client.SendAsync(request))
				{
					response.EnsureSuccessStatusCode();
					var body = await response.Content.ReadAsStringAsync();
					var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
					return View(values.data.hotels.ToList());
				}
			}
			
		}
	}
}
