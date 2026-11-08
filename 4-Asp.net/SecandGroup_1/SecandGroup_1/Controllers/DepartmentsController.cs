using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecandGroup_1.Application.Abstractions.Repositories;
using SecandGroup_1.Domain.Entities;
using SecandGroup_1.Infrastructure.Data;

namespace SecandGroup_1.Controllers
{
    [Authorize]
    public class DepartmentsController : Controller
    {
        //private readonly ApplicationDbContext _context;
      //  private readonly IDepartmentRepository _departmentsRepository;
          //private readonly IRepository<Department> _departmentsRepository;
          private readonly IUnitOfWork _unitOfWork;

        public DepartmentsController(ApplicationDbContext context, IRepository<Department> repo, IUnitOfWork unitOfWork)
        {
            //_context = context;
            //_departmentsRepository = repo;
            _unitOfWork = unitOfWork;
        }

        // GET: Departments
        public async Task<IActionResult> Index()
        {
            /*await _context.Department.ToListAsync()*/
            return View(_unitOfWork.Departments.GetAll());
        }

        // GET: Departments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
/*await _context.Department.FirstOrDefaultAsync(m => m.Id == id)*/
            var department = _unitOfWork.Departments.GetById(id.Value);
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
                _unitOfWork.Departments.Add(department);
                _unitOfWork.Save();
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
            var department = _unitOfWork.Departments.GetById(id.Value);
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
                    _unitOfWork.Departments.Update(department);
                    _unitOfWork.Save();
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
            var department = _unitOfWork.Departments.GetById(id.Value);
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
            var department = _unitOfWork.Departments.GetById(id);
            if (department != null)
            {
                _unitOfWork.Departments.Delete(department);
                _unitOfWork.Save();
                //_context.Department.Remove(department);
            }

            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
