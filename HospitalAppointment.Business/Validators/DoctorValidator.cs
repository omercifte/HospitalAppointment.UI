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
                .NotEmpty().WithMessage("Category name is required.")
                .Length(2, 50).WithMessage("Category name must be between 2 and 50 characters.");

            RuleFor(doctor => doctor.Surname)
                .MaximumLength(200).WithMessage("Description cannot be longer than 200 characters.");

            RuleFor(doctor => doctor.Branch)
              .NotEmpty().WithMessage("Category name is required.");
        }
    }
}
