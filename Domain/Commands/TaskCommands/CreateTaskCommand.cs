using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class CreateTaskCommand : ValidatableTypes, ICommand
    {
        public CreateTaskCommand(string Tasks)
        {
            
            this.Tasks = Tasks;

        }
        public string Tasks { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}