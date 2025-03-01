using FluentValidation;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Business.Validators
{
    public class MedicineValidator:AbstractValidator<Medicine>
    {
        public MedicineValidator()
        {
            RuleFor(m => m.Name)
            .NotNull().WithMessage("İlaç adı boş olamaz.")
            .Length(2, 100).WithMessage("İlaç adı 2 ile 100 karakter arasında olmalıdır.");

            RuleFor(m => m.Price)
            .GreaterThan(0).WithMessage("İlaç fiyatı sıfırdan büyük olmalıdır.");
        }
    }
}
