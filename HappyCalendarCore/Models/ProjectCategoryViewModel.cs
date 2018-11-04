using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace HappyCalendarCore.Models
{
    public class ProjectCategoryViewModel
    {
        public List<Project> Projects;
        public SelectList Categories;
        public string ProjectCategory { get; set; }
        public string SearchString { get; set; }
    }
}
