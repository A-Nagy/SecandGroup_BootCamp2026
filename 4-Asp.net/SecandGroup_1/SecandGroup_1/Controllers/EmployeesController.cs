using Microsoft.AspNetCore.Mvc;
using SecandGroup_1.Data;
using SecandGroup_1.Models;

namespace SecandGroup_1.Controllers
{
    public class EmployeesController : Controller
    {
        #region StartCode
        //old Version Pass Data From Controller to View
        //public IActionResult Index()
        //{
        //    //Employee employee = new Employee();
        //    //employee.Id = 1;
        //    //employee.Name = "John Doe";
        //    //employee.Email = "Jone@gmail.com";
        //    //employee.Salary = 50000;
        //    //employee.Phone = "123-456-7890";
        //    //employee.Address = "123 Main St, Anytown, USA";

        //    List<Employee> employees = new List<Employee>();

        //    Employee emp1 = new Employee()
        //    {
        //        Id = 1,
        //        Name = "Ahamd",
        //        Email = "Ahmad@gamil.com",
        //        Salary = 3000,
        //        Phone = "01111",
        //        Address = "q ,St"
        //    };
        //    Employee emp2 = new Employee()
        //    {
        //        Id = 2,
        //        Name = "Ali",
        //        Email = "Ali @gmail.com",
        //        Salary = 3000,
        //        Phone = "01111",
        //        Address = "q ,St"
        //    };
        //    Employee emp3 = new Employee()
        //    {
        //        Id = 3,
        //        Name = "Mohamed",
        //        Email = "Mohamed @gmail.com",
        //        Salary = 3000,
        //        Phone = "01111",
        //        Address = "q ,St"
        //    };

        //    employees.Add(emp1);
        //    employees.Add(emp2);
        //    employees.Add(emp3);

        //    return View(employees);
        // }

        #endregion

        //Dependency Injection (DI)  the ApplicationDbContext into the EmployeesController

        private readonly ApplicationDbContext _context;
        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //New Version Handing from Databse Between Controller   and View
        [HttpGet]
        public IActionResult Index()
        {
            // Retrieve all employees from the database using Entity Framework Core
            //ToList() method is used to execute the query and return the results as a List<Employee> collection.
            // Like Select * from Employees in SQL
          List<Employee> employees=  _context.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //This attribute is used to protect against Cross-Site Request Forgery (CSRF) attacks.
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
         
            return View(emp);
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Retrieve the employee from the database based on the provided id
            Employee? emp = _context.Employees.Find(id);
            if (emp == null) 
            {
                return NotFound();
                // Return a 404 Not Found response if the employee is not found
            }
            return View(emp);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //This attribute is used to protect against Cross-Site Request Forgery (CSRF) attacks.
        public IActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(emp);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }
    }
}
