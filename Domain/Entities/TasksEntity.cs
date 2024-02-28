namespace Domain.Entities
{
    
    public class TasksEntity : BaseEntity 
    {
        public TasksEntity() { }
        
        public TasksEntity(string Tasks)
        {
            
            this.Tasks = Tasks;

        }
        
        public string Tasks { get; set; }

    }

}