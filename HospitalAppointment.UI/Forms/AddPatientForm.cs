using HospitalAppointment.Business.Services;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Enums;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalAppointment.UI.Forms
{
    public partial class AddPatientForm : Form
    {
        private readonly DoctorRepository _dRepo;
        private readonly AppDbContext _dbContext;
        private readonly DoctorService _dService;

        private readonly PatientRepository _pRepo;
        private readonly PatientService _pService;

        private readonly AppointmentRepository _aRepo;
        private readonly AppointmentService _aService;

        public AddPatientForm()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            _dRepo = new DoctorRepository(_dbContext);
            _dService = new DoctorService(_dRepo);

            _pRepo = new PatientRepository(_dbContext);
            _pService = new PatientService(_pRepo);

            _aRepo = new AppointmentRepository(_dbContext);
            _aService = new AppointmentService(_aRepo);
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_doktor.SelectedItem == null || dateTimePicker1?.Value == null || chkList.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                Patients? patient = new Patients()
                {
                    Name = txt_ad.Text,
                    Surname = txt_soyad.Text,
                    TcNo = txt_tc.Text,
                    IsActive = true
                };
                _pService.Create(patient);

                patient = _pService.GetAll().FirstOrDefault(p => p.TcNo == patient.TcNo);

                DateTime selectedDate = dateTimePicker1.Value.Date;
                Doctors selectedDoctor = (Doctors)cmb_doktor.SelectedItem;
                Guid doktorId = selectedDoctor.Id;

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
                                PatientId = patient.Id,
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
                            MessageBox.Show("Doktor seçilen saatte müsait değil.");
                        }
                    }
                    context.SaveChanges();
                }

                MessageBox.Show("Randevu başarıyla kaydedildi");
                txt_ad.Text = string.Empty;
                txt_soyad.Text = string.Empty;
                txt_tc.Text = string.Empty;
                LoadAvailableTimes();
                //GetAllPatients();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            cmb_bolum.DataSource = Enum.GetValues(typeof(Branches));
            //GetAllPatients();
            ClearForm();
        }


        //private void GetAllPatients()
        //{
        //    dgw_hastalar.DataSource = _pService.GetAll().Select(p => new
        //    {
        //        p.Id,
        //        p.Name,
        //        p.Surname,
        //        p.TcNo,
        //    }).ToList();
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimes();
        }

        private void LoadAvailableTimes()
        {
            if (cmb_doktor.SelectedItem == null || dateTimePicker1?.Value == null)
                return;

            chkList.Items.Clear();

            DateTime secilenTarih = dateTimePicker1.Value.Date;
            Doctors selectedDoctor = (Doctors)cmb_doktor.SelectedItem;
            Guid doktorId = selectedDoctor.Id;

            using (var context = new AppDbContext())
            {
                var availableTimes = context.DoctorAvailabilities
                                            .Where(a => a.DoctorId == doktorId && a.Date == secilenTarih && a.IsActive)
                                            .Select(a => a.Time)
                                            .ToList();

                //if (!availableTimes.Any())
                //{
                //    MessageBox.Show("Doktor, seçilen tarihte müsait değil.");
                //    return;
                //}

                foreach (var time in availableTimes)
                {
                    string saat = time.ToString(@"hh\:mm");
                    chkList.Items.Add(saat);
                }
            }
        }

        private void cmb_bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_bolum.SelectedItem is Branches selectedBranch)
            {
                var data = _dService.GetAll()
                                    .Where(d => d.Branch == selectedBranch)
                                    .ToList();

                cmb_doktor.DataSource = null;
                cmb_doktor.DataSource = data;
                cmb_doktor.DisplayMember = "FullName";
                cmb_doktor.ValueMember = "Id";

                //if (!data.Any())
                //{
                //    MessageBox.Show("Seçilen branşa ait doktor bulunamadı.");
                //}
            }
        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_doktor.SelectedIndex != -1)
            {
                LoadAvailableTimes();
            }
        }

        private void dgw_hastalar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void dgw_hastalar_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgw_hastalar.SelectedRows.Count > 0)
        //    {
        //        var selectedRow = dgw_hastalar.SelectedRows[0];

        //        Guid hastaId = (Guid)selectedRow.Cells["Id"].Value;

        //        Patients? selectedPatient = _pService.GetAll().FirstOrDefault(p => p.Id == hastaId);
        //        if (selectedPatient != null)
        //        {
        //            txt_ad.Text = selectedPatient.Name;
        //            txt_soyad.Text = selectedPatient.Surname;
        //            txt_tc.Text = selectedPatient.TcNo;
        //        }
        //        Appointment? patientAppointment = _aService.GetAll().FirstOrDefault(a => a.PatientId == hastaId && a.IsActive);
        //        if (patientAppointment != null)
        //        {
        //            Doctors? selectedDoctor = _dService.GetAll().FirstOrDefault(d => d.Id == patientAppointment.DoctorId);
        //            if (selectedDoctor != null)
        //            {
        //                cmb_doktor.SelectedItem = selectedDoctor;
        //                cmb_bolum.SelectedItem = selectedDoctor.Branch;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lütfen bir hasta seçiniz.");
        //    }
        //}

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txt_ad.Text = string.Empty;
            txt_soyad.Text = string.Empty;
            txt_tc.Text = string.Empty;
            cmb_bolum.SelectedIndex = -1;
            cmb_doktor.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            chkList.Items.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {


        }

        private void btn_sil_Click(object sender, EventArgs e)
        {


        }

        //private void txt_hastaAra_TextChanged(object sender, EventArgs e)
        //{
        //    string searchQuery = txt_tc.Text.Trim();
        //    if (!string.IsNullOrEmpty(searchQuery) && searchQuery.Length >= 3)
        //    {
        //        var data = _pService.GetAll();
        //        var results = data.Where(d => d.TcNo.ToString().Contains(searchQuery)) 
        //                            .ToList();
        //        dgw_hastalar.DataSource = results;
        //    }
        //    else
        //    {
        //        GetAllPatients();
        //    }
        //}

        private void dgw_hastalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
