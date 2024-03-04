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
        public EnvironmentRepository(ApplicationContext context, bool SaveChanges = true) : base(context, SaveChanges) { }
    }
}
