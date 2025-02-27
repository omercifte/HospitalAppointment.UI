using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HospitalAppointment.Entities.Models;

namespace HospitalAppointment.Business.Validators
{
    public class DoctorInfoValidator: AbstractValidator<DoctorInfo>
    {
        public DoctorInfoValidator()
        {

        }
               
    }
}
