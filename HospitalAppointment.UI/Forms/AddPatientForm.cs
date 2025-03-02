using HospitalAppointment.Business.Services;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.DataAccess.Repositories;
using HospitalAppointment.Entities.Enums;
using HospitalAppointment.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

                Patients patient = new Patients()
                {
                    Name = txt_ad.Text,
                    Surname = txt_soyad.Text,
                    TcNo = txt_tc.Text,
                    IsActive = true
                };
                _pService.Create(patient);

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
                                Time = time
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
                LoadAvailableTimes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            cmb_bolum.DataSource = Enum.GetValues(typeof(Branches));
            GetAllPatients();
        }

        private void GetAllPatients()
        {
            List<Patients> data;
            if (txt_hastaAra != null && txt_hastaAra.Text.Length >= 3)
            {
                data = _pService.GetAll().Where(x => x.TcNo.Contains(txt_hastaAra.Text)).ToList();
            }
            else
            {
                data = _pService.GetAll().ToList();
            }
            dgw_hastalar.DataSource = null;
            dgw_hastalar.DataSource = data;
        }

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
            LoadAvailableTimes();
        }

        private void dgw_hastalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_hastaAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
