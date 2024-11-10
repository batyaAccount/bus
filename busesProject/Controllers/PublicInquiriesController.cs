using busesProject.Lists;
using busesProject.pages;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace busesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicInquiriesController : ControllerBase
    {
        public PublicInquiriesList publicInquiries { get; set; } = new PublicInquiriesList();
        // GET: api/<BusesController>
        [HttpGet]
        public ActionResult<List<PublicInquiries>> Get()
        {
          return publicInquiries.GetInq();
          
             
        }

        // GET api/<BusesController>/5
        [HttpGet("byId/{id}")]
        public ActionResult<PublicInquiries> Get(int id)
        {
            if (id < 0)
                return BadRequest();
            PublicInquiries b = publicInquiries.getByIdInq(id);
            if (b == null)
                return NotFound();
            return b;

        }

        // POST api/<BusesController>
        [HttpPost]
        public ActionResult Post([FromBody] PublicInquiries bus)
        {
            bool b = publicInquiries.Add(bus);
            if (b == false)
                return BadRequest();
            return Ok(b);
        }

        // PUT api/<BusesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] PublicInquiries publicInquiry)
        {
            bool b = publicInquiries.Update(id, publicInquiry);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }

        // DELETE api/<BusesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool b = publicInquiries.DeleteInq(id);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }
        [HttpDelete("daleteByDate/{date}")]
        public ActionResult deleteByDate(DateTime date)
        {
            bool b = publicInquiries.DeleteByDate(date);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }
    }
}
