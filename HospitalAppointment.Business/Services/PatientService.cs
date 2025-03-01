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
    public class PatientService : IService<Patients>
    {
        private readonly PatientRepository _patientRepository;
        public PatientService(PatientRepository pRepo)
        {
            _patientRepository = pRepo;
        }
        public void Create(Patients entity)
        {
            PatientValidator pVal = new PatientValidator();
            ValidationResult result = pVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _patientRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var data = _patientRepository.GetByID(id);
            if (data == null)
            {
                throw new Exception("Hasta bulunamadı.");
            }
            if (data.IsActive)
            {
                throw new Exception("Aktif bir hasta silinemez.");
            }
            _patientRepository.Delete(id);
        }

        public IEnumerable<Patients> GetAll()
        {
            return _patientRepository.GetAll();
        }

        public Patients GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("Id bilgisi boş olamaz");
            }
            return _patientRepository.GetByID(id);

        }

        public bool IfEntityExists(Expression<Func<Patients, bool>> filter)
        {
            return _patientRepository.IfEntityExists(filter);
        }

        public void Update(Patients entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity bilgisi null olamaz.");
            }
            _patientRepository.Update(entity);
        }
    }
}
