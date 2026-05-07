namespace TaskManager.Models
{
    public class RefreshToken
    {
        public Guid UserId { get; set; }
        public required string RefershToken { get; set; }
    }
}
