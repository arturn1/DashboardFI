namespace Domain.Entities
{
    
    public class VersionEntity : BaseEntity 
    {
        public VersionEntity() { }
        
        public VersionEntity(string Name)
        {
            
            this.Name = Name;

        }
        
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<TasksEntity> Tasks { get; set; }

    }

}