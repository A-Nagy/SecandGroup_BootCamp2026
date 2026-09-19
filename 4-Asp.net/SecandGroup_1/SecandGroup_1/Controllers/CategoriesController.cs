using Microsoft.AspNetCore.Mvc;
using SecandGroup_1.Data;
using SecandGroup_1.Models;

namespace SecandGroup_1.Controllers
{
    public class CategoriesController : Controller
    {
        //Dependency Injection (DI)  the ApplicationDbContext into the EmployeesController

        private readonly ApplicationDbContext _context;
        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

         [HttpGet]
        public IActionResult Index()
        { 
            IEnumerable<Category> categories = _context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult getAllCategoies()
        {
            IEnumerable<Category> categories = _context.Categories.ToList();
            return Ok(categories);
        }
        //Content()  : text
        //View()   : Screen
        //NotFound() : Error Screen
        //Ok      () : Data in Json
        //BadRequest(): Error For Return Data
        //ReddirectToAction()  :  Data From Another Action

        [HttpGet]
        public IActionResult Details(int Id)
        {

            Category? categories = _context.Categories.Find(Id);
            if (categories == null)
            {
                return NotFound();
                // Return a 404 Not Found response if the employee is not found
            }
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //This attribute is used to protect against Cross-Site Request Forgery (CSRF) attacks.
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }



        [HttpGet]
        public IActionResult Edit(int Id)
        {
           
            Category? categories = _context.Categories.Find(Id);
            if (categories == null)
            {
                return NotFound();
                // Return a 404 Not Found response if the employee is not found
            }
            return View(categories);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //This attribute is used to protect against Cross-Site Request Forgery (CSRF) attacks.
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            // Retrieve the employee from the database based on the provided id
            Category? category = _context.Categories.Find(Id);
            if (category == null)
            {
                return NotFound();
                // Return a 404 Not Found response if the employee is not found
            }
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //This attribute is used to protect against Cross-Site Request Forgery (CSRF) attacks.
        public IActionResult Delete(Category category)
        {

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
