namespace EFRestaurant.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Role { get; set; } = string.Empty;

        public int EventId { get; set; }
        public Event Event { get; set; } = null!;

        public ICollection<ShiftAssignment> Assignments { get; set; } = null!;
    }
}
