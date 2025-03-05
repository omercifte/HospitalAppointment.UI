using HospitalAppointment.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Entities.Models
{
    public class DoctorPatient:Entity
    {
        public Guid DoctorId { get; set; }
        public Doctors Doctor { get; set; }

        public Guid PatientId { get; set; }
        public Patients Patient { get; set; }
    }
}
