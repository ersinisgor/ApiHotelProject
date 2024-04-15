using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Room2Controller : ControllerBase
	{
		private readonly IRoomService _roomService;
		private readonly IMapper _mapper;

		public Room2Controller(IRoomService roomService, IMapper mapper)
		{
			_roomService = roomService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var rooms = _roomService.TGetList();
			return Ok(rooms);
		}

		[HttpPost]
		public IActionResult AddRoom(AddRoomDto addRoomDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}
			var room = _mapper.Map<Room>(addRoomDto);
			_roomService.TInsert(room);

			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}
			var room = _mapper.Map<Room>(updateRoomDto);
			_roomService.TUpdate(room);

			return Ok("Successfully Updated");
		}
	}
}
