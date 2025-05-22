namespace EFRestaurant.Models;

public class ShiftAssignment
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;

    public int ShiftId { get; set; }
    public Shift Shift { get; set; } = null!;

    public ShiftStatus Status { get; set; }
    public DateTime? CheckInTime { get; set; }
    public DateTime? CheckOutTime { get; set; }
}
