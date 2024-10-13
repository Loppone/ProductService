using AutoMapper;
using ProductService.Models.Business;

namespace ProductService
{
    public class CustomProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CustomProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var dataEntity = await _productRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<Product>>(dataEntity);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var dataEntity = await _productRepository.GetByIdAsync(id);

            return _mapper.Map<Product>(dataEntity);
        }
    }
}
