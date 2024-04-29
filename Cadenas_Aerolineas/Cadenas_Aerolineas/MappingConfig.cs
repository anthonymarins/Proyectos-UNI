using AutoMapper;
using Cadenas_Aerolineas.Models;
using Cadenas_Aerolineas.Models.Dto;

namespace Cadenas_Aerolineas
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Pasajeros, PasajerosDto>();
            CreateMap<PasajerosDto, Pasajeros>();

            CreateMap<Pasajeros, PasajerosCreate>().ReverseMap();
            CreateMap<Pasajeros, PasajerosUpdate>().ReverseMap();

            CreateMap<Paises, PaisesDto>();
            CreateMap<PaisesDto, Paises>();

            CreateMap<Paises, PaisesCreate>().ReverseMap();
            CreateMap<Paises, PaisesUpdate>().ReverseMap();
        }
    }
}
