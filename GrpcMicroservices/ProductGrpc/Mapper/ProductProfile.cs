using AutoMapper;
using Google.Protobuf.WellKnownTypes;
using ProductCommon.Models;
using ProductGrpc.Protos;

namespace ProductGrpc.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductModel>()
                .ForMember(pm => pm.CreatedTime, opt => opt.MapFrom(src => Timestamp.FromDateTime(src.CreatedTime)));

            CreateMap<ProductModel, Product>()
                .ForMember(p => p.CreatedTime, opt => opt.MapFrom(src => src.CreatedTime.ToDateTime()));                

            // note : not use reverseMap. Timestamp should be converted manually.
        }
    }
}
