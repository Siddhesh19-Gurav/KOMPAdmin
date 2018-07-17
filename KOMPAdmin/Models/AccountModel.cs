using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KOMPAdmin.Models
{
    public class AccountModel
    {
        [Required]
        [Display(Name ="User Name")]
        public string userLoginId { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
