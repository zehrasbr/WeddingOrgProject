using System.ComponentModel.DataAnnotations;

namespace WeddingOrganization.PresantationLayer.Models
{
    public class UserRegisterViewModel
    {
        //[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen email adresinizi giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen parolanızı giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen parolanızı tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
    }
}
