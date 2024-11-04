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
            List<employee> e= employees.GetEmployees();
            if(e == null)   
                return NotFound();
            return Ok(e);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("getById/{id}")]
        public ActionResult<employee> Get(int id)
        {

           employee e = employees.getById(id);
            if (e == null)
                return NotFound();
            return Ok(e);
             
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] employee employee)
        {
            bool b = employees.post(employee);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] employee employee)
        {
            bool b = employees.put(id, employee);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = employees.delete(id);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }
        [HttpGet("{typeWork}")]
        public ActionResult<List<employee>> GetByDestination(workingType typeWork)
        {
            List<employee> b =employees.GetByTypeWork(typeWork); 
            if (b == null)
                return NotFound(false);
            return Ok(b);
             
        }
    }
}
