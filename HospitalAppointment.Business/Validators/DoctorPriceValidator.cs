using FluentValidation;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Business.Validators
{
    public class DoctorPriceValidator : AbstractValidator<DoctorPrice>
    {
        public DoctorPriceValidator()
        {
            RuleFor(d => d.Price)
             .GreaterThan(0).WithMessage("İlaç fiyatı sıfırdan büyük olmalıdır.");

        }
    }
}

