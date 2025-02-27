using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointment.Entities.Abstractions;

namespace HospitalAppointment.Entities.Models
{
    public class DoctorInfo:Entity
    {

        public Guid DoctorId { get; set; }
        public DateTime AvailableDate { get; set; }
    }
}
