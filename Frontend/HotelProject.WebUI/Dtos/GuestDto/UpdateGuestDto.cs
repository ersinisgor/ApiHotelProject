﻿using System;

namespace HotelProject.WebUI.Dtos.GuestDto
{
  public class UpdateGuestDto
  {
    public int GuestID { get; set; }
    public String Name { get; set; }
    public String Surname { get; set; }
    public String City { get; set; }
  }
}

