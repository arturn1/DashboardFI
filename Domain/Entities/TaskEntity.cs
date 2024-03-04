using System.Text.Json.Serialization;

namespace Domain.Entities
{

    public class TaskEntity : BaseEntity
    {
        public TaskEntity() { }

        public TaskEntity(VersionEntity Version)
        {
            this.Version = Version;
        }

        public TaskEntity(string Name, string Description)
        {

            this.Name = Name;
            this.Description  = Description;

        }

        public string Name { get; set; }
        public string? Description { get; set; } = "";
        [JsonIgnore]
        public VersionEntity Version { get; set; }

    }

}