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
    
    public class DoctorPriceService : IService<DoctorPrice>
    {
        private readonly DoctorPriceRepository _doctorPriceRepository;


        public DoctorPriceService(DoctorPriceRepository DoctorPriceRepository)
        {
            _doctorPriceRepository= DoctorPriceRepository;
        }
        public void Create(DoctorPrice entity)
        {
            DoctorPriceValidator dpVal = new();
            ValidationResult result = dpVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _doctorPriceRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var d = _doctorPriceRepository.GetByID(id);

            if (d == null)
            {
                throw new Exception("İlaç Bulunamadı.");
            }

            if (d.IsActive)
            {
                throw new Exception("Aktif bir ilaç silinemez.");
            }

            _doctorPriceRepository.Delete(id);
        }

        public IEnumerable<DoctorPrice> GetAll()
        {
            return (IEnumerable<DoctorPrice>)_doctorPriceRepository.GetAll();
        }

        public DoctorPrice GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }
            return _doctorPriceRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<DoctorPrice, bool>> filter)
        {
            return _doctorPriceRepository.IfEntityExists(filter);

        }

        public void Update(DoctorPrice entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }
            _doctorPriceRepository.Update(entity);
        }
    }
}


