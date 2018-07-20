using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TheAppointmentApi.WebApi.Models;

namespace TheAppointmentApi.WebApi.Controllers
{
    public class AppointmentsController : ApiController
    {
        // GET: api/appointment
        [HttpGet]
        public IHttpActionResult Get() => NotFound();

        // GET: api/appointment/token/2018-12-15/free
        [Route("{token}/{date}/free")]
        [HttpGet]
        public IEnumerable<AppointmentGetResultModel> Get([Required] string token,  [Required] DateTimeOffset? date)
        {
            throw new NotImplementedException();
        }
        
        // POST: api/appointment/token/2018-12-15/10:00/JhonSnow
        [Route("{token}/{date}/{time}/{patientName}")]
        [HttpPost]
        public AppointmentPostResultModel Post([Required] string token,  [Required] DateTimeOffset? date,  [Required] DateTimeOffset? time, [Required] string patientName)
        {
            throw new NotImplementedException();
        }
        
        // DELETE: api/appointment/5
        [Route("{token}/{appointmentId}")]
        [HttpDelete]
        public void Delete([Required] string token, [Required] string appointmentId)
        {
            throw new NotImplementedException();
        }
    }
}
