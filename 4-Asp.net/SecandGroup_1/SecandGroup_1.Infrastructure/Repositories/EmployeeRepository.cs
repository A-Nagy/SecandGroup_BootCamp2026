
using Microsoft.EntityFrameworkCore;
using SecandGroup_1.Application.Abstractions.Repositories;
using SecandGroup_1.Application.Dtos;
using SecandGroup_1.Domain.Entities;
using SecandGroup_1.Infrastructure.Data;

namespace SecandGroup_1.Infrastructure.Repositories
{
    public class EmployeeRepository :Repository<Employee> ,IEmployeeRepository
    {


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
