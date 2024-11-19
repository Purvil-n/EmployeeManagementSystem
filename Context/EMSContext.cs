using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Context
{
    public class EMSContext : DbContext
    {
        public EMSContext(DbContextOptions<EMSContext> options) : base(options) { }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<DepartmentEntity> Departments { get; set; }
        public DbSet<DesignationEntity> Designations { get; set; }
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<SalaryEntity> Salaries { get; set; }

    }
}
