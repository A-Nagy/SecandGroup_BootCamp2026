using Microsoft.AspNetCore.Mvc;
using SecandGroup_1.Models;

namespace SecandGroup_1.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            //Employee employee = new Employee();
            //employee.Id = 1;
            //employee.Name = "John Doe";
            //employee.Email = "Jone@gmail.com";
            //employee.Salary = 50000;
            //employee.Phone = "123-456-7890";
            //employee.Address = "123 Main St, Anytown, USA";

            List<Employee> employees = new List<Employee>();

            Employee emp1 = new Employee() 
            {
                Id = 1, 
                Name="Ahamd",
                Email="Ahmad@gamil.com",
                Salary=3000,
                Phone="01111", 
                Address="q ,St"
            };
            Employee emp2 = new Employee()
            {
                Id = 2,
                Name = "Ali",
                Email = "Ali @gmail.com",
                Salary = 3000,
                Phone = "01111",
                Address = "q ,St"
            };
            Employee emp3 = new Employee()
            {
                Id = 3,
                Name = "Mohamed",
                Email = "Mohamed @gmail.com",
                Salary = 3000,
                Phone = "01111",
                Address = "q ,St"
            };

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            return View(employees);
        }
    }
}
