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
        [Display(Name = "Curso")]
        public string name { get; set; }
        [Display(Name = "Descrição")]
        public string description { get; set; }
        [Display(Name = "Valor")]
        [Column(TypeName = "decimal(18, 2)")]
        public double value { get; set; }
    }
}
