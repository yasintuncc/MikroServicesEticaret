using AutoMapper;
using AutoMapper;
using tunc.Services.ProductAPI.Models;
using tunc.Services.ProductAPI.Models.Dto;

namespace tunc.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
