using EmployeeManagementSystem.RequestResponse;
using EmployeeManagementSystem.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly IEMSService _repository;
        public SalaryController(IEMSService repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("getsalaries")]
        public async Task<IActionResult> GetSalaries()
        {
            var res = await _repository.GetSalaries();
            return Ok(res);
        }

        [HttpGet]
        [Route("getsalarybyid")]
        public async Task<IActionResult> GetSalaryById(Guid id)
        {
            var res = await _repository.GetSalaryById(id);
            return Ok(res);
        }

        [HttpPost]
        [Route("addsalary")]
        public async Task<IActionResult> AddSalary(SalaryResponse salary)
        {
            var res = await _repository.AddSalary(salary);
            return Ok(res);
        }

        [HttpPut]
        [Route("updatesalary")]
        public async Task<IActionResult> UpdateSalary(Guid id, SalaryResponse salary)
        {
            var res = await _repository.UpdateSalary(id, salary);
            return Ok(res);
        }

        [HttpDelete]
        [Route("deletesalarybyid")]

        public async Task<IActionResult> DeleteSalaryById(Guid id)
        {
            var res = await _repository.DeleteSalaryById(id);
            return Ok(res);
        }
    }
}
