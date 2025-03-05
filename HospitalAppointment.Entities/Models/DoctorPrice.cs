using HospitalAppointment.Entities.Abstractions;
using HospitalAppointment.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Entities.Models
{
     public class DoctorPrice:Entity
    {
        public double Price { get; set; }
        public Branches Branch { get; set; }
        public override string ToString()
        {
            return $"{Branch} - {Price}{"TL"}";
        }
    }
}
