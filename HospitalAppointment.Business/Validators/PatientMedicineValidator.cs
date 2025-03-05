using FluentValidation;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Business.Validators
{
    public class PatientMedicineValidator:AbstractValidator<PatientMedicine>
    {
        public PatientMedicineValidator()
        {
            RuleFor(pm => pm.PatientId)
            .NotEmpty().WithMessage("Hasta ID boş olamaz.");

            RuleFor(pm => pm.MedicineId)
            .NotEmpty().WithMessage("İlaç ID boş olamaz.");

            RuleFor(pm => pm.PrescriptionDate)
            .NotEmpty().WithMessage("Reçete tarihi boş olamaz.");
        }
    }
}
