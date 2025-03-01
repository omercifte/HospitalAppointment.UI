using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HospitalAppointment.Entities.Models;

namespace HospitalAppointment.Business.Validators
{
    public class DoctorValidator: AbstractValidator<Doctors>
    {
        public DoctorValidator()
        {
            RuleFor(doctor => doctor.Name)
                .NotEmpty().WithMessage("Doktor adı boş geçilemez.")
                .Length(2, 50).WithMessage("Doktor adı 2 ila 50 karakter arasında olmalıdır.");

            RuleFor(doctor => doctor.Name)
             .NotEmpty().WithMessage("Doktor soyadı boş geçilemez.")
             .Length(2, 50).WithMessage("Doktor soyadı 2 ila 50 karakter arasında olmalıdır.");


            RuleFor(doctor => doctor.Branch)
              .NotEmpty().WithMessage("Doktor branşı boş geçilemez.");
        }
    }
}
