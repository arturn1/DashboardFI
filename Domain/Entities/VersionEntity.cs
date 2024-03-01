namespace Domain.Entities
{
    
    public class VersionEntity : BaseEntity 
    {
        public VersionEntity() { }
        
        public VersionEntity(string Name, DateTime ReleaseDate)
        {
            
            this.Name = Name;
            this.ReleaseDate = ReleaseDate;

        }
        
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public EnvironmentEntity Environment { get; set; }

    }

}