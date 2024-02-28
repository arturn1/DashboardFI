namespace Domain.Entities
{
    
    public class ApplicationsEntity : BaseEntity 
    {
        public ApplicationsEntity() { }
        
        public ApplicationsEntity(string Name)
        {
            
            this.Name = Name;

        }
        
        public string Name { get; set; }
        public List<EnvironmentEntity> Environments { get; set; }

    }

}