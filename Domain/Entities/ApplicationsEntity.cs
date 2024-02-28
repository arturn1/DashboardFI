namespace Domain.Entities
{
    
    public class ApplicationsEntity : BaseEntity 
    {
        public ApplicationsEntity() { }
        
        public ApplicationsEntity(string Name, string Environment)
        {
            
            this.Name = Name;
            this.Environment = Environment;

        }
        
        public string Name { get; set; }
        public string Environment { get; set; }

    }

}