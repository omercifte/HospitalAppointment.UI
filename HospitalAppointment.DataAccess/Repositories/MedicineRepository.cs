using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointment.DataAccess.Repositories
{
    public class MedicineRepository : GenericRepository<Medicine>
    {
        public MedicineRepository(AppDbContext db) : base(db)
        {
        }
    }
}
