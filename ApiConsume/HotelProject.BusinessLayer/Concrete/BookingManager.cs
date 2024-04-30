﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class BookingManager : IBookingService
	{
		private readonly IBookingDal _bookingDal;

		public BookingManager(IBookingDal bookingDal)
		{
			_bookingDal = bookingDal;
		}

		public void TDelete(Booking t)
		{
			_bookingDal.Delete(t);
		}

		public int TGetBookingCount()
		{
			return _bookingDal.GetBookingCount();
		}

		public Booking TGetByID(int id)
		{
			return _bookingDal.GetByID(id);
		}

		public List<Booking> TGetLast6Bookings()
		{
			return _bookingDal.GetLast6Bookings();
		}

		public List<Booking> TGetList()
		{
			return _bookingDal.GetList();
		}

		public void TInsert(Booking t)
		{
			_bookingDal.Insert(t);
		}

		public void TUpdate(Booking t)
		{
			_bookingDal.Update(t);
		}

		public void TMarkBookingStatusAsApproved(int id)
		{
			_bookingDal.MarkBookingStatusAsApproved(id);
		}

		public void TMarkBookingStatusAsCancelled(int id)
		{
			_bookingDal.MarkBookingStatusAsCancelled(id);
		}

		public void TMarkBookingStatusAsPending(int id)
		{
			_bookingDal.MarkBookingStatusAsPending(id);
		}

		public void TMarkBookingStatusAsCallCustomer(int id)
		{
			_bookingDal.MarkBookingStatusAsCallCustomer(id);
		}
	}
}
