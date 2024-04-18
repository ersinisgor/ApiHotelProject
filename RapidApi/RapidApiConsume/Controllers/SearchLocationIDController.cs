using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using RapidApiConsume.Models;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.CodeAnalysis.FlowAnalysis;

namespace RapidApiConsume.Controllers
{
  public class SearchLocationIDController : Controller
  {
    public async Task<IActionResult> Index(string cityName)
    {
    if (!string.IsNullOrEmpty(cityName))
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Get,
          RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={cityName}"),
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
          var model = JsonConvert.DeserializeObject<BookingApiLocationSerachViewModel>(body);
          return View(model.data.Take(1).ToList());

        }
      }
      else
      {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
          Method = HttpMethod.Get,
          RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query=paris"),
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
          var model = JsonConvert.DeserializeObject<BookingApiLocationSerachViewModel>(body);
          return View(model.data.Take(1).ToList());

        }
      }
      
    }
  }
}
