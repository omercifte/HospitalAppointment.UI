using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointment.Entities.Abstractions;

namespace HospitalAppointment.Entities.Models
{
    public class DoctorAvailability:Entity
    {
        public Guid DoctorId { get; set; }
        public Doctors Doctor { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
    }
}
