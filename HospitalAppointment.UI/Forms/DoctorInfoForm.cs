using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.Entities.Models;

namespace HospitalAppointment.UI.Forms
{
    public partial class DoctorInfoForm : Form
    {
        public DoctorInfoForm()
        {
            InitializeComponent();
        }

        private void DoctorInfoForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            using (var context = new AppDbContext())
            {
                var doctors = context.Doctors.ToList();
                cmbDoctor.DataSource = doctors;
                cmbDoctor.DisplayMember = "FullName";
                cmbDoctor.ValueMember = "Id";
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimes();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;
            chkList.Items.Clear();
            LoadAvailableTimes();
        }

        private void LoadAvailableTimes()
        {
            if (cmbDoctor.SelectedItem == null)
                return;

            chkList.Items.Clear(); 

            DateTime secilenTarih = dtpDate.Value.Date;
            Guid doktorID = ((Doctors)cmbDoctor.SelectedItem).Id;

            DateTime baslangicSaati = secilenTarih.AddHours(9); 
            DateTime bitisSaati = secilenTarih.AddHours(17);    

            using (var context = new AppDbContext())
            {
                var existingTimes = context.DoctorAvailabilities
                                           .Where(a => a.DoctorId == doktorID && a.Date == secilenTarih)
                                           .Select(a => a.Time)
                                           .ToList();

                while (baslangicSaati < bitisSaati)
                {
                    string saat = baslangicSaati.ToString("HH:mm");
                    chkList.Items.Add(saat, existingTimes.Contains(baslangicSaati.TimeOfDay));
                    baslangicSaati = baslangicSaati.AddMinutes(30);
                }
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedItem == null || chkList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir doktor ve saat seçiniz.");
                return;
            }

            Guid doktorID = ((Doctors)cmbDoctor.SelectedItem).Id;
            DateTime secilenTarih = dtpDate.Value.Date;

            using (var context = new AppDbContext())
            {
                var doctorExists = context.Doctors.Any(d => d.Id == doktorID);
                if (!doctorExists)
                {
                    MessageBox.Show("Seçilen doktor bulunamadı.");
                    return;
                }

                
                var existingRecords = context.DoctorAvailabilities
                                             .Where(a => a.DoctorId == doktorID && a.Date == secilenTarih)
                                             .ToList();
                context.DoctorAvailabilities.RemoveRange(existingRecords);

                foreach (var item in chkList.CheckedItems)
                {
                    string saat = item.ToString();
                    TimeSpan saatDilimi = TimeSpan.Parse(saat);

                    var musaitlik = new DoctorAvailability
                    {
                        DoctorId = doktorID,
                        Date = secilenTarih,
                        Time = saatDilimi,
                        IsActive = true
                    };

                    context.DoctorAvailabilities.Add(musaitlik);
                }

                context.SaveChanges();
            }

            MessageBox.Show("Müsaitlikler kaydedildi!");
            LoadAvailableTimes();
            ClearForm();
        }

        private void ClearForm()
        {
            cmbDoctor.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
            foreach (int index in chkList.CheckedIndices)
            {
                chkList.SetItemChecked(index, false);
            }
            chkList.Items.Clear();

        }
    }
}
