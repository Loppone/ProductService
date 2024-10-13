using GenericService;

public class ProductMappingBusinessProfile : GenericMappingProfile<ProductService.Models.Business.Product, ProductService.Models.Data.Product>
{
    public ProductMappingBusinessProfile()
    {
        CreateMap<ProductService.Models.Data.Product, ProductService.Models.Business.Product>()
            .ForMember(d => d.Category, opt => opt.MapFrom(s => s.Category))
            .ReverseMap();

        CreateMap<ProductService.Models.Data.Category, ProductService.Models.Business.Category>()
            .ReverseMap();
    }
}
