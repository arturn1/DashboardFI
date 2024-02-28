namespace Domain.Entities
{
    
    public class EnvironmentEntity : BaseEntity 
    {
        public EnvironmentEntity() { }
        
        public EnvironmentEntity(string Link, string Links)
        {
            
            this.Link = Link;
            this.Links = Links;

        }
        
        public List<VersionEntity> Versions { get; set; }
        public string Link { get; set; }
        public string Links { get; set; }
        public ApplicationsEntity Application { get; set; }

    }

}