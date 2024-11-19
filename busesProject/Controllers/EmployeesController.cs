using busesProject.Lists;
using busesProject.pages;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace busesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly EmployeeList employees;
        public EmployeesController(EmployeeList emp)
        {
            employees = emp;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<List<employee>> Get()
        {
            return employees.GetEmployees();


        }

        // GET api/<EmployeeController>/5
        [HttpGet("getById/{id}")]
        public ActionResult<employee> Get(int id)
        {
            if (id < 0)
                return BadRequest();
            employee e = employees.getByIdEmployees(id);
            if (e == null)
                return NotFound();
            return e;

        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult Post([FromBody] employee employee)
        {
            bool b = employees.Add(employee);
            if (b == false)
                return BadRequest();
            return Ok(true);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] employee employee)
        {
            bool b = employees.Update(id, employee);
            if (b == false)
                return NotFound(false);
            return Ok(true);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool b = employees.DeleteEmployees(id);
            if (b == false)
                return NotFound(false);
            return Ok(true);
        }
        [HttpGet("{typeWork}")]
        public ActionResult<List<employee>> GetByDestination(string typeWork)
        {
            List<employee> b = employees.GetByTypeWork(typeWork);
            if (b == null)
                return NotFound(false);
            return b;
        }
    }
}
