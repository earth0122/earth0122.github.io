using Microsoft.AspNetCore.Mvc;

namespace Mvc7_Pillars.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeList()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 10001, Name = "David", Phone = "0933154228", Email ="david@gmail.com" },
                new Employee { Id = 10002, Name = "Mary", Phone = "0925157886", Email ="mary@gmail.com" },
                new Employee { Id = 10003, Name = "John", Phone = "0921335884", Email ="john@gmail.com" },
                new Employee { Id = 10004, Name = "Cindy", Phone = "0971628322", Email ="cindy@gmail.com" },
                new Employee { Id = 10005, Name = "Rose", Phone = "0933154228",  Email ="rose@gmail.com" }
            };

            return View(employees);
        }
    }
}
