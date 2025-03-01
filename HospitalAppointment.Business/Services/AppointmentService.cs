using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using HospitalAppointment.Business.Validators;
using HospitalAppointment.Business.Abstractions;
using System.Linq.Expressions;
using FluentValidation.Results;

namespace HospitalAppointment.Business.Services
{
    public class AppointmentService:IService<Appointment>
    {
        private readonly AppointmentRepository _appointmentRepo;
       
        public AppointmentService(AppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
            
        }

        public void Create(Appointment entity)
        {
            AppointmentValidator aVal = new();
            ValidationResult result = aVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _appointmentRepo.Create(entity);
        }

        public void Delete(Guid id)
        {
            var data = _appointmentRepo.GetByID(id);

            if (data == null)
            {
                throw new Exception("Randevu Bulunamadı.");
            }
            _appointmentRepo.Delete(id);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _appointmentRepo.GetAll();

        }

        public Appointment GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _appointmentRepo.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Appointment, bool>> filter)
        {
            return _appointmentRepo.IfEntityExists(filter);

        }

        public void Update(Appointment entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _appointmentRepo.Update(entity);
        }
    }
}
