using Domain.Commands;
using Domain.Commands.Contracts;
using Domain.Entities;
using Domain.Handlers.Contracts;
using Domain.Helpers;
using Domain.Repositories;
using System.Net;

namespace Domain.Handlers
{
    public class ApplicationHandler : IHandler<CreateApplicationCommand>, IHandler<UpdateApplicationCommand>
    {
        private readonly IApplicationRepository _ApplicationRepository;
        private readonly IMapper _mapper;
        public ApplicationHandler(IApplicationRepository ApplicationRepository, IMapper mapper)
        {
            _ApplicationRepository = ApplicationRepository;
            _mapper = mapper;
        }

        public async Task<ICommandResult> Handle(CreateApplicationCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            ApplicationEntity entity = new ();
            _mapper.Map(command, entity);

            await _ApplicationRepository.PostAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
        }

        public async Task<ICommandResult> Handle(UpdateApplicationCommand command)
        {
            command.IsCommandValid();

            if (!command.isValid)
            {
                return new CommandResult(command.Errors, HttpStatusCode.BadRequest);
            }


            ApplicationEntity entity = await _ApplicationRepository.GetByIdAsync(command.Id);

            if (entity == null) return new CommandResult("Entity not found", HttpStatusCode.NotFound);

            _mapper.Map(command, entity);

            await _ApplicationRepository.UpdateAsync(entity);

            return new CommandResult(entity, HttpStatusCode.Created);
            
        }

    }
}
