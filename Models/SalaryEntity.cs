namespace EmployeeManagementSystem.Models
{
    public class SalaryEntity
    {
        public Guid Id { get; set; }
        public string SalaryCode { get; set; }
        public int Amount { get; set; }
        public Guid EmployeeId { get; set; }

    }
}
