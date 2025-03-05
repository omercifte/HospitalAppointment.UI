using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointment.Entities.Abstractions;
using HospitalAppointment.Entities.Enums;

namespace HospitalAppointment.Entities.Models
{
    public class Patients: Entity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FullName => $"{Name} {Surname}";
        public string? TcNo { get; set; }
       // public ICollection<Doctors>? Doctors { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
        public List<DoctorPatient>? DoctorPatients { get; set; }
        public List<PatientMedicine>? PatientMedicines { get; set; }

        public override string ToString()
        {
            return $"{TcNo} - {FullName} ";
        }

    }
}
