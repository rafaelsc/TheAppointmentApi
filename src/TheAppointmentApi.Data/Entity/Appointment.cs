using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace TheAppointmentApi.Service.Entity
{
    public class Appointment
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string Name { get; set; }

        [Required]
        public Slot Slot { get; set; }
    }
}