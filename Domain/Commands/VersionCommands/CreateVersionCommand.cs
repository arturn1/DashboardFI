using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class CreateVersionCommand : ValidatableTypes, ICommand
    {
        public CreateVersionCommand(string Name, DateTime ReleaseDate)
        {
            
            this.Name = Name;
            this.ReleaseDate = ReleaseDate;

        }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}