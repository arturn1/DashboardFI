using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class UpdateVersionCommand : ValidatableTypes, ICommand
    {
        public UpdateVersionCommand(Guid id, string Name)
        {
            this.Id = id;
            this.Name = Name;

        }

        public Guid Id { get; set; }
        public string Name { get; set; }


        public bool IsCommandValid()
        {
            ValidateGuidNotEmpty(Id, "Id");
            
            return this.isValid;
        }
    }
}