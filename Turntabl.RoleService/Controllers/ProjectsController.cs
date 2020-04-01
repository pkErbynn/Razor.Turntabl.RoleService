using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Turntabl.RoleService.Models;
using Turntabl.RoleService.ViewModels;

namespace Turntabl.RoleService.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            var projects = GetProjects();

            return View(projects);
        }

        private IEnumerable<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project { Id = 1, Name = "Hadoop" },
                new Project { Id = 2, Name = "Holliday Me" }
            };
        }

        // GET: Projects/Random
        public ActionResult Random()
        {
            var project = new Project() { Name = "TPMS" };
            var employees = new List<Employee> 
            {
                new Employee{Name="john erbynn" },
                new Employee{Name="pkay erbynn"}
            };
            var viewModel = new RandomProjectViewModel
            {
                Project = project,
                Employees = employees
            };
            //return Content("heoo");
            return View(viewModel);
        }

    }
}