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
    [Route("api/Appointments")]
    public class AppointmentsController : Controller
    {
        // GET: api/Appointments
       
        // GET: api/appointment/asasasasas/2018-12-15/free
        [HttpGet("{token}/{date}/free", Name = "GetFreeSlots")]
        public string Get([Required] string token,  [Required] DateTimeOffset? date)
        {
            throw new NotImplementedException();
        }
        
        // POST: api/Appointments
        [HttpPost("{token}/{date}/{time}/{patientName}")]
        public AppointmentPostResultModel Post([Required] string token,  [Required] DateTimeOffset? date,  [Required] DateTimeOffset? time, [Required] string patientName)
        {
            throw new NotImplementedException();
        }
        
        // DELETE: api/Appointments/5
        [HttpDelete("{token}/{appointmentId}")]
        public void Delete([Required] string token, [Required] string appointmentId)
        {
            throw new NotImplementedException();
        }
    }
}
