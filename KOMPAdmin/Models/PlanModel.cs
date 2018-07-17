using Foolproof;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KOMPAdmin.Models
{
    public class PlanModel
    {
        public PlanModel()
        {
            CreatedOn = DateTime.Now;
        } 

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Title")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Plan Days")]
        public int DaysInPlan { get; set; }

        [Required]
        [Display(Name ="Valid For (Days)")]
        [GreaterThan("DaysInPlan",ErrorMessage ="Valid days should be grater than plan days.")]
        public int ValidUpTo { get; set; }

        public DateTime CreatedOn { get; set; }

        [Display(Name ="Active")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Delivery Charges (Rs.)")]
        public int DeliveryCharges { get; set; }

        [Required]
        [Display(Name = "Discount (Rs.)")]
        public decimal Discount { get; set; }

        [Required]
        [Display(Name = "Night Delivery Charges (Rs.)")]
        public int NightDeliveryCharges { get; set; }

    }
}