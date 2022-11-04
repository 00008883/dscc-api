using API_DSCC_8883.Model;
using API_DSCC_8883.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;


namespace API_DSCC_8883.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: api/Employee
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeRepository.GetEmployees();
            return new OkObjectResult(employees);
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "GetEmployee")]
        public IActionResult Get(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            return new OkObjectResult(employee);
            //return "value";
        }


        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            using (var scope = new TransactionScope())
            {
                _employeeRepository.InsertEmployee(employee);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = employee.EmployeeID }, employee);
            }
        }


        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            if (employee != null)
            {
                using (var scope = new TransactionScope())
                {
                    _employeeRepository.UpdateEmployee(employee);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return new OkResult();
        }
    }
}
