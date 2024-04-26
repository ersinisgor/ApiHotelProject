﻿using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DashboardWidgetsController : ControllerBase
  {
    private readonly IStaffService _staffService;
    private readonly IBookingService _bookingService;

    public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService)
    {
      _staffService = staffService;
      _bookingService = bookingService;
    }

    [HttpGet("StaffCount")]
    public IActionResult StaffCount()
    {
      var staffCount = _staffService.TGetStaffCount();
      return Ok(staffCount);
    }


    [HttpGet("BookingCount")]
    public IActionResult BookingCount()
    {
      var bookingCount = _bookingService.TGetBookingCount();
      return Ok(bookingCount);
    }
  }
}
