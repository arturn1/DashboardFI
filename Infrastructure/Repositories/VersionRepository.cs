using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Contrats;

namespace Infrastructure.Repositories
{
    public class VersionRepository :
        RepositoryBase<VersionEntity>,
        IVersionRepository
    {
        public VersionRepository(ApplicationContext context, bool SaveChanges = true) : base(context, SaveChanges) { }
    }
}
