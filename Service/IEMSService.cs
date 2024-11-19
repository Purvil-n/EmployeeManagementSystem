using EmployeeManagementSystem.RequestResponse;

namespace EmployeeManagementSystem.Service
{
    public interface IEMSService
    {
        Task<List<UserResponse>> GetUsers();
        Task<List<DepartmentResponse>> GetDepartments(); //department
        Task<List<DesignationResponse>> GetDesignations(); //designation
        Task<List<ProjectResponse>> GetProjects(); //project
        Task<List<RoleResponse>> GetRoles(); //role
        Task<List<SalaryResponse>> GetSalaries(); //salary
        Task<UserResponse> GetUserById(Guid id);
        Task<DepartmentResponse> GetDepartmentById(Guid id); //department
        Task<DesignationResponse> GetDesignationById(Guid id); //designation
        Task<ProjectResponse> GetProjectById(Guid id); //project
        Task<RoleResponse> GetRoleById(Guid id); //role
        Task<SalaryResponse> GetSalaryById(Guid id); //salary
        Task<string> AddUser(UserResponse user);
        Task<string> AddDepartment(DepartmentResponse department); //department
        Task<string> AddDesignation(DesignationResponse department); //designation
        Task<string> AddProject(ProjectResponse project); //project
        Task<string> AddRole(RoleResponse role); //role
        Task<string> AddSalary(SalaryResponse salary); //salary
        Task<string> UpdateUser(Guid id, UserResponse user);
        Task<string> UpdateDepartment(Guid id, DepartmentResponse derpartment); //department
        Task<string> UpdateDesignation(Guid id, DesignationResponse designation); //designation
        Task<string> UpdateProject(Guid id, ProjectResponse project); //project
        Task<string> UpdateRole(Guid id, RoleResponse role); //role
        Task<string> UpdateSalary(Guid id, SalaryResponse salary); //salary
        Task<string> DeleteUserById(Guid id);
        Task<string> DeleteDepartmentById(Guid id); //department
        Task<string> DeleteDesignationById(Guid id); //designation
        Task<string> DeleteProjectById(Guid id); //project
        Task<string> DeleteRoleById(Guid id); //role
        Task<string> DeleteSalaryById(Guid id); //salary
    }
}
