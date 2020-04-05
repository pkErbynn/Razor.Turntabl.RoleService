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
        ApplicationDbContext _context;
        public ProjectsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Projects
        public ActionResult Index()
        {
            var projects = _context.Projects.ToList();

            return View(projects);
        }

        // GET: Projects/Details/2
        public ActionResult Details(int id)
        {
            var project = _context.Projects.SingleOrDefault(p => p.Id == id);
            if (project == null)
            {
                return HttpNotFound();
            }

            return View(project);
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