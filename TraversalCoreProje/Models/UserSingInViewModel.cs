using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSingInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }
    }
}
