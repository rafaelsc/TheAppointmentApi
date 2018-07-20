using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TheAppointmentApi.Service;
using TheAppointmentApi.WebApi.Models;

namespace TheAppointmentApi.WebApi.Controllers
{
    public class AppointmentsController : ApiController
    {
        public AppointmentsController(SlotService service)
        {
            Service = service;
        }

        public SlotService Service { get; set; }

        ////////////////////////////////////////////////////////////////////
         
        // GET: api/appointment
        [HttpGet]
        public IHttpActionResult Get() => NotFound();

        // GET: api/appointment/token/2018-12-15/free
        [Route("{token}/{date}/free")]
        [HttpGet]
        public AppointmentGetResultModel Get([Required] string token,  [Required] DateTimeOffset? date)
        {
            //TODO: Better Token Validation and Auth;
            //TODO: Better Date Validation;
            if (token == null)
                throw new HttpRequestException(); //TODO MSG
            if (date == null)
                throw new HttpRequestException(); //TODO MSG

            
            var slots = Service.GetFreeSlots((DateTimeOffset) date);
            var result = new AppointmentGetResultModel { Slots = slots.Select(s=>s.DateTime.Date) };
            return result;
        }
        
        // POST: api/appointment/token/2018-12-15/10:00/JhonSnow
        [Route("{token}/{date}/{time}/{patientName}")]
        [HttpPost]
        public IHttpActionResult Post([Required] string token, [Required] DateTimeOffset? date,  [Required] DateTimeOffset? time, [Required] string patientName)
        {
            //TODO: Better Token Validation and Auth;
            //TODO: Better Date Validation;
            //TODO: Better patientName Validation;

            if (token == null)
                return BadRequest(); //TODO MSG
            if (date == null)
                return BadRequest(); //TODO MSG
            if (time == null)
                return BadRequest(); //TODO MSG
            if (patientName == null)
                return BadRequest(); //TODO MSG

            var dateTimeOfAppointment = date.Value.Date;
            dateTimeOfAppointment.AddHours(time.Value.Hour);
            dateTimeOfAppointment.AddMinutes(time.Value.Minute);

            var appointmentId = Service.Save(dateTimeOfAppointment, patientName);
            return Ok(new AppointmentPostResultModel {AppointmentId = appointmentId});
        }
        
        // DELETE: api/appointment/5
        [Route("{token}/{appointmentId}")]
        [HttpDelete]
        public IHttpActionResult Delete([Required] string token, [Required] string appointmentId)
        {
            //TODO: Better appointmentId Validation;

            if (appointmentId == null)
                return BadRequest(); //TODO MSG

            throw new NotImplementedException();
        }
    }
}
