using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using videocode.Models;

namespace videocode.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FirstName = "itsolutions";
            ViewBag.LastName = "something";
            ViewBag.Address = "Mirpur Azad Kashmir";
            return View();
        }
        public ActionResult GetEmployee()
        {
            List<Employee> employees = new List<Employee>()

            {
            new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "mark smith",
                Address = "London",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
            },
            new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "John smith",
                Address = "London",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
            },

            new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "Dunk smith",
                Address = "London",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
            },

            new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "mikelson",
                Address = "London",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
            },

            new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "Damon salvatore",
                Address = "London",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoad = true,
                Salary = 15000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now
            }
            };


            ViewBag.Employees = employees;
            return View();

        }
    }
}