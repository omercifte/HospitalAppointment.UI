using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HospitalAppointment.Business.Services;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Enums;
using HospitalAppointment.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointment.UI.Forms
{
    public partial class DoctorAddForm : Form
    {
        private readonly DoctorRepository _doctorRepository;
        private readonly AppDbContext _context;
        private readonly DoctorService _doctorService;
        public DoctorAddForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _doctorRepository = new DoctorRepository(_context);
            _doctorService = new DoctorService(_doctorRepository);
        }

        private void DoctorAddForm_Load(object sender, EventArgs e)
        {
            cmbBranch.DataSource = Enum.GetValues(typeof(Branches));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Branches selectedBranch = (Branches)cmbBranch.SelectedItem;

                Doctors d = new Doctors()
                {
                    Name = txtDoctorName.Text,
                    Surname = txtDoctorSurname.Text,
                    Branch = selectedBranch,
                    IsActive = true
                };
                _doctorService.Create(d);
                MessageBox.Show("Kayıt Başarılı.");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            txtDoctorName.Clear();
            txtDoctorSurname.Clear();
            cmbBranch.SelectedIndex = -1;
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
