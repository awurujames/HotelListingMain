using AutoMapper;
using HotelListingMain.Data;
using HotelListingMain.Models;

namespace HotelListingMain.Configuration
{
    public class MapperInitializer : Profile 
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
            //IList<> 
        }
    }
}
