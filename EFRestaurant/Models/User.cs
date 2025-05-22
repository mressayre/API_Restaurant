using System.ComponentModel.DataAnnotations;

namespace EFRestaurant.Models
{
    public abstract class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public Langue Langage { get; set; }
    }
}
