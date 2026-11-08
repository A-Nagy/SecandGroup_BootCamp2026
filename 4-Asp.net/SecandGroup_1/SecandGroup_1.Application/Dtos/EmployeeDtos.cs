namespace SecandGroup_1.Application.Dtos
{
    public class EmployeeDtos
    { 
        public int Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Email { get; set; } = "";
        public string? DepartmentName { get; set; }
    }
    public class CreateEmployeeDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = "";
        public int? DepartmentId { get; set; }

    }
    public class UpdateEmployeeDto :CreateEmployeeDto
    {
        public int Id { get; set; }
    }
}
