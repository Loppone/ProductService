using GenericService;

public class ProductMappingDtoProfile : GenericMappingProfile<ProductService.Models.Dto.Product, ProductService.Models.Business.Product>
{
    public ProductMappingDtoProfile()
    {
        CreateMap<ProductService.Models.Dto.Product, ProductService.Models.Business.Product>()
        .ReverseMap();
    }
}
