using EmployeeManagementSystem.RequestResponse;
using EmployeeManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        private readonly IEMSService _repository;
        public DesignationController(IEMSService repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("getdesignations")]
        public async Task<IActionResult> GetDesignations()
        {
            var res = await _repository.GetDesignations();
            return Ok(res);
        }

        [HttpGet]
        [Route("getdesignationbyid")]
        public async Task<IActionResult> GetDesignationById(Guid id)
        {
            var res = await _repository.GetDesignationById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("adddesignation")]
        public async Task<IActionResult> AddDesignation(DesignationResponse designation)
        {
            var res = await _repository.AddDesignation(designation);
            return Ok(res);
        }

        [HttpPut]
        [Route("updatedesignation")]
        public async Task<IActionResult> UpdateDesignation(Guid id, DesignationResponse designation)
        {
            var res = await _repository.UpdateDesignation(id, designation);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deletedesignationbyid")]

        public async Task<IActionResult> DeleteDesignationById(Guid id)
        {
            var res = await _repository.DeleteDesignationById(id);
            return Ok(res);
        }
    }
}
