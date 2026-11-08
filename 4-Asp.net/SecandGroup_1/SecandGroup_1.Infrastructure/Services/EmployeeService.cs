using SecandGroup_1.Application.Abstractions.Repositories;
using SecandGroup_1.Application.Abstractions.Services;
using SecandGroup_1.Application.Dtos;
using SecandGroup_1.Domain.Entities;

namespace SecandGroup_1.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork;
        }

        public void AddEmployee(CreateEmployeeDto employeeDto)
        {
            var employee = new Employee 
            {
                Name = employeeDto.Name,
                Email = employeeDto.Email,
                DepartmentId = employeeDto.DepartmentId
            };
            _unitOfWork.Employees.Add(employee);
        
 
        }
        public void UpdateEmployee(UpdateEmployeeDto employeeDto)
        {
            var employee = _unitOfWork.Employees.GetById(employeeDto.Id);
            if (employee == null) 
            {
                throw new KeyNotFoundException("Employee not Found");
            }
            employee.Name         = employeeDto.Name;
            employee.Email        = employeeDto.Email;
            employee.DepartmentId = employeeDto.DepartmentId;
        
            _unitOfWork.Employees.Update(employee);
  

             }
        public void DeleteEmployee(int Id)
        {
            var employee = _unitOfWork.Employees.GetById(Id);
            _unitOfWork.Employees.Delete(employee);
        
        }

        public IEnumerable<DepartmentDto> GetAllDepartmentsUsingDto()
        {
            var departments = _unitOfWork.Departments.GetAll();
            return  departments.Select(x => new DepartmentDto 
            {
                Id = x.Id,
                Name = x.Name,
            } );
        
        }

        public IEnumerable<EmployeeDtos> GetAllEmployeesUsingDto()
        {
            var employees = _unitOfWork.Employees.GetEmployeesWithDepartmentNames();
            return employees.Select(e => new EmployeeDtos 
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email,
                DepartmentName = e.DepartmentName,
            });

        }

        public UpdateEmployeeDto GetEmployeeByIdUseingDto(int Id)
        {
            var employee = _unitOfWork.Employees.GetById(Id);
            return new UpdateEmployeeDto {
            Id           = employee.Id,
            Name         = employee.Name,
            Email        = employee.Email,
            DepartmentId =  employee.DepartmentId
            };
        
        }

        public int SaveEmployee()
        {
          return _unitOfWork.Save();
        }
    }
}
