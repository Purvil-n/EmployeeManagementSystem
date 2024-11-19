namespace EmployeeManagementSystem.Models
{
    public class ProjectEntity
    {
        public Guid Id { get; set; }
        public string ProjectCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
