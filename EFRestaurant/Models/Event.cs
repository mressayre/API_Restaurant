using System.ComponentModel.DataAnnotations.Schema;

namespace EFRestaurant.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public DateTime Time { get; set; }
        public string Location { get; set; } = string.Empty;
        public string DressCode { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public int ManagerId { get; set; }
        public Manager Manager { get; set; } = null!;
        public ICollection<Shift> Shifts { get; set; } = new List<Shift>();
    }
}
