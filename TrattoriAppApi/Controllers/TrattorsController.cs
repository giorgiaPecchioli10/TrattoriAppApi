using Microsoft.AspNetCore.Mvc;
using TrattoriAppApi.Models;
using TrattoriAppApi.Service.ServiceInterfaces;

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
            //if (postTrattorModel==null)
            //    return BadRequest("Modello non valido"); 
            var addTrattor = _serviceTrattor.AddTrattor(postTrattorModel);
            return Created("", addTrattor);   //da modificare la rotta una volta creato il metodo getdetailtrattor
        }


        [HttpGet("{trattorId:int}")]
        public IActionResult GetDetail(int trattorId)
        { 
            var trattor = _serviceTrattor.GetTrattorDetail(trattorId);
            if (trattor == null)
                return NotFound("Trattore non trovato");
            return Ok(trattor);
           
           
        }

        [HttpGet("{color}")]
        public IActionResult GetAllByFilter(string color)
        {
            var trattor = _serviceTrattor.GetTrattorsByColor(color);
            if (trattor.Count()==0)
                return NotFound("Non esiste un trattore con questo colore");
            return Ok(trattor);
        }


        // GET: api/<TrattorsController>
        //[HttpGet("{id}")]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}


        // PUT api/<TrattorsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] PutTrattorModel putTrattorModel)
        //{

        //}

        //// DELETE api/<TrattorsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
