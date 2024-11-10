using E_TicktsCinma.Data;
using E_TicktsCinma.Models;
using E_TicktsCinma.Repository.IRepository;

namespace E_TicktsCinma.Repository
{
    public class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
