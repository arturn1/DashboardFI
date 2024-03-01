namespace Domain.Entities
{
    
    public class TaskEntity : BaseEntity 
    {
        public TaskEntity() { }
        
        public TaskEntity(string Tasks)
        {
            
            this.Tasks = Tasks;

        }
        
        public string Tasks { get; set; }

        public VersionEntity Version { get; set; }

    }

}