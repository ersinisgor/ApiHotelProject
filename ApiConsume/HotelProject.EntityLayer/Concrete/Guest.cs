using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
	public class Guest
	{
        public int GuestID { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String City { get; set; }
    }
}
