using System.Text.Json.Serialization;

namespace Domain.Entities
{

    public class VersionEntity : BaseEntity
    {
        public VersionEntity() { }

        public VersionEntity(EnvironmentEntity environment)
        {
            this.Environment = environment;
        }

        public VersionEntity(string Name, DateTime ReleaseDate)
        {

            this.Name = Name;
            this.ReleaseDate = ReleaseDate;

        }

        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        [JsonIgnore]
        public EnvironmentEntity Environment { get; set; }
        public List<TaskEntity> Tasks { get; set; }

    }

}