using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyelik.Entity.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name ="Ad")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Şifre")]
        [RegularExpression(@"^[a-zA-Z]\w{4,15}$", ErrorMessage = "İlk karakter harf olmalı, karakter sayısı 5-15 karakter arası olmalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler birbiri ile uyuşmuyor!")]
        public string ConfirmPassword { get; set; }
    }
}
