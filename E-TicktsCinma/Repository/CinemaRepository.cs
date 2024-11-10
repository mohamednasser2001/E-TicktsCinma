using E_TicktsCinma.Data;
using E_TicktsCinma.Models;
using E_TicktsCinma.Repository.IRepository;

namespace E_TicktsCinma.Repository
{
    public class CinemaRepository:Repository<Cinema>,ICinemaRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CinemaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
