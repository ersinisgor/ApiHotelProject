using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
	public class EfBookingDal : GenericRepository<Booking>, IBookingDal
	{
		public EfBookingDal(Context context) : base(context)
		{
		}

		public int GetBookingCount()
		{
			var context = new Context();
			var values = context.Bookings.Count();
			return values;
		}

		public List<Booking> GetLast6Bookings()
		{
			var context = new Context();
			var values = context.Bookings.OrderByDescending(x => x.BookingID).Take(6).ToList();
			return values;
		}

		public void MarkBookingStatusAsApproved(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Approved";
			context.SaveChanges();
		}

		public void MarkBookingStatusAsCancelled(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Cancelled";
			context.SaveChanges();
		}

		public void MarkBookingStatusAsPending(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Awaiting approval";
			context.SaveChanges();
		}

		public void MarkBookingStatusAsCallCustomer(int id)
		{
			var context = new Context();
			var values = context.Bookings.Find(id);
			values.Status = "Customer will be called";
			context.SaveChanges();
		}
	}
}
