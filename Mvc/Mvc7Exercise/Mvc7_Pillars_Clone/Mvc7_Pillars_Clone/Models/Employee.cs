﻿using System.ComponentModel.DataAnnotations;

namespace Mvc7_Pillars_Clone.Models
{
    public class Employee
    {
        [Display(Name = "員工編號")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Display(Name = "名字")]
        [Required]
        [StringLength(12)]
        public string Name { get; set; }

        [Display(Name = "連絡電話")]
        public string Phone { get; set; }

        [Display(Name = "電子郵件")]
        public string Email { get; set; }
    }
}
