using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.DataAccess.Repositories
{
    public class DoctorPriceRepository : GenericRepository<DoctorPrice>
    {
        public DoctorPriceRepository(AppDbContext db) : base(db)
        {
        }
    }
}