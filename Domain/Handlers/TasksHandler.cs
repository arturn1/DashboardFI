using Domain.Commands;
using Domain.Commands.Contracts;
using Domain.Entities;
using Domain.Handlers.Contracts;
using Domain.Helpers;
using Domain.Repositories;
using System.Net;

namespace Domain.Handlers
{
    public class TasksHandler : IHandler<CreateTasksCommand>, IHandler<UpdateTasksCommand>
    {
        private readonly ITasksRepository _TasksRepository;
        private readonly IMapper _mapper;
        public TasksHandler(ITasksRepository TasksRepository, IMapper mapper)
        {
            _TasksRepository = TasksRepository;
            _mapper = mapper;
        }

        public async Task<ICommandResult> Handle(CreateTasksCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            TasksEntity entity = new ();
            _mapper.Map(command, entity);

            await _TasksRepository.PostAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
        }

        public async Task<ICommandResult> Handle(UpdateTasksCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            TasksEntity entity = await _TasksRepository.GetByIdAsync(command.Id);

            if (entity == null) return new CommandResult("Entity not found", HttpStatusCode.NotFound);

            _mapper.Map(command, entity);

            await _TasksRepository.UpdateAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
            
        }

    }
}
