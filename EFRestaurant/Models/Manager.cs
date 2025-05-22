using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFRestaurant.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
