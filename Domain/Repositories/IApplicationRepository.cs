using Domain.Entities;
using Domain.Repositories.Contracts;

namespace Domain.Repositories
{
    public interface IApplicationRepository : IRepositoryBase<ApplicationEntity>
    {
        Task<List<ApplicationEntity>> GetAllIncludes();
    }
}
