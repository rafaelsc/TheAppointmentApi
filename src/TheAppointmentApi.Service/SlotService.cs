using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using TheAppointmentApi.Data;
using TheAppointmentApi.Service.Entity;

namespace TheAppointmentApi.Service
{
    public class SlotService
    {
        public SlotService(IAppointmentRepository repository)
        {
            Repository = repository;
        }

        public IAppointmentRepository Repository { get; }

        public IEnumerable<Slot> GetFreeSlots(DateTimeOffset date)
        {
            throw new NotImplementedException();
        }

        public string Save(DateTimeOffset dateTimeOfAppointment, [NotNull] string patientName)
        {
            throw new NotImplementedException();
        }

        public void Delete([NotNull] string appointmentId)
        {
            throw new NotImplementedException();
        }
    }
}
