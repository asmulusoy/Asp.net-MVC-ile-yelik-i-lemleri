using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyelik.Entity.ViewModels
{
    public class ProfileViewModel
    {
        [Required]
        [Display(Name = "Ad")]
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

        
        [Display(Name = "Eski Şifre")]
        [RegularExpression(@"^[a-zA-Z]\w{4,15}$", ErrorMessage = "İlk karakter harf olmalı, karakter sayısı 5-15 karakter arası olmalıdır.")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        
        [Display(Name = "Yeni Şifre")]
        [RegularExpression(@"^[a-zA-Z]\w{4,15}$", ErrorMessage = "İlk karakter harf olmalı, karakter sayısı 5-15 karakter arası olmalıdır.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        
        [Display(Name = "Yeni Şifre Tekrar")]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Şifreler Uyuşmuyor.")]
        public string ConfirmNewPassword { get; set; }
    }
}
