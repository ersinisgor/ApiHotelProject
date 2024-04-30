using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingController : ControllerBase
	{
		private readonly IBookingService _bookingService;

		public BookingController(IBookingService bookingService)
		{
			_bookingService = bookingService;
		}

		[HttpGet]
		public IActionResult BookingList()
		{
			var values = _bookingService.TGetList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddBooking(Booking booking)
		{
			_bookingService.TInsert(booking);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteBooking(int id)
		{
			var values = _bookingService.TGetByID(id);
			_bookingService.TDelete(values);
			return Ok();
		}

		[HttpPut("UpdateBooking")]
		public IActionResult UpdateBooking(Booking booking)
		{
			_bookingService.TUpdate(booking);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetBooking(int id)
		{
			var values = _bookingService.TGetByID(id);
			return Ok(values);
		}


		[HttpGet("GetLast6Bookings")]
		public IActionResult GetLast6Bookings()
		{
			var values = _bookingService.TGetLast6Bookings();
			return Ok(values);
		}

		[HttpGet("BookingApprove")]
		public IActionResult BookingApprove(int id)
		{
			_bookingService.TMarkBookingStatusAsApproved(id);
			return Ok();
		}

		[HttpGet("BookingCancel")]
		public IActionResult BookingCancel(int id)
		{
			_bookingService.TMarkBookingStatusAsCancelled(id);
			return Ok();
		}

		[HttpGet("BookingPending")]
		public IActionResult BookingPending(int id)
		{
			_bookingService.TMarkBookingStatusAsPending(id);
			return Ok();
		}

		[HttpGet("BookingCallCustomer")]
		public IActionResult BookingCallCustomer(int id)
		{
			_bookingService.TMarkBookingStatusAsCallCustomer(id);
			return Ok();
		}
	}
}
