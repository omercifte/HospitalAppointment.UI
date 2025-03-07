﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointment.Entities.Abstractions;
using HospitalAppointment.Entities.Enums;

namespace HospitalAppointment.Entities.Models
{
    public class Doctors:Entity
    { 
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FullName => $"{Name} {Surname}";
        public Branches Branch { get; set; }

        //public ICollection<Patients>? Patients { get; set; }
  
        public ICollection<Appointment>? Appointments { get; set; }
        public List<DoctorPatient>? DoctorPatients { get; set; }

        public override string ToString()
        {
            return $"{FullName} {Branch}";
        }
    }
}
