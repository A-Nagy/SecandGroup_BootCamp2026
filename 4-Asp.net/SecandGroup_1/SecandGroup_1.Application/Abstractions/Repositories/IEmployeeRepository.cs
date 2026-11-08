using SecandGroup_1.Application.Dtos;
using SecandGroup_1.Domain.Entities;

namespace SecandGroup_1.Application.Abstractions.Repositories
{
    public interface IEmployeeRepository :IRepository<Employee>
    {
        IEnumerable<EmployeeDtos> GetEmployeesWithDepartmentNames();
        Employee GetEmployeeWithDepartment(int id);
    }
}
