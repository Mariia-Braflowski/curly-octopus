using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Models
{
    public class RegisterViewModel
    {
        [Required]
        //[Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        //[Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password doesn`t match.")]
        [DataType(DataType.Password)]
        //[Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
