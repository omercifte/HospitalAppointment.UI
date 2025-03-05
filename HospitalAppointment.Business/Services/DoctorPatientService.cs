using FluentValidation.Results;
using HospitalAppointment.Business.Abstractions;
using HospitalAppointment.Business.Validators;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Models;
using System.Linq.Expressions;

namespace HospitalAppointment.Business.Services
{
    public class DoctorPatientService : IService<DoctorPatient>
    {
        private readonly DoctorPatientRepository _dpRepository;
        public DoctorPatientService(DoctorPatientRepository patientRepository)
        {
            _dpRepository = patientRepository;
        }
        public void Create(DoctorPatient entity)
        {
            DoctorPatientValidator dpVal = new();
            ValidationResult result = dpVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _dpRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var d = _dpRepository.GetByID(id);

            if (d == null)
            {
                throw new Exception("Bulunamadı.");
            }

            if (d.IsActive)
            {
                throw new Exception("Aktif bir ilaç silinemez.");
            }

            _dpRepository.Delete(id);
        }

        public IEnumerable<DoctorPatient> GetAll()
        {
            return _dpRepository.GetAll();
        }

        public DoctorPatient GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _dpRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<DoctorPatient, bool>> filter)
        {
            return _dpRepository.IfEntityExists(filter);
        }

        public void Update(DoctorPatient entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _dpRepository.Update(entity);
        }
    }
}
