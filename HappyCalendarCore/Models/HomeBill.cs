using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HappyCalendarCore.Models
{
    public class HomeBill
    {
        public int ID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BillDate { get; set; }
        public string Description { get; set; }
        public string Who { get; set; }
        public double BillValue { get; set; }

    }
}
