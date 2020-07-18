using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace pap_rui.Models
{
    public class RegisterModel
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Por favor insira o primeiro nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Por favor insira o segundo nome")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Por favor insira o email")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.)|((\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Por favor insira um email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Por favor insira a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Compare("password",ErrorMessage ="Por favor insira a password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}