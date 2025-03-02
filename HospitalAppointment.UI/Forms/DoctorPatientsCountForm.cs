using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointment.DataAccess.Abstractions;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointment.UI.Forms
{
    public partial class DoctorPatientsCountForm : Form
    {
        private readonly AppDbContext _context;
        public DoctorPatientsCountForm()
        {
            InitializeComponent();
            _context = new AppDbContext();   
        }

        private void DoctorPatientsCountForm_Load(object sender, EventArgs e)
        {
            DoctorPatientsCount();
        }

        private void DoctorPatientsCount()
        {
            var branchCounts = _context.Appointments
                .Include(x => x.Doctor) // Doktor bilgilerini getir
                .Where(x => x.Doctor != null && x.Doctor.Branch != null) // Null hatasını önle
                .GroupBy(x => x.Doctor.Id) // Branşa göre gruplama
                .Select(group => new
                {
                    doctorname = group.FirstOrDefault().Doctor.FullName, // Branş adı
                    AppointmentCount = group.Count() // O branştaki randevu sayısı
                })
                .ToList(); // Liste olarak al

            lstCount.Items.Clear();
            foreach (var item in branchCounts)
            {
                lstCount.Items.Add($"{item.doctorname}: {item.AppointmentCount} randevu");
            }
        }
    }
}
