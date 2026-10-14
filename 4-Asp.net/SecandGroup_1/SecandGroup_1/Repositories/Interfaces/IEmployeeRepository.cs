using SecandGroup_1.Dtos;
using SecandGroup_1.Models;

namespace SecandGroup_1.Repositories.Interfaces
{
    public interface IEmployeeRepository :IRepository<Employee>
    {
        IEnumerable<EmployeeDtos> GetEmployeesWithDepartmentNames();
        Employee GetEmployeeWithDepartment(int id);
    }
}
