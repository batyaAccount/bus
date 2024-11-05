﻿using busesProject.Lists;
using busesProject.pages;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace busesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        public StationList stationList { get; set; } = new StationList();

        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<List<Station>> Get()
        {
           return stationList.GetStation();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("getById/{id}")]
        public ActionResult<Station> GetById(int id)
        {

            Station e = stationList.getByIdStation(id);
            if (e == null)
                return NotFound();
            return e;

        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Station station)
        {
            bool b = stationList.Add(station);
            if (b == false)
                return NotFound(false);
            return b;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Station r)
        {
            bool b = stationList.Update(id, r);
            if (b == false)
                return NotFound(false);
            return b;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = stationList.DeleteStation(id);
            if (b == false)
                return NotFound(false);
            return b;
        }
        [HttpDelete("DeleteByGps/{gps}")]
        public ActionResult<bool> DeleteByGps(string gps)
        {
           bool b = stationList.DeleteStation(gps);
            if (b == null)
                return NotFound(false);
            return b;

        }
      
    }
}
