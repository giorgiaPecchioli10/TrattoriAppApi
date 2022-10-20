using Microsoft.AspNetCore.Mvc;
using TrattoriAppApi.Models;
using TrattoriAppApi.Service.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrattoriAppApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TrattorsController : ControllerBase
    {
        private readonly IServiceTrattor _serviceTrattor;

        public TrattorsController(IServiceTrattor serviceTrattor)
        {
            _serviceTrattor = serviceTrattor;   
        }

       
        [HttpPost]
        public IActionResult Create([FromBody] PostTrattorModel postTrattorModel)
        {
            //if(postTrattorModel == null)
                
            var addTrattor = _serviceTrattor.AddTrattor(postTrattorModel);
            return Created("",addTrattor);   //da modificare la rotta una volta creato il metodo getdetailtrattor
        }




        // GET: api/<TrattorsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TrattorsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

       

        // PUT api/<TrattorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrattorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
