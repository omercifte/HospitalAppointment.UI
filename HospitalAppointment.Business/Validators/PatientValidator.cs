using FluentValidation;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Business.Validators
{
    public class PatientValidator : AbstractValidator<Patients>
    {
        public PatientValidator()
        {
            RuleFor(p => p.Name)
           .NotNull().WithMessage("Hasta adı boş olamaz.")
           .Length(2, 50).WithMessage("Hasta adı 2 ile 50 karakter arasında olmalıdır.");

            RuleFor(p => p.Surname)
            .NotNull().WithMessage("Hasta soyadı boş olamaz.")
            .Length(2, 50).WithMessage("Hasta soyadı 2 ile 50 karakter arasında olmalıdır.");

            RuleFor(p => p.TcNo)
            .NotNull().WithMessage("TC No boş olamaz.")
            .Matches(@"^\d{11}$").WithMessage("TC No 11 haneli ve sadece rakamlardan oluşmalıdır.");

        }
    }
}
