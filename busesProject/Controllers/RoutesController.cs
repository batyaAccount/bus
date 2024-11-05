using busesProject.Lists;
using busesProject.pages;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace busesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        public RouteList routeList { get; set; } = new RouteList();

        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<List<route>> Get()
        {
            return routeList.GetRoute();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("getById/{id}")]
        public ActionResult<route> GetById(int id)
        {

            route e = routeList.getByIdRoute(id);
            if (e == null)
                return NotFound();
            return e;

        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] route route)
        {
            bool b = routeList.Add(route);
            if (b == false)
                return NotFound(false);
            return b;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] route r)
        {
            bool b = routeList.Update(id, r);
            if (b == false)
                return NotFound(false);
            return b;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = routeList.DeleteRoute(id);
            if (b == false)
                return NotFound(false);
            return b;
        }
        [HttpGet("getByStation/{station}")]
        public ActionResult<List<route>> GetByStation(int  station)
        {
            List<route> b = routeList.GetByStation(station);
            if (b == null)
                return NotFound(false);
            return b;

        }
        [HttpGet("getByBusLine/{busLine}")]
        public ActionResult<List<route>> GetByBuseLine(int busLine)
        {
            List<route> b = routeList.GetByBusLine(busLine);
            if (b == null)
                return NotFound(false);
            return b;

        }
    }
}
