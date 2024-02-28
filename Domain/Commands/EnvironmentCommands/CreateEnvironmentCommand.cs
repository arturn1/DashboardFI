using Domain.Commands.Contracts;
using Domain.Validation;

namespace Domain.Commands 
{

    public class CreateEnvironmentCommand : ValidatableTypes, ICommand
    {
        public CreateEnvironmentCommand(string Version, DateTime VersionDate, string Link, string Links)
        {
            
            this.Version = Version;
            this.VersionDate = VersionDate;
            this.Link = Link;
            this.Links = Links;

        }
        public string Version { get; set; }
        public DateTime VersionDate { get; set; }
        public string Link { get; set; }
        public string Links { get; set; }


        public bool IsCommandValid()
        {
            return this.isValid;
        }
    }
}