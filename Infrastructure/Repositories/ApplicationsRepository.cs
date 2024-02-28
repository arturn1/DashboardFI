using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Contrats;

namespace Infrastructure.Repositories
{
    public class ApplicationsRepository :
        RepositoryBase<ApplicationsEntity>,
        IApplicationsRepository
    {
        public ApplicationsRepository(ApplicationDbContext context, bool SaveChanges = true) : base(context, SaveChanges) { }
    }
}
