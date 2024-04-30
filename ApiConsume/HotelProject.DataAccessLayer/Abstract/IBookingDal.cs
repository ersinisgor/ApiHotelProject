using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
  public interface IBookingDal : IGenericDal<Booking>
  {
    int GetBookingCount();
    List<Booking> GetLast6Bookings();

		void MarkBookingStatusAsApproved(int id);
    void MarkBookingStatusAsCancelled(int id);
    void MarkBookingStatusAsPending(int id);
    void MarkBookingStatusAsCallCustomer(int id);
	}
}
