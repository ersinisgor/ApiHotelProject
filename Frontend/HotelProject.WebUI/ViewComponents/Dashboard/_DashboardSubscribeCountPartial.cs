using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardSubscribeCountPartial : ViewComponent
	{


		public async Task<IViewComponentResult> InvokeAsync()
		{
			//I have consumed all of the allocated API calls under my BASIC subscription to the followers endpoint in Rapid Api 



			//     var client = new HttpClient();
			//     var request = new HttpRequestMessage
			//     {
			//       Method = HttpMethod.Get,
			//       RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/murattycedag"),
			//       Headers =
			// {
			//   { "X-RapidAPI-Key", "13d2afcfd5mshbadf24aa040719ep12a2adjsn03878d1e4a78" },
			//   { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
			// },
			//     };
			//     using (var response = await client.SendAsync(request))
			//     {
			//       response.EnsureSuccessStatusCode();
			//       var body = await response.Content.ReadAsStringAsync();
			//       ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
			//       ViewBag.instagramFollowers = resultInstagramFollowersDtos.followers;
			//       ViewBag.instagramFollowings = resultInstagramFollowersDtos.following;

			//     }


			//		var client2 = new HttpClient();
			//		var request2 = new HttpRequestMessage
			//		{
			//			Method = HttpMethod.Get,
			//			RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=murattyucedag"),
			//			Headers =
			//{
			//	{ "X-RapidAPI-Key", "13d2afcfd5mshbadf24aa040719ep12a2adjsn03878d1e4a78" },
			//	{ "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
			//},
			//		};
			//		using (var response2 = await client2.SendAsync(request2))
			//		{
			//			response2.EnsureSuccessStatusCode();
			//			var body2 = await response2.Content.ReadAsStringAsync();
			//			ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
			//			ViewBag.twitterFollowers = resultTwitterFollowersDto.data.user_info.followers_count;
			//			ViewBag.twitterFollowings = resultTwitterFollowersDto.data.user_info.friends_count;
			//		}


			//		var client3 = new HttpClient();
			//		var request3 = new HttpRequestMessage
			//		{
			//			Method = HttpMethod.Get,
			//			RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmurat-y%C3%BCceda%C4%9F-186933149%2F&include_skills=false"),
			//			Headers =
			//{
			//	{ "X-RapidAPI-Key", "13d2afcfd5mshbadf24aa040719ep12a2adjsn03878d1e4a78" },
			//	{ "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
			//},
			//		};
			//		using (var response3 = await client3.SendAsync(request3))
			//		{
			//			response3.EnsureSuccessStatusCode();
			//			var body3 = await response3.Content.ReadAsStringAsync();
			//			ResultLinkedInFollowersDto resultLinkedInFollowersDto = JsonConvert.DeserializeObject<ResultLinkedInFollowersDto>(body3);
			//			ViewBag.linkedinFollowers = resultLinkedInFollowersDto.data.followers_count;

			//		}
			return View();
		}
	}
}
