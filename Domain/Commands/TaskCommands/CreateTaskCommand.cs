using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands
{

    public class CreateTaskCommand : ValidatableTypes, ICommand
    {
        public CreateTaskCommand(string Tasks, Guid versionId)
        {

            this.Tasks = Tasks;
            VersionId = versionId;
        }
        public string Tasks { get; set; }
        public Guid VersionId { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}