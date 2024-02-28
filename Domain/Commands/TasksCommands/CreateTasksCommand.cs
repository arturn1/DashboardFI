using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class CreateTasksCommand : ValidatableTypes, ICommand
    {
        public CreateTasksCommand(string Tasks)
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