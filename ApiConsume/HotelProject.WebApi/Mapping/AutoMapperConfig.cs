using AutoMapper;

namespace HotelProject.WebApi.Mapping
{
	public class AutoMapperConfig : Profile
	{
        public AutoMapperConfig()
        {
						CreateMap<HotelProject.DtoLayer.Dtos.RoomDto.AddRoomDto,HotelProject.EntityLayer.Concrete.Room>();
						CreateMap<HotelProject.EntityLayer.Concrete.Room, HotelProject.DtoLayer.Dtos.RoomDto.AddRoomDto>();

						CreateMap<HotelProject.DtoLayer.Dtos.RoomDto.UpdateRoomDto,HotelProject.EntityLayer.Concrete.Room>().ReverseMap();
						CreateMap<HotelProject.EntityLayer.Concrete.Testimonial, HotelProject.DtoLayer.Dtos.TestimonialDto.TestimonialAddDto>().ReverseMap();

        }
    }
}
