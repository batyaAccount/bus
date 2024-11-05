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
        public EmployeeList employees{ get; set; }=new EmployeeList();
       
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

           employee e = employees.getByIdEmployees(id);
            if (e == null)
                return NotFound();
            return e;
             
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] employee employee)
        {
            bool b = employees.Add(employee);
            if (b == false)
                return BadRequest();
            return b;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] employee employee)
        {
            bool b = employees.Update(id, employee);
            if (b == false)
                return NotFound(false);
            return b;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = employees.DeleteEmployees(id);
            if (b == false)
                return NotFound(false);
            return b;
        }
        [HttpGet("{typeWork}")]
        public ActionResult<List<employee>> GetByDestination(workingType typeWork)
        {
            List<employee> b =employees.GetByTypeWork(typeWork); 
            if (b == null)
                return NotFound(false);
            return b;            
        }
    }
}
