namespace Domain.Entities
{
    
    public class ApplicationEntity : BaseEntity 
    {
        public ApplicationEntity() { }
        
        public ApplicationEntity(string Name)
        {
            
            this.Name = Name;

        }
        
        public string Name { get; set; }

    }

}