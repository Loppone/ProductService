using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductService;
using ProductService.Data;
using ProductService.Models.Data;

namespace OrderService
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _ctx;
        private readonly IMapper _mapper;

        public ProductRepository(ProductDbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var data = await BaseQuery()
                .ToListAsync();

            return data;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var data = await BaseQuery()
                .FirstOrDefaultAsync(x => x.Id == id);

            return data!;
        }

        private IQueryable<Product> BaseQuery()
        {
            return _ctx.Products
            .AsNoTracking()
            .Include(x => x.Category);
        }
    }
}
