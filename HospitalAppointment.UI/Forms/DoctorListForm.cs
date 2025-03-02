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

namespace HospitalAppointment.UI.Forms
{
    public partial class DoctorListForm : Form
    {
        private readonly DoctorService _docService;
        private readonly DoctorRepository _docRepository;
        public DoctorListForm()
        {
            InitializeComponent();
            var context = new AppDbContext();
            _docRepository = new DoctorRepository(context);
            _docService = new DoctorService(_docRepository);
        }

        private void DoctorListForm_Load(object sender, EventArgs e)
        {
            GetAllDoctors();
        }

        private void GetAllDoctors()
        {
            var doctors = _docService.GetAll();
            dgw_doktorlar.DataSource = doctors;
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string searchQuery = txt_aramaYap.Text.Trim();
            var doctors = _docService.GetAll();

            if (radioButton1.Checked)
            {
                var results = doctors.Where(d => d.Name.ToLower().Contains(searchQuery.ToLower())).ToList();
                dgw_doktorlar.DataSource = results;
            }
            else if (radioButton2.Checked)
            {
                var results = doctors.Where(d => d.Branch.ToString().ToLower().Contains(searchQuery.ToLower())).ToList();
                dgw_doktorlar.DataSource = results;
            }
            txt_aramaYap.Clear();
        }
    }
}
