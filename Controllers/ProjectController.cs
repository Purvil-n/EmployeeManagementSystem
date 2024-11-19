using EmployeeManagementSystem.RequestResponse;
using EmployeeManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IEMSService _repository;
        public ProjectController(IEMSService repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("getprojects")]
        public async Task<IActionResult> GetProjects()
        {
            var res = await _repository.GetProjects();
            return Ok(res);
        }

        [HttpGet]
        [Route("getprojectbyid")]
        public async Task<IActionResult> GetProjectById(Guid id)
        {
            var res = await _repository.GetProjectById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("addproject")]
        public async Task<IActionResult> AddProject(ProjectResponse project)
        {
            var res = await _repository.AddProject(project);
            return Ok(res);
        }

        [HttpPut]
        [Route("updateproject")]
        public async Task<IActionResult> UpdateProject(Guid id, ProjectResponse project)
        {
            var res = await _repository.UpdateProject(id, project);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deleteprojectbyid")]

        public async Task<IActionResult> DeleteProjectById(Guid id)
        {
            var res = await _repository.DeleteProjectById(id);
            return Ok(res);
        }
    }
}
