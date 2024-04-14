using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
	public class UpdateRoomDto
	{
		public int RoomID { get; set; }
		[Required(ErrorMessage = "Please enter the room number")]
		public string RoomNumber { get; set; }
		[Required(ErrorMessage = "Please add room image")]
		public string RoomCoverImage { get; set; }
		[Required(ErrorMessage = "Please enter the price")]
		public int Price { get; set; }
		[Required(ErrorMessage = "Please enter the room title")]
		[StringLength(100, ErrorMessage = "Please enter data up to 100 characters.")]
		public string Title { get; set; }
		[Required(ErrorMessage = "Please enter the number of bed")]
		public string BedCount { get; set; }
		[Required(ErrorMessage = "Please enter the number of bath")]
		public string BathCount { get; set; }
		public string Wifi { get; set; }
		[Required(ErrorMessage = "Please enter desceription")]
		public string Description { get; set; }
	}
}
