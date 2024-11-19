using EmployeeManagementSystem.Context;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.RequestResponse;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EmployeeManagementSystem.Service
{
    public class EMSService : IEMSService
    {
        private readonly EMSContext _context;
        public EMSService(EMSContext context)
        {
            _context = context;
        }

        //add user
        public async Task<string> AddUser(UserResponse user)
        {
            UserEntity obj = new UserEntity()
            {
                Id = Guid.NewGuid(),
                EmployeeCode = user.EmployeeCode,
                Name = user.Name,
                Mobile = user.Mobile,
                Email = user.Email,
                Password = user.Password,
                RoleId = user.RoleId,
                DepartmentId = user.DepartmentId,
                DesignationId = user.DesignationId,
                ProjectId = user.ProjectId,
                IsActive = user.IsActive,
            };
            _context.Users.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }

        //add department
        public async Task<string> AddDepartment(DepartmentResponse department)
        {
            DepartmentEntity obj = new DepartmentEntity()
            {
                Id = Guid.NewGuid(),
                DepartmentCode = department.DepartmentCode,
                Name = department.Name,
                IsActive = department.IsActive,
            };
            _context.Departments.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }

        //add designation
        public async Task<string> AddDesignation(DesignationResponse designation)
        {
            DesignationEntity obj = new DesignationEntity()
            {
                Id = Guid.NewGuid(),
                DesignationCode = designation.DesignationCode,
                Name = designation.Name,
                IsActive = designation.IsActive,
            };
            _context.Designations.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }

        //add project
        public async Task<string> AddProject(ProjectResponse project)
        {
            ProjectEntity obj = new ProjectEntity()
            {
                Id = Guid.NewGuid(),
                ProjectCode = project.ProjectCode,
                Name = project.Name,
                Description = project.Description,
                IsActive = project.IsActive,
            };
            _context.Projects.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }

        //add role
        public async Task<string> AddRole(RoleResponse role)
        {
            RoleEntity obj = new RoleEntity()
            {
                Id = Guid.NewGuid(),
                RoleCode = role.RoleCode,
                Name = role.Name,
                Description = role.Description,
                IsActive = role.IsActive,
            };
            _context.Roles.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }


        //add salary
        public async Task<string> AddSalary(SalaryResponse salary)
        {
            SalaryEntity obj = new SalaryEntity()
            {
                Id = Guid.NewGuid(),
                SalaryCode = salary.SalaryCode,
                Amount = salary.Amount,
                EmployeeId = salary.EmployeeId,
            };
            _context.Salaries.Add(obj);
            await _context.SaveChangesAsync();
            return "Added";
        }
        //get all user
        public async Task<List<UserResponse>> GetUsers()
        {
            var res = await _context.Users.Select(item => new UserResponse
            {
                Id = item.Id,
                EmployeeCode = item.EmployeeCode,
                Name = item.Name,
                Mobile = item.Mobile,
                Email = item.Email,
                Password = item.Password,
                RoleId = item.RoleId,
                DepartmentId = item.DepartmentId,
                DesignationId = item.DesignationId,
                ProjectId = item.ProjectId,
                IsActive = item.IsActive,
            }).ToListAsync();
            return res;
        }

        //get all department
        public async Task<List<DepartmentResponse>> GetDepartments()
        {
            var res = await _context.Departments.Select(item => new DepartmentResponse
            {
                Id = item.Id,
                DepartmentCode = item.DepartmentCode,
                Name = item.Name,
                IsActive = item.IsActive,
            }).ToListAsync();
            return res;
        }

        //get all designation
        public async Task<List<DesignationResponse>> GetDesignations()
        {
            var res = await _context.Designations.Select(item => new DesignationResponse
            {
                Id = item.Id,
                DesignationCode = item.DesignationCode,
                Name = item.Name,
                IsActive = item.IsActive,
            }).ToListAsync();
            return res;
        }

        //get all project
        public async Task<List<ProjectResponse>> GetProjects()
        {
            var res = await _context.Projects.Select(item => new ProjectResponse
            {
                Id = item.Id,
                ProjectCode = item.ProjectCode,
                Name = item.Name,
                Description = item.Description,
                IsActive = item.IsActive,
            }).ToListAsync();
            return res;
        }

        //get all role
        public async Task<List<RoleResponse>> GetRoles()
        {
            var res = await _context.Roles.Select(item => new RoleResponse
            {
                Id = item.Id,
                RoleCode = item.RoleCode,
                Name = item.Name,
                Description = item.Description,
                IsActive = item.IsActive,
            }).ToListAsync();
            return res;
        }

        //get all Salary
        public async Task<List<SalaryResponse>> GetSalaries()
        {
            var res = await _context.Salaries.Select(item => new SalaryResponse
            {
                Id = item.Id,
                SalaryCode = item.SalaryCode,
                Amount = item.Amount,
                EmployeeId = item.EmployeeId,
            }).ToListAsync();
            return res;
        }
        //get single user
        public async Task<UserResponse> GetUserById(Guid id)
        {
            var res = await _context.Users.Where(item => item.Id == id).Select(item => new UserResponse
            {
                Id = item.Id,
                EmployeeCode = item.EmployeeCode,
                Name = item.Name,
                Mobile = item.Mobile,
                Email = item.Email,
                Password = item.Password,
                RoleId = item.RoleId,
                DepartmentId = item.DepartmentId,
                DesignationId = item.DesignationId,
                ProjectId = item.ProjectId,
                IsActive = item.IsActive,
            }).FirstOrDefaultAsync();
            return res;
        }

        //get single departmnet
        public async Task<DepartmentResponse> GetDepartmentById(Guid id)
        {
            var res = await _context.Departments.Where(item => item.Id == id).Select(item => new DepartmentResponse
            {
                Id = item.Id,
                DepartmentCode = item.DepartmentCode,
                Name = item.Name,
                IsActive = item.IsActive,
            }).FirstOrDefaultAsync();
            return res;
        }

        //get single designation
        public async Task<DesignationResponse> GetDesignationById(Guid id)
        {
            var res = await _context.Designations.Where(item => item.Id == id).Select(item => new DesignationResponse
            {
                Id = item.Id,
                DesignationCode = item.DesignationCode,
                Name = item.Name,
                IsActive = item.IsActive,
            }).FirstOrDefaultAsync();
            return res;
        }

        //get single project
        public async Task<ProjectResponse> GetProjectById(Guid id)
        {
            var res = await _context.Projects.Where(item => item.Id == id).Select(item => new ProjectResponse
            {
                Id = item.Id,
                ProjectCode = item.ProjectCode,
                Name = item.Name,
                Description = item.Description,
                IsActive = item.IsActive,
            }).FirstOrDefaultAsync();
            return res;
        }

        //get single role
        public async Task<RoleResponse> GetRoleById(Guid id)
        {
            var res = await _context.Roles.Where(item => item.Id == id).Select(item => new RoleResponse
            {
                Id = item.Id,
                RoleCode = item.RoleCode,
                Name = item.Name,
                Description = item.Description,
                IsActive = item.IsActive,
            }).FirstOrDefaultAsync();
            return res;
        }

        //get single salary
        public async Task<SalaryResponse> GetSalaryById(Guid id)
        {
            var res = await _context.Salaries.Where(item => item.Id == id).Select(item => new SalaryResponse
            {
                Id = item.Id,
                SalaryCode = item.SalaryCode,
                Amount = item.Amount,
                EmployeeId = item.EmployeeId,
            }).FirstOrDefaultAsync();
            return res;
        }
        //delete user
        public async Task<string> DeleteUserById(Guid id)
        {
            var res = await _context.Users.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Users.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }

        //delete department
        public async Task<string> DeleteDepartmentById(Guid id)
        {
            var res = await _context.Departments.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Departments.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }

        //delete designation
        public async Task<string> DeleteDesignationById(Guid id)
        {
            var res = await _context.Designations.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Designations.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }

        //delete project
        public async Task<string> DeleteProjectById(Guid id)
        {
            var res = await _context.Projects.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Projects.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }

        //delete role
        public async Task<string> DeleteRoleById(Guid id)
        {
            var res = await _context.Roles.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Roles.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }

        //delete salary
        public async Task<string> DeleteSalaryById(Guid id)
        {
            var res = await _context.Salaries.Where(item => item.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                _context.Salaries.Remove(res);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "No Data!";
        }
        //update user
        public async Task<string> UpdateUser(Guid id, UserResponse user)
        {
            var res = await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.EmployeeCode = user.EmployeeCode;
                res.Name = user.Name;
                res.Mobile = user.Mobile;
                res.Email = user.Email;
                res.Password = user.Password;
                res.RoleId = user.RoleId;
                res.DepartmentId = user.DepartmentId;
                res.DesignationId = user.DesignationId;
                res.ProjectId = user.ProjectId;
                res.IsActive = user.IsActive;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }

        //update department
        public async Task<string> UpdateDepartment(Guid id, DepartmentResponse department)
        {
            var res = await _context.Departments.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.DepartmentCode = department.DepartmentCode;
                res.Name = department.Name;
                res.IsActive = department.IsActive;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }

        //update designation
        public async Task<string> UpdateDesignation(Guid id, DesignationResponse designation)
        {
            var res = await _context.Designations.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.DesignationCode = designation.DesignationCode;
                res.Name = designation.Name;
                res.IsActive = designation.IsActive;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }

        //update project
        public async Task<string> UpdateProject(Guid id, ProjectResponse project)
        {
            var res = await _context.Projects.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.ProjectCode = project.ProjectCode;
                res.Name = project.Name;
                res.Description = project.Description;
                res.IsActive = project.IsActive;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }

        //update role
        public async Task<string> UpdateRole(Guid id, RoleResponse role)
        {
            var res = await _context.Roles.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.RoleCode = role.RoleCode;
                res.Name = role.Name;
                res.Description = role.Description;
                res.IsActive = role.IsActive;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }

        //update salary
        public async Task<string> UpdateSalary(Guid id, SalaryResponse salary)
        {
            var res = await _context.Salaries.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (res != null)
            {
                res.SalaryCode = salary.SalaryCode;
                res.Amount = salary.Amount;
                res.EmployeeId = salary.EmployeeId;

                //_context.Users.AddOrUpdate(res);
                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "Data not found!";
        }
    }
}
