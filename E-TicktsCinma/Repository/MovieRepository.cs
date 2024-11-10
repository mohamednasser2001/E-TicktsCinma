using E_TicktsCinma.Data;
using E_TicktsCinma.Models;
using E_TicktsCinma.Repository.IRepository;

namespace E_TicktsCinma.Repository
{
    public class MovieRepository:Repository<Movie>,IMovieRepository
    {
        private readonly ApplicationDbContext dbContext;

        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
