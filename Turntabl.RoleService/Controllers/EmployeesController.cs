using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Turntabl.RoleService.Models;

namespace Turntabl.RoleService.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var employees = GetEmployees();
            return View(employees);
        }

        private IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "John Smith" },
                new Employee { Id = 2, Name = "Mary Williams" }
            };
        }

        public ActionResult Details(int id)
        {
            var employee = GetEmployees().SingleOrDefault(c => c.Id == id);
            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

       
        
    }
}