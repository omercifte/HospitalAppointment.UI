using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointment.Business.Services;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointment.UI.Forms
{
    public partial class PatientCountForm : Form
    {
        private readonly AppointmentRepository _aRepository;
        private readonly AppDbContext _context;


        public PatientCountForm()
        {
            InitializeComponent();

            _context = new AppDbContext();
            _aRepository = new AppointmentRepository(_context);


        }

        private void PatientCountForm_Load(object sender, EventArgs e)
        {
            BranchesCount();
        }

        private void BranchesCount()
        {
            var branchCounts = _context.Appointments
                .Include(x => x.Doctor) // Doktor bilgilerini getir
                .Where(x => x.Doctor != null && x.Doctor.Branch != null) // Null hatasını önle
                .GroupBy(x => x.Doctor.Branch) // Branşa göre gruplama
                .Select(group => new
                {
                    BranchName = group.Key, // Branş adı
                    AppointmentCount = group.Count() // O branştaki randevu sayısı
                })
                .ToList(); // Liste olarak al

            lstCount.Items.Clear();
            foreach (var item in branchCounts)
            {
                lstCount.Items.Add($"{item.BranchName}: {item.AppointmentCount} randevu");
            }

        }

    }
}
