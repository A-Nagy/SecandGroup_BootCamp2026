using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecandGroup_1.Data;
using SecandGroup_1.Models;
using SecandGroup_1.Repositories.Interfaces;

namespace SecandGroup_1.Controllers
{
    [Authorize]
    public class DepartmentsController : Controller
    {
        //private readonly ApplicationDbContext _context;
      //  private readonly IDepartmentRepository _departmentsRepository;
          private readonly IRepository<Department> _departmentsRepository;

        public DepartmentsController(ApplicationDbContext context, IRepository<Department> repo)
        {
            //_context = context;
            _departmentsRepository = repo;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            /*await _context.Department.ToListAsync()*/
            return View(_departmentsRepository.GetAll());
        }

        // GET: Departments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
/*await _context.Department.FirstOrDefaultAsync(m => m.Id == id)*/
            var department = _departmentsRepository.GetById(id.Value);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // GET: Departments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentsRepository.Add(department);
                //_context.Add(department);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // GET: Departments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //await _context.Department.FindAsync(id);
            var department = _departmentsRepository.GetById(id.Value);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Department department)
        {
            if (id != department.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _departmentsRepository.Update(department);
                    //_context.Update(department);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // GET: Departments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            /*await _context.Department.FirstOrDefaultAsync(m => m.Id == id);*/
            var department = _departmentsRepository.GetById(id.Value);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var department = _departmentsRepository.GetById(id);
            if (department != null)
            {
                _departmentsRepository.Delete(department);
                //_context.Department.Remove(department);
            }

            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
