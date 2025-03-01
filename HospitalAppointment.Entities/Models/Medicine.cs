using HospitalAppointment.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Entities.Models
{
    public class Medicine:Entity
    {
        public string? Name { get; set; }
        public double Price { get; set; }
    }
}
