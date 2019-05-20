using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountOwnerServer.Models;
using AccountOwnerServer.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers
{
    [Route("api/employee")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _dataRepository;
        public EmployeeController(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }
        // GET: api/Employee

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)

        {
            Employee employee = _dataRepository.Get(id);
            if (employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            else
            {
                return Ok(employee);
            }
        }
        [HttpPost]
        //  POST : api/employee
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee null");
            }
            _dataRepository.Add(employee);
            return CreatedAtRoute(
                "Get",

                new { id = employee.EmployeeID },
                employee);
        }
        //PUT : api/employee
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee is null.");

            }

            Employee employeeToUpdate = _dataRepository.Get(id);
            if (employeeToUpdate == null)
            {
                return BadRequest("The Employee record  couldn't be found ");

            }

            _dataRepository.update(employeeToUpdate, employee);
            return NoContent();

        }
        //DELETE api/employee
        [HttpDelete ("{id}")]
        public IActionResult Delete (long id)
        {

            Employee employee = _dataRepository.Get(id);
            if(employee == null)
            {
                return NotFound("The Employee record  couldn't be found");

            }
            _dataRepository.Delete(employee);
            return NoContent();
        }
    }
    }

    

