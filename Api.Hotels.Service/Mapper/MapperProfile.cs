using Api.Hotels.Entity;
using Api.Hotels.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Hotels.Service.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Hotel, HotelModel>();
            CreateMap<HotelModel, Hotel>();
        }
    }
}
