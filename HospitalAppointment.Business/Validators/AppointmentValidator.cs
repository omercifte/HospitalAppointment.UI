using FluentValidation;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Business.Validators
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {
        public AppointmentValidator()
        {
            RuleFor(a => a.PatientId)
                .NotEmpty().WithMessage("Hasta ID boş olamaz.");

            RuleFor(a => a.DoctorId)
                .NotEmpty().WithMessage("Doktor ID boş olamaz.");

            RuleFor(a => a.AppointmentDate)
                .NotEmpty().WithMessage("Tarih boş olamaz.")
                .GreaterThanOrEqualTo(DateTime.Today).WithMessage("Randevu geçmiş bir tarihte olamaz.");

            RuleFor(a => a.Time)
                .NotEmpty().WithMessage("Saat boş olamaz.");
        }
    }

    }
