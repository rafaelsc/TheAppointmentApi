using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheAppointmentApi.WebApi.Controllers.Model;

namespace TheAppointmentApi.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/appointments")]
    public class AppointmentController : Controller
    {
        // GET: api/appointment
        [HttpGet]
        public IActionResult Get() => NotFound();

        // GET: api/appointment/asasasasas/2018-12-15/free
        [HttpGet("{token}/{date}/free", Name = "GetFreeSlots")]
        public string Get([Required] string token,  [Required] DateTimeOffset? date)
        {
            throw new NotImplementedException();
        }
        
        // POST: api/appointment
        [HttpPost("{token}/{date}/{time}/{patientName}")]
        public AppointmentPostResultModel Post([Required] string token,  [Required] DateTimeOffset? date,  [Required] DateTimeOffset? time, [Required] string patientName)
        {
            throw new NotImplementedException();
        }
        
        //// PUT: api/appointment/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        // DELETE: api/appointment/5
        [HttpDelete("{token}/{appointmentId}")]
        public void Delete([Required] string token, [Required] string appointmentId)
        {
            throw new NotImplementedException();
        }
    }
}
