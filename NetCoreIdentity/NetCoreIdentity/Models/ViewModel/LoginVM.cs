using System.ComponentModel.DataAnnotations;

namespace NetCoreIdentity.Models.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
