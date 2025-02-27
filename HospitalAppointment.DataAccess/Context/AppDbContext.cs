using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointment.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointment.DataAccess.Context
{
    public class AppDbContext:DbContext
    {

        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<DoctorInfo> Doctorinfo { get; set; }
        public DbSet<DoctorAvailability> DoctorAvailabilities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalProje;Integrated Security=True;Trust Server Certificate=True;");
        }
    }
}
