using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace TheAppointmentApi.Service.Entity
{
    public class Slot
    {
        [Required]
        public DateTime DateTime { get; set; }

        [CanBeNull]
        public Appointment Appointment { get; set; }
    }
}