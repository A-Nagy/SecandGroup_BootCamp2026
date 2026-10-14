using Microsoft.EntityFrameworkCore;
using SecandGroup_1.Data;
using SecandGroup_1.Dtos;
using SecandGroup_1.Models;
using SecandGroup_1.Repositories.Interfaces;

namespace SecandGroup_1.Repositories.Implementaion
{
    public class EmployeeRepository :Repository<Employee> ,IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context) : base(context) { }
        public IEnumerable<EmployeeDtos> GetEmployeesWithDepartmentNames()
        {
        return  _context.Employees.Select(e => new EmployeeDtos
                {
                    Id = e.Id,
                    Name = e.Name,
                    Email = e.Email,
                    DepartmentName = e.Department != null ? e.Department.Name : null
                }).ToList();
        }

        public Employee GetEmployeeWithDepartment(int id)
        {
         return   _context.Employees.Include(e => e.Department).FirstOrDefault(e => e.Id == id);
        }
    }
}
