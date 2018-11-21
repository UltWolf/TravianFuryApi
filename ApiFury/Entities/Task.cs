namespace ApiFury.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskAttack { get; set; }
        public string TaskTransport { get; set; }
        public User User { get; set; }
    }
}