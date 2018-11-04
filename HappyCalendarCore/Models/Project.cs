using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HappyCalendarCore.Models
{
    public class Project
    {
        public int id { get; set; }
        [Display(Name = "Category")]
        public string category { get; set; }
        [Display(Name = "Activity")]
        public string name { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal value { get; set; }
    }
}
