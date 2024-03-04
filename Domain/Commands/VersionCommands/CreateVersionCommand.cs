using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands
{

    public class CreateVersionCommand : ValidatableTypes, ICommand
    {
        public CreateVersionCommand(string Name, DateTime ReleaseDate, Guid environmentId)
        {

            this.Name = Name;
            this.ReleaseDate = ReleaseDate;
            EnvironmentId=environmentId;
        }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Guid EnvironmentId { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}