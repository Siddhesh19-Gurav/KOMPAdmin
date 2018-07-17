using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KOMPAdmin.Models
{
    public class MenuModel
    {
        
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Header { get; set; }

        [Required]
        public string Detail { get; set; }

        [Required]
        [Display(Name ="Show In Both")]
        public string ShowInBoth { get; set; }

        public MenuModel()
        {
            Picture = new List<HttpPostedFileBase>();
        }

        [Required]
        [FileExtensions(Extensions = "png|jpg")]
        public List<HttpPostedFileBase> Picture { get; set; }

        [Display(Name ="Is Active")]
        public bool IsActive { get; set; }

        [Display(Name ="Header Description")]
        public string HeaderCus { get; set; }

        [Display(Name = "Detail Description")]
        public string DetailCus { get; set; }
    }
}