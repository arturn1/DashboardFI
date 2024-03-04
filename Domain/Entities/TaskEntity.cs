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

        public TaskEntity(string Tasks)
        {

            this.Tasks = Tasks;

        }

        public string Tasks { get; set; }
        [JsonIgnore]
        public VersionEntity Version { get; set; }

    }

}