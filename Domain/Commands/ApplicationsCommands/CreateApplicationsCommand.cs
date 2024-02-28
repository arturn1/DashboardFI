using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class CreateApplicationsCommand : ValidatableTypes, ICommand
    {
        public CreateApplicationsCommand(string Name, string Environment)
        {
            
            this.Name = Name;
            this.Environment = Environment;

        }
        public string Name { get; set; }
        public string Environment { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}