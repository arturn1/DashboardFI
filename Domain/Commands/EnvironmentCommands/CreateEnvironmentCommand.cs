using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class CreateEnvironmentCommand : ValidatableTypes, ICommand
    {
        public CreateEnvironmentCommand(string Name, string Link, string Links)
        {
            
            this.Name = Name;
            this.Link = Link;
            this.Links = Links;

        }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Links { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}