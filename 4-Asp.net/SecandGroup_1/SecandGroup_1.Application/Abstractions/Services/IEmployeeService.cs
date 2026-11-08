using SecandGroup_1.Application.Dtos;

namespace SecandGroup_1.Application.Abstractions.Services
{
    public interface IEmployeeService
    {
        IEnumerable<DepartmentDto> GetAllDepartmentsUsingDto();
        IEnumerable<EmployeeDtos> GetAllEmployeesUsingDto();
        UpdateEmployeeDto GetEmployeeByIdUseingDto(int Id);
        void AddEmployee(CreateEmployeeDto employeeDto);
        void DeleteEmployee(int Id);
        void UpdateEmployee(UpdateEmployeeDto employeeDto);
        int SaveEmployee();

    }
}
