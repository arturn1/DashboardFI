using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands
{

    public class CreateTaskCommand : ValidatableTypes, ICommand
    {
        public CreateTaskCommand(string Name, Guid versionId, string Description = "")
        {

            this.Name = Name;
            this.VersionId = versionId;
            this.Description = Description;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid VersionId { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}