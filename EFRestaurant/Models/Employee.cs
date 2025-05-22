namespace EFRestaurant.Models
{
    public class Employee : User
    {
        public decimal Salary { get; set; }
        public int Note { get; set; }
        public ICollection<ShiftAssignment> ShiftAssignments { get; set; } = new List<ShiftAssignment>();
        public ICollection<Manager> Managers { get; set; } = new List<Manager>();
    }
}
