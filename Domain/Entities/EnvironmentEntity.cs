namespace Domain.Entities
{
    
    public class EnvironmentEntity : BaseEntity 
    {
        public EnvironmentEntity() { }
        
        public EnvironmentEntity(string Version, DateTime VersionDate, string Link, string Links)
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

    }

}