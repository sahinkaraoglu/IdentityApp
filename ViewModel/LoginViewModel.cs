using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IdentityApp.ViewModel
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string Email { get; set; } = null!;
        
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public bool RememberMe { get; set; } = true;
    }
}