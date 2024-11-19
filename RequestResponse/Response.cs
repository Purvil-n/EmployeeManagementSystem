namespace EmployeeManagementSystem.RequestResponse
{
    public class Response
    {
    }
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string EmployeeCode { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid DesignationId { get; set; }
        public Guid ProjectId { get; set; }
        public bool IsActive { get; set; }
    }

    public class DepartmentResponse
    {
        public Guid Id { get; set; }
        public string DepartmentCode { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }

    public class DesignationResponse
    {
        public Guid Id { get; set; }
        public string DesignationCode { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }

    public class ProjectResponse
    {
        public Guid Id { get; set; }
        public string ProjectCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }

    public class RoleResponse
    {
        public Guid Id { get; set; }
        public string RoleCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }

    public class SalaryResponse
    {
        public Guid Id { get; set; }
        public string SalaryCode { get; set; }
        public int Amount { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
