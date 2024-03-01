using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class CreateApplicationCommand : ValidatableTypes, ICommand
    {
        public CreateApplicationCommand(string Name)
        {
            
            this.Name = Name;

        }
        public string Name { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}