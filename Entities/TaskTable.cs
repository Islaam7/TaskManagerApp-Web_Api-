namespace TaskManager.Entities
{
    public class TaskTable
    {
        public Guid Id { get; set; }
        public string TaskTitle{ get; set; } = string.Empty;
        public string TaskDescription{ get; set; } = string.Empty;
        public string TaskCategory{ get; set; } = string.Empty;
        public string Status{ get; set; } = "Pending";   
        public Guid UserId{ get; set; }
    }
}
