using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Contrats;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ApplicationRepository :
        RepositoryBase<ApplicationEntity>,
        IApplicationRepository
    {

        private readonly ApplicationDbContext _applicationDb;

        public ApplicationRepository(ApplicationDbContext context, bool SaveChanges = true) : base(context, SaveChanges)
        {
            _applicationDb = context;
        }

        public async Task<List<ApplicationEntity>> GetAllIncludes()
        {
            var apps = await _applicationDb.Application
                .Include(e => e.Environments)
                .ThenInclude(v => v.Versions.OrderByDescending(d => d.ReleaseDate))
                .ThenInclude(t => t.Tasks)
                .ToListAsync();

            return apps;
        }
    }
}
