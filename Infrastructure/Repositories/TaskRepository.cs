using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Contrats;

namespace Infrastructure.Repositories
{
    public class TaskRepository :
        RepositoryBase<TaskEntity>,
        ITaskRepository
    {
        public TaskRepository(ApplicationContext context, bool SaveChanges = true) : base(context, SaveChanges) { }
    }
}
