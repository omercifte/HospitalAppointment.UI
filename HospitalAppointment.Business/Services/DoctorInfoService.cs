using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using HospitalAppointment.Business.Abstractions;
using HospitalAppointment.Business.Validators;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Models;

namespace HospitalAppointment.Business.Services
{
    public class DoctorInfoService : IService<DoctorInfo>
    {
        private readonly DoctorInfoRepository _doctorinfoRepository;
        public DoctorInfoService(DoctorInfoRepository diRepo)
        {
            _doctorinfoRepository = diRepo;
        }
        public void Create(DoctorInfo entity)
        {
            DoctorInfoValidator diVal = new();
            ValidationResult result = diVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _doctorinfoRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var dinfo = _doctorinfoRepository.GetByID(id);

            if (dinfo == null)
            {
                throw new Exception("Tedarikçi Bulunamadı.");
            }

            if (dinfo.IsActive)
            {
                throw new Exception("Aktif bir Tedarikçi silinemez.");
            }

            _doctorinfoRepository.Delete(id);
        }

        public IEnumerable<DoctorInfo> GetAll()
        {
            return _doctorinfoRepository.GetAll();
        }

        public DoctorInfo GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _doctorinfoRepository.GetByID(id);

        }

        public bool IfEntityExists(Expression<Func<DoctorInfo, bool>> filter)
        {
            return _doctorinfoRepository.IfEntityExists(filter);
        }

        public void Update(DoctorInfo entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _doctorinfoRepository.Update(entity);
        }
    }
}
