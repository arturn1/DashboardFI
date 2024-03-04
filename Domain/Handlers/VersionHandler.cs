using Domain.Commands;
using Domain.Commands.Contracts;
using Domain.Entities;
using Domain.Handlers.Contracts;
using Domain.Helpers;
using Domain.Repositories;
using System.Net;

namespace Domain.Handlers
{
    public class VersionHandler : IHandler<CreateVersionCommand>, IHandler<UpdateVersionCommand>
    {
        private readonly IVersionRepository _VersionRepository;
        private readonly IMapper _mapper;
        private readonly IEnvironmentRepository _environmentRepository;
        public VersionHandler(IVersionRepository VersionRepository, IMapper mapper, IEnvironmentRepository environmentRepository)
        {
            _VersionRepository = VersionRepository;
            _mapper = mapper;
            _environmentRepository = environmentRepository;
        }

        public async Task<ICommandResult> Handle(CreateVersionCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            var environment = await _environmentRepository.GetByIdAsync(command.EnvironmentId);
            VersionEntity entity = new(environment);
            _mapper.Map(command, entity);

            await _VersionRepository.PostAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
        }

        public async Task<ICommandResult> Handle(UpdateVersionCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            VersionEntity entity = await _VersionRepository.GetByIdAsync(command.Id);

            if (entity == null) return new CommandResult("Entity not found", HttpStatusCode.NotFound);

            _mapper.Map(command, entity);

            await _VersionRepository.UpdateAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);

        }

    }
}
