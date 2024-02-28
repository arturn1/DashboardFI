using Domain.Commands;
using Domain.Commands.Contracts;
using Domain.Entities;
using Domain.Handlers.Contracts;
using Domain.Helpers;
using Domain.Repositories;
using System.Net;

namespace Domain.Handlers
{
    public class ApplicationsHandler : IHandler<CreateApplicationsCommand>, IHandler<UpdateApplicationsCommand>
    {
        private readonly IApplicationsRepository _ApplicationsRepository;
        private readonly IMapper _mapper;
        public ApplicationsHandler(IApplicationsRepository ApplicationsRepository, IMapper mapper)
        {
            _ApplicationsRepository = ApplicationsRepository;
            _mapper = mapper;
        }

        public async Task<ICommandResult> Handle(CreateApplicationsCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            ApplicationsEntity entity = new ();
            _mapper.Map(command, entity);

            await _ApplicationsRepository.PostAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
        }

        public async Task<ICommandResult> Handle(UpdateApplicationsCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            ApplicationsEntity entity = await _ApplicationsRepository.GetByIdAsync(command.Id);

            if (entity == null) return new CommandResult("Entity not found", HttpStatusCode.NotFound);

            _mapper.Map(command, entity);

            await _ApplicationsRepository.UpdateAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
            
        }

    }
}
