using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turntabl.RoleService.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }


    }
}