using EmployeeManagementSystem.RequestResponse;
using EmployeeManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IEMSService _repository;
        public DepartmentController(IEMSService repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("getdepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            var res = await _repository.GetDepartments();
            return Ok(res);
        }

        [HttpGet]
        [Route("getdepartmentbyid")]
        public async Task<IActionResult> GetDepartmentById(Guid id)
        {
            var res = await _repository.GetDepartmentById(id);            
            return Ok(res);
        }

        [HttpPost]
        [Route("adddepartment")]
        public async Task<IActionResult> AddDepartment(DepartmentResponse department)
        {
            var res = await _repository.AddDepartment(department);            
            return Ok(res);
        }

        [HttpPut]
        [Route("updatedepartment")]
        public async Task<IActionResult> UpdateDepartment(Guid id, DepartmentResponse department)
        {
            var res = await _repository.UpdateDepartment(id, department);            
            return Ok(res);
        }

        [HttpDelete]
        [Route("deletedepartmentbyid")]

        public async Task<IActionResult> DeleteDepartmentById(Guid id)
        {
            var res = await _repository.DeleteDepartmentById(id);             
            return Ok(res);
        }
    }
}
