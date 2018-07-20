using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI;

namespace TheAppointmentApi.WebApi.Models
{
    public class AppointmentGetResultModel
    {
        public IEnumerable<DateTime> Slots { get; set; }
    }
}