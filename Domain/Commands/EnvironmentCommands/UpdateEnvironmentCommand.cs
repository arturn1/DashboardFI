using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class UpdateEnvironmentCommand : ValidatableTypes, ICommand
    {
        public UpdateEnvironmentCommand(Guid id, string Version, DateTime VersionDate, string Link, string Links)
        {
            this.Id = id;
            this.Version = Version;
            this.VersionDate = VersionDate;
            this.Link = Link;
            this.Links = Links;

        }

        public Guid Id { get; set; }
        public string Version { get; set; }
        public DateTime VersionDate { get; set; }
        public string Link { get; set; }
        public string Links { get; set; }


        public bool IsCommandValid()
        {
            ValidateGuidNotEmpty(Id, "Id");
            
            return this.isValid;
        }
    }
}