namespace EmployeeManagementSystem.Models
{
    public class DesignationEntity
    {
        public Guid Id { get; set; }
        public string DesignationCode { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}
