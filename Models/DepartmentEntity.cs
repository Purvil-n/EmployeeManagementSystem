namespace EmployeeManagementSystem.Models
{
    public class DepartmentEntity
    {
        public Guid Id { get; set; }
        public string DepartmentCode { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}
