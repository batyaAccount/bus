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
            List<PublicInquiries> b = publicInquiries.Get();
            if (b == null)
                return NotFound();
            return Ok(b);
        }

        // GET api/<BusesController>/5
        [HttpGet("byId/{id}")]
        public ActionResult<PublicInquiries> Get(int id)
        {
            PublicInquiries b = publicInquiries.getById(id);
            if (b == null)
                return NotFound();
            return Ok(b);

        }

        // POST api/<BusesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] PublicInquiries bus)
        {
            bool b = publicInquiries.post(bus);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }

        // PUT api/<BusesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] PublicInquiries publicInquiry)
        {
            bool b = publicInquiries.put(id, publicInquiry);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }

        // DELETE api/<BusesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool b = publicInquiries.delete(id);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }
        [HttpDelete("daleteByDate/{date}")]
        public ActionResult<bool> deleteByDate(DateTime date)
        {
            bool b = publicInquiries.deleteByDate(date);
            if (b == false)
                return NotFound(false);
            return Ok(b);
        }
    }
}
