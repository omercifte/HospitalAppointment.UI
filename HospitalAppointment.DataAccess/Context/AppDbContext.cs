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
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<DoctorAvailability> DoctorAvailabilities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalProje;Integrated Security=True;Trust Server Certificate=True;");
            //optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=HospitalProje;User ID=sa;Password=12345;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");

        }
    }
}
