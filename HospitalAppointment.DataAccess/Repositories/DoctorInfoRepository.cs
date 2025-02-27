using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.Entities.Models;

namespace HospitalAppointment.DataAccess.Repositories
{
    public class DoctorInfoRepository : GenericRepository<DoctorInfo>
    {
        public DoctorInfoRepository(AppDbContext db) : base(db)
        {

        }
    }
}
