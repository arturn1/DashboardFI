using System.Text.Json.Serialization;

namespace Domain.Entities
{

    public class EnvironmentEntity : BaseEntity
    {
        public EnvironmentEntity() { }

        public EnvironmentEntity(string Name, string Link, string Links, ApplicationEntity Application)
        {

            this.Name = Name;
            this.Link = Link;
            this.Links = Links;
            this.Application = Application;

        }

        public EnvironmentEntity(ApplicationEntity Application)
        {
            this.Application = Application;
        }


        public string Name { get; set; }
        public string Link { get; set; }
        public string Links { get; set; }
        [JsonIgnore]
        public ApplicationEntity Application { get; set; }
        public List<VersionEntity> Versions { get; set; }

    }

}