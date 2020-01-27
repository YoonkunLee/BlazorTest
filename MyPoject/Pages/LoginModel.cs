using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyPoject.Pages
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please Enter Your UserID")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string UserPassword { get; set; }
    }
}
