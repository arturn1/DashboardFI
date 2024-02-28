using Domain.Commands;
using Domain.Commands.Contracts;
using Domain.Entities;
using Domain.Handlers.Contracts;
using Domain.Helpers;
using Domain.Repositories;
using System.Net;

namespace Domain.Handlers
{
    public class EnvironmentHandler : IHandler<CreateEnvironmentCommand>, IHandler<UpdateEnvironmentCommand>
    {
        private readonly IEnvironmentRepository _EnvironmentRepository;
        private readonly IMapper _mapper;
        public EnvironmentHandler(IEnvironmentRepository EnvironmentRepository, IMapper mapper)
        {
            _EnvironmentRepository = EnvironmentRepository;
            _mapper = mapper;
        }

        public async Task<ICommandResult> Handle(CreateEnvironmentCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            EnvironmentEntity entity = new ();
            _mapper.Map(command, entity);

            await _EnvironmentRepository.PostAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
        }

        public async Task<ICommandResult> Handle(UpdateEnvironmentCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            EnvironmentEntity entity = await _EnvironmentRepository.GetByIdAsync(command.Id);

            if (entity == null) return new CommandResult("Entity not found", HttpStatusCode.NotFound);

            _mapper.Map(command, entity);

            await _EnvironmentRepository.UpdateAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
            
        }

    }
}
