using System.ComponentModel.DataAnnotations;

namespace IP.Models
{
    public class UserViewModel
    {
        [Display(Name = "Имя")] public string Name { get; set; }
        [Display(Name = "Пароль")] public string Password { get; set; }
    }
}