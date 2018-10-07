using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HappyCalendarCore.Models;

namespace HappyCalendarCore.Models
{
    public class HappyCalendarCoreContext : DbContext
    {
        public HappyCalendarCoreContext (DbContextOptions<HappyCalendarCoreContext> options)
            : base(options)
        {
        }

        public DbSet<HappyCalendarCore.Models.Category> Category { get; set; }

        public DbSet<HappyCalendarCore.Models.HomeBill> HomeBill { get; set; }

        public DbSet<HappyCalendarCore.Models.Project> Project { get; set; }
    }
}
