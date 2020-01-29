using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyPoject.Pages
{
    public partial class Login
    {
        [Required(ErrorMessage = "Please Enter Your UserID")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }
    }
}
