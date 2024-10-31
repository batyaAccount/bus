﻿using busesProject.Lists;
using busesProject.pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace busesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : ControllerBase
    {
        public BusesList buses { get; set; } = new BusesList();
        // GET: api/<BusesController>
        [HttpGet]
        public ActionResult<List<bus>> Get()
        {
            List<bus> b = buses.GetBuses();
            if (b == null)
                return NotFound();
            return Ok(b);
        }

        // GET api/<BusesController>/5
        [HttpGet("byId/{id}")]
        public ActionResult<bus> Get(int id)
        {
            bus b = buses.getById(id);
            if (b == null)
                return NotFound();
            return Ok(b);

        }

        // POST api/<BusesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] bus bus)
        {
            bool b = buses.post(bus);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }

        // PUT api/<BusesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] bus bus)
        {
            bool b = buses.put(id, bus);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }

        // DELETE api/<BusesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = buses.delete(id);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }
        [HttpGet("{destination}")]
        public ActionResult<List<bus>> GetByDestination(string destination)
        {
            List<bus> b = buses.GetByDestination(destination);
            if (b == null)
                return NotFound(false);
            return Ok(b);
        }

    }
}
