using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using HospitalAppointment.Business.Abstractions;
using HospitalAppointment.Business.Validators;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Models;

namespace HospitalAppointment.Business.Services
{
    public class DoctorService : IService<Doctors>
    {
        private readonly DoctorRepository _doctorRepository;
        public DoctorService(DoctorRepository dRepo)
        {
            _doctorRepository = dRepo;
        }
        public void Create(Doctors entity)
        {
            DoctorValidator dVal = new();
            ValidationResult result = dVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _doctorRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var d = _doctorRepository.GetByID(id);

            if (d == null)
            {
                throw new Exception("Doktor Bulunamadı.");
            }

            if (d.IsActive)
            {
                throw new Exception("Aktif bir doktor silinemez.");
            }

            _doctorRepository.Delete(id);
        }

        public IEnumerable<Doctors> GetAll()
        {
            return _doctorRepository.GetAll();
        }

        public Doctors GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _doctorRepository.GetByID(id);

        }

        public bool IfEntityExists(Expression<Func<Doctors, bool>> filter)
        {
            return _doctorRepository.IfEntityExists(filter);
        }

        public void Update(Doctors entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _doctorRepository.Update(entity);
        }
    }
}
