using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.ViewModel
{
    public class EditViewModel
    {

        public string? Id { get; set; } 
        public string? FullName { get; set; } 

        [EmailAddress]
        public string? Email { get; set; } 


        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Parola eşleşmiyor. ")]
        public string? ConfirmPassword { get; set; }
    }
}