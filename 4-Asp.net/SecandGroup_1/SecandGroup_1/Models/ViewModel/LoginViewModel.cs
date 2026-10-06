using System.ComponentModel.DataAnnotations;

namespace SecandGroup_1.Models.ViewModel
{
    public class LoginViewModel
    {


        [Required]
        [StringLength(50)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
