using AutoMapper;
using eCommerce.OrdersMicroservice.BusinessLogicLayer.DTO;
using eCommerce.OrdersMicroservice.DataAccessLayer.Entities;

namespace eCommerce.ordersMicroservice.BusinessLogicLayer.Mappers;

public class ProductDTOToOrderItemResponseMappingProfile : Profile
{
    public ProductDTOToOrderItemResponseMappingProfile()
    {
        CreateMap<ProductDTO, OrderItemResponse>()
          .ForMember(dest => dest.ProductID, opt => opt.Ignore())
          .ForMember(dest => dest.UnitPrice, opt => opt.Ignore())
          .ForMember(dest => dest.Quantity, opt => opt.Ignore())
          .ForMember(dest => dest.TotalPrice, opt => opt.Ignore())
          .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
          .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductName));
    }
}