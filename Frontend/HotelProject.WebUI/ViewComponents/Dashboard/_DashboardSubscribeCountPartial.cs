using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using HotelProject.WebUI.Dtos.FollowersDto;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
  public class _DashboardSubscribeCountPartial : ViewComponent
  {


    public async Task<IViewComponentResult> InvokeAsync()
    {

      var client = new HttpClient();
      var request = new HttpRequestMessage
      {
        Method = HttpMethod.Get,
        RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/murattycedag"),
        Headers =
  {
    { "X-RapidAPI-Key", "13d2afcfd5mshbadf24aa040719ep12a2adjsn03878d1e4a78" },
    { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
  },
      };
      using (var response = await client.SendAsync(request))
      {
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
        return View(resultInstagramFollowersDtos);
      }

    }
  }
}
