using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
	public interface IBookingService : IGenericService<Booking>
	{
		int TGetBookingCount();
		List<Booking> TGetLast6Bookings();
		void TMarkBookingStatusAsApproved(int id);
		void TMarkBookingStatusAsCancelled(int id);
		void TMarkBookingStatusAsPending(int id);
		void TMarkBookingStatusAsCallCustomer(int id);

	}

}

