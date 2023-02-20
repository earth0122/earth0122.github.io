using Microsoft.AspNetCore.Mvc;
using Mvc7_Pillars_Clone.Models;

namespace Mvc7_Pillars_Clone.Controllers
{
    public class EmployeesController : Controller
    {
       private readonly List<Employee> _employees;
        public EmployeesController()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 10001, Name = "David", Phone = "0933154228", Email ="david@gmail.com" },
                new Employee { Id = 10002, Name = "Mary", Phone = "0925157886", Email ="mary@gmail.com" },
                new Employee { Id = 10003, Name = "John", Phone = "0921335884", Email ="john@gmail.com" },
                new Employee { Id = 10004, Name = "Cindy", Phone = "0971628322", Email ="cindy@gmail.com" },
                new Employee { Id = 10005, Name = "Rose", Phone = "0933154228",  Email ="rose@gmail.com" }
            };
            _employees= employees;           
           
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeList() 
        {
            return View(_employees);
        }
        public IActionResult FindEmployee(int id) 
        {
            Employee emp = new Employee
            {
                Id = id,
                Name = "David",
                Email = "david@gmail.com",
                Phone = "0925-155222"
            };
            return View(emp);
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp) 
        {
            return View();
        }
    }
}
