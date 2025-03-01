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
    public class MedicineService : IService<Medicine>
    {
        private readonly MedicineRepository _medicineRepository;
        public MedicineService(MedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }
        public void Create(Medicine entity)
        {
            MedicineValidator mVal = new();
            ValidationResult result = mVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _medicineRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var d = _medicineRepository.GetByID(id);

            if (d == null)
            {
                throw new Exception("İlaç Bulunamadı.");
            }

            if (d.IsActive)
            {
                throw new Exception("Aktif bir ilaç silinemez.");
            }

            _medicineRepository.Delete(id);
        }

        public IEnumerable<Medicine> GetAll()
        {
            return _medicineRepository.GetAll();
        }

        public Medicine GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }
            return _medicineRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Medicine, bool>> filter)
        {
            return _medicineRepository.IfEntityExists(filter);

        }

        public void Update(Medicine entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }
            _medicineRepository.Update(entity);
        }
    }
}
