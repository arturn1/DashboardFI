using Domain.Commands;
using Domain.Commands.Contracts;
using Domain.Entities;
using Domain.Handlers.Contracts;
using Domain.Helpers;
using Domain.Repositories;
using System.Net;

namespace Domain.Handlers
{
    public class TaskHandler : IHandler<CreateTaskCommand>, IHandler<UpdateTaskCommand>
    {
        private readonly ITaskRepository _TaskRepository;
        private readonly IMapper _mapper;
        private readonly IVersionRepository _versionRepository;
        public TaskHandler(ITaskRepository TaskRepository, IMapper mapper, IVersionRepository versionRepository)
        {
            _TaskRepository = TaskRepository;
            _mapper = mapper;
            _versionRepository = versionRepository;
        }

        public async Task<ICommandResult> Handle(CreateTaskCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }

            var version = await _versionRepository.GetByIdAsync(command.VersionId);

            TaskEntity entity = new (version);
            _mapper.Map(command, entity);

            await _TaskRepository.PostAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
        }

        public async Task<ICommandResult> Handle(UpdateTaskCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            TaskEntity entity = await _TaskRepository.GetByIdAsync(command.Id);

            if (entity == null) return new CommandResult("Entity not found", HttpStatusCode.NotFound);

            _mapper.Map(command, entity);

            await _TaskRepository.UpdateAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
            
        }

    }
}
