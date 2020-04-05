using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Turntabl.RoleService.Models;
using Turntabl.RoleService.ViewModels;

namespace Turntabl.RoleService.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;
        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            return View("EmployeeForm");
        }

        // create or update employee
        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            if(employee.Id == 0)
            {
                _context.Employees.Add(employee);
            }
            else
            {
                var employeeInDbToUpdate = _context.Employees.Single(e => e.Id == employee.Id);

                employeeInDbToUpdate.Name = employee.Name;
                employeeInDbToUpdate.Email = employee.Email;
                employeeInDbToUpdate.PhoneNumber = employee.PhoneNumber;
                employeeInDbToUpdate.Address = employee.Address;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Employees");
        }

        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);
            if(employee == null)
            {
                return HttpNotFound();
            };
            
            return View("EmployeeForm", employee);
        }

        // GET: Employees
        public ActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        // GET: Employees/Details/8
        public ActionResult Details(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return HttpNotFound();
            }

            return View(employee);
        }
    }
}