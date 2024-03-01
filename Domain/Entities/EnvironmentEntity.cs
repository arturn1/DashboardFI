namespace Domain.Entities
{
    
    public class EnvironmentEntity : BaseEntity 
    {
        public EnvironmentEntity() { }
        
        public EnvironmentEntity(string Name, string Link, string Links)
        {
            
            this.Name = Name;
            this.Link = Link;
            this.Links = Links;

        }
        
        public string Name { get; set; }
        public string Link { get; set; }
        public string Links { get; set; }
        public ApplicationEntity Application { get; set; }

    }

}