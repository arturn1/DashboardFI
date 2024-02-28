using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class UpdateApplicationsCommand : ValidatableTypes, ICommand
    {
        public UpdateApplicationsCommand(Guid id, string Name, string Environment)
        {
            this.Id = id;
            this.Name = Name;
            this.Environment = Environment;

        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Environment { get; set; }


        public bool IsCommandValid()
        {
            ValidateGuidNotEmpty(Id, "Id");
            
            return this.isValid;
        }
    }
}