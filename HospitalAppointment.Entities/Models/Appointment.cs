using HospitalAppointment.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Entities.Models
{
    public class Appointment:Entity
    {
        public Guid PatientId { get; set; }
        public Patients? Patient { get; set; }
        public Guid DoctorId { get; set; }
        public Doctors? Doctor { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan Time { get; set; }

    }
}
