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
            GetAllDoctors();
        }

        private void GetAllDoctors()
        {
            dgw_doktorlar.DataSource = _doctorService.GetAll().Select(d => new
            {
                d.Id,
                d.Name,
                d.Surname,
                d.Branch
            }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Branches selectedBranch = (Branches)cmbBranch.SelectedItem;
                if (selectedDoctor == null)
                {
                    Doctors d = new Doctors()
                    {
                        Name = txtDoctorName.Text,
                        Surname = txtDoctorSurname.Text,
                        Branch = selectedBranch,
                        IsActive = true
                    };

                    _doctorService.Create(d);
                    MessageBox.Show("Kayıt Başarılı.");
                }
                else
                {
                    var doctorUpdate = _doctorService.GetByID(selectedDoctor.Id);
                    if (doctorUpdate != null)
                    {
                        doctorUpdate.Name = txtDoctorName.Text;
                        doctorUpdate.Surname = txtDoctorSurname.Text;
                        doctorUpdate.Branch = selectedBranch;

                        _doctorService.Update(doctorUpdate);
                        MessageBox.Show("Doktor başarıyla güncellendi.");
                    }
                }
                GetAllDoctors();
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
            txt_aramaYap.Clear();
            cmbBranch.SelectedIndex = -1;
            selectedDoctor = null;
            dgw_doktorlar.ClearSelection();
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            string searchQuery = txt_aramaYap.Text.Trim();
            var doctors = _doctorService.GetAll();

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


        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgw_doktorlar.SelectedRows.Count > 0)
            {
                var selectedRow = dgw_doktorlar.SelectedRows[0];
                var doctorIdCell = selectedRow.Cells["Id"];
                var doctorId = (Guid)doctorIdCell.Value;

                var data = _doctorService.GetByID(doctorId);

                DialogResult result = MessageBox.Show(
                    $"Doktor {data.Name} {data.Surname} silinsin mi?",
                    "Uyarı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    data.IsActive = false;
                    _doctorService.Delete(doctorId);
                    GetAllDoctors();
                    MessageBox.Show("Doktor başarıyla silindi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir doktoru seçin.");
            }
        }
        Doctors selectedDoctor;
        private void dgw_doktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgw_doktorlar.Rows[e.RowIndex];
                var doctorId = (Guid)selectedRow.Cells["Id"].Value;

                selectedDoctor = _doctorService.GetByID(doctorId);
                txtDoctorName.Text = selectedDoctor.Name;
                txtDoctorSurname.Text = selectedDoctor.Surname;
                cmbBranch.SelectedItem = selectedDoctor.Branch;
            }
        }
    }
}
