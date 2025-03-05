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
    public partial class AccountForm : Form
    {
        private readonly AppDbContext _dbContext;

        private readonly DoctorRepository _dRepo;
        private readonly DoctorService _dService;

        private readonly PatientRepository _pRepo;
        private readonly PatientService _pService;

        private readonly AppointmentRepository _aRepo;
        private readonly AppointmentService _aService;

        private readonly MedicineRepository _mRepo;
        private readonly MedicineService _mService;

        private readonly DoctorPriceRepository _dpriceRepo;
        private readonly DoctorPriceService _dpriceService;
        public AccountForm()
        {
            InitializeComponent();

            _dbContext = new AppDbContext();
            _dRepo = new DoctorRepository(_dbContext);
            _dService = new DoctorService(_dRepo);

            _pRepo = new PatientRepository(_dbContext);
            _pService = new PatientService(_pRepo);

            _aRepo = new AppointmentRepository(_dbContext);
            _aService = new AppointmentService(_aRepo);

            _mRepo = new MedicineRepository(_dbContext);
            _mService = new MedicineService(_mRepo);

            _dpriceRepo = new DoctorPriceRepository(_dbContext);
            _dpriceService = new DoctorPriceService(_dpriceRepo);
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            GetAllPatients();
        }
        private void GetAllPatients()
        {
            var patients = _pService.GetAll();
            dataGridView1.DataSource = patients;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var patientId = (Guid)dataGridView1.CurrentRow.Cells[5].Value;
            var randevulist = _aRepo.Where(p => p.PatientId == patientId).ToList();
            randevulist.Select(p => p.DoctorId).Distinct().ToList();
            var doctorlist = randevulist.Select(p => p.DoctorId).Distinct().ToList();
            var branchlist = _dRepo.Where(p => doctorlist.Contains(p.Id)).Select(p => p.Branch).Distinct().ToList();
            var doctorpricelist = _dpriceRepo.Where(p => branchlist.Contains(p.Branch)).ToList();
            var sum = doctorpricelist.Sum(p => p.Price);
            txtPrice.Text = sum.ToString();
        }
    }
}
