using HospitalAppointment.Business.Services;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Enums;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAppointment.UI.Forms
{
    public partial class DoctorOriention : Form
    {
        private readonly DoctorRepository _dRepo;
        private readonly AppDbContext _dbContext;
        private readonly DoctorService _dService;

        private readonly PatientRepository _pRepo;
        private readonly PatientService _pService;

        private readonly AppointmentRepository _aRepo;
        private readonly AppointmentService _aService;

        private readonly MedicineRepository _mRepo;
        private readonly MedicineService _mService;


        public DoctorOriention()
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
        }

        private void DoctorOriention_Load(object sender, EventArgs e)
        {
            cmbBranch.DataSource = Enum.GetValues(typeof(Branches));
            GetAllPatients();
            GetAllMedicines();

        }
        private void GetAllMedicines()
        {
            var medicines = _mService.GetAll();  
            cmbMedicine.DataSource = medicines.ToList(); 
            cmbMedicine.DisplayMember = "Name";  
            cmbMedicine.ValueMember = "Id";    
        }

        private void GetAllPatients()
        {
            var patients = _pService.GetAll();

            dgHastalar.DataSource = patients;
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDoctor.SelectedItem == null || dtDate?.Value == null || chkList.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                if (dgHastalar.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen bir hasta seçiniz.");
                    return;
                }

                Guid patientId;
                if (!Guid.TryParse(dgHastalar.CurrentRow.Cells["Id"].Value?.ToString(), out patientId))
                {
                    MessageBox.Show("Seçilen hastanın ID'si geçerli değil.");
                    return;
                }

                DateTime selectedDate = dtDate.Value.Date;
                Doctors selectedDoctor = (Doctors)cmbDoctor.SelectedItem;
                Guid doktorId = selectedDoctor.Id;

                if (cmbMedicine.SelectedItem != null)
                {
                    selectedMedicine = (Medicine)cmbMedicine.SelectedItem;
                }
                var patient = _pService.GetByID(patientId);

                if (patient.PatientMedicines == null)
                {
                    patient.PatientMedicines = new List<PatientMedicine>();
                }

                PatientMedicine patientMedicine = new PatientMedicine()
                {
                    PatientId = patientId,
                    MedicineId =selectedMedicine.Id,
                    Medicine = selectedMedicine,
                    Patient = patient,
                };
                patient.PatientMedicines.Add(patientMedicine);

                _pService.Update(patient);



                using (var context = new AppDbContext())
                {
                    foreach (var item in chkList.CheckedItems)
                    {
                        string hours = item.ToString();
                        TimeSpan time = TimeSpan.Parse(hours);

                        var availability = context.DoctorAvailabilities
                                                  .FirstOrDefault(a => a.DoctorId == doktorId && a.Date == selectedDate && a.Time == time);

                        if (availability != null && availability.IsActive)
                        {
                            Appointment appointment = new()
                            {
                                PatientId = patientId,
                                DoctorId = doktorId,
                                AppointmentDate = selectedDate,
                                Time = time,
                                
                                IsActive = true
                            };
                            _aService.Create(appointment);

                            availability.IsActive = false;
                            context.DoctorAvailabilities.Update(availability);
                            context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show($"Doktor seçilen saatte ({time}) müsait değil.");
                        }

                    }
                }

                MessageBox.Show("Randevu başarıyla kaydedildi.");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            cmbDoctor.SelectedIndex = -1;
            dtDate.Value = DateTime.Today;
            cmbMedicine.SelectedIndex = -1;
            dgHastalar.ClearSelection();
            chkList.ClearSelected();
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimes();
        }

        private void LoadAvailableTimes()
        {
            if (cmbDoctor.SelectedItem == null || dtDate?.Value == null)
                return;

            chkList.Items.Clear();

            DateTime secilenTarih = dtDate.Value.Date;
            Doctors selectedDoctor = (Doctors)cmbDoctor.SelectedItem;
            Guid doktorId = selectedDoctor.Id;

            using (var context = new AppDbContext())
            {
                var availableTimes = context.DoctorAvailabilities
                                            .Where(a => a.DoctorId == doktorId && a.Date == secilenTarih && a.IsActive)
                                            .Select(a => a.Time)
                                            .ToList();

                foreach (var time in availableTimes)
                {
                    string saat = time.ToString(@"hh\:mm");
                    chkList.Items.Add(saat);
                }
            }
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedIndex != -1)
            {
                LoadAvailableTimes();
            }
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranch.SelectedItem is Branches selectedBranch)
            {
                var data = _dService.GetAll()
                                    .Where(d => d.Branch == selectedBranch)
                                    .ToList();

                cmbDoctor.DataSource = null;
                cmbDoctor.DataSource = data;
                cmbDoctor.DisplayMember = "FullName";
                cmbDoctor.ValueMember = "Id";
            }
        }
        Medicine selectedMedicine;
        private void cmbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicine.SelectedItem != null)
            {
                selectedMedicine = (Medicine)cmbMedicine.SelectedItem;
            }
        }
    }
}
