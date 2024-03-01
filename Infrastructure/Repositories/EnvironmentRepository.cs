using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Contrats;

namespace Infrastructure.Repositories
{
    public class EnvironmentRepository :
        RepositoryBase<EnvironmentEntity>,
        IEnvironmentRepository
    {
        public EnvironmentRepository(ApplicationDbContext context, bool SaveChanges = true) : base(context, SaveChanges) { }
    }
}
