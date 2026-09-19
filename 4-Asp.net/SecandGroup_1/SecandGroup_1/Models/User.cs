using System.ComponentModel.DataAnnotations;

namespace SecandGroup_1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }=string.Empty;
        [EmailAddress]
        public string? Email { get; set; }
        public string? phone { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string Password { get; set; } = string.Empty;

        public ICollection<Role>? Roles { get; set; }

    }
}
