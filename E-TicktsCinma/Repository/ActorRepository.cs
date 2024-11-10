using E_TicktsCinma.Data;
using E_TicktsCinma.Models;
using E_TicktsCinma.Repository.IRepository;

namespace E_TicktsCinma.Repository
{
    public class ActorRepository:Repository<Actor>,IActorRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ActorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
