using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class UpdateEnvironmentCommand : ValidatableTypes, ICommand
    {
        public UpdateEnvironmentCommand(Guid id, string Name, string Link, string Links)
        {
            this.Id = id;
            this.Name = Name;
            this.Link = Link;
            this.Links = Links;

        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Links { get; set; }


        public bool IsCommandValid()
        {
            ValidateGuidNotEmpty(Id, "Id");
            
            return this.isValid;
        }
    }
}