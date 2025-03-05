using FluentValidation;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Business.Validators
{
    public class DoctorPatientValidator:AbstractValidator<DoctorPatient>
    {
        public DoctorPatientValidator()
        {
            RuleFor(dp => dp.DoctorId)
            .NotEmpty().WithMessage("Doktor ID boş olamaz.");

            RuleFor(dp => dp.PatientId)
            .NotEmpty().WithMessage("Hasta ID boş olamaz.");
        }
    }
}
