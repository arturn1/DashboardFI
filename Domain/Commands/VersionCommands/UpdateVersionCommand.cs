using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class UpdateVersionCommand : ValidatableTypes, ICommand
    {
        public UpdateVersionCommand(Guid id, string Name, DateTime ReleaseDate)
        {
            this.Id = id;
            this.Name = Name;
            this.ReleaseDate = ReleaseDate;

        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }


        public bool IsCommandValid()
        {
            ValidateGuidNotEmpty(Id, "Id");
            
            return this.isValid;
        }
    }
}