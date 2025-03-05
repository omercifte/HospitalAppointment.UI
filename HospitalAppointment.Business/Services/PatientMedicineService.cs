using FluentValidation.Results;
using HospitalAppointment.Business.Abstractions;
using HospitalAppointment.Business.Validators;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.Business.Services
{
    public class PatientMedicineService : IService<PatientMedicine>
    {
        private readonly PatientMedicineRepository _pRepo;
        public PatientMedicineService(PatientMedicineRepository patientMedicineRepository)
        {
            _pRepo = patientMedicineRepository;
        }
        public void Create(PatientMedicine entity)
        {
            PatientMedicineValidator pmVal = new();
            ValidationResult result = pmVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _pRepo.Create(entity);
        }

        public void Delete(Guid id)
        {
            var data = _pRepo.GetByID(id);

            if (data == null)
            {
                throw new Exception("Randevu Bulunamadı.");
            }
            _pRepo.Delete(id);
        }

        public IEnumerable<PatientMedicine> GetAll()
        {
            return _pRepo.GetAll();

        }

        public PatientMedicine GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _pRepo.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<PatientMedicine, bool>> filter)
        {
            return _pRepo.IfEntityExists(filter);

        }

        public void Update(PatientMedicine entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _pRepo.Update(entity);
        }
    }
}
