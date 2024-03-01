using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class UpdateTaskCommand : ValidatableTypes, ICommand
    {
        public UpdateTaskCommand(Guid id, string Tasks)
        {
            this.Id = id;
            this.Tasks = Tasks;

        }

        public Guid Id { get; set; }
        public string Tasks { get; set; }


        public bool IsCommandValid()
        {
            ValidateGuidNotEmpty(Id, "Id");
            
            return this.isValid;
        }
    }
}