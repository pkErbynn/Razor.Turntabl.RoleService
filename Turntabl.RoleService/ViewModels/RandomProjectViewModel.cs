using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Turntabl.RoleService.Models;

namespace Turntabl.RoleService.ViewModels
{
    public class RandomProjectViewModel
    {
        public Project Project { get; set; }
        public List<Employee> Employees { get; set; }
    }
}