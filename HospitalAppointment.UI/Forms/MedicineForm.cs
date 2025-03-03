using HospitalAppointment.Business.Services;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.DataAccess.Repositories;
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
    public partial class MedicineForm : Form
    {
        private readonly MedicineRepository _medicineRepository;
        private readonly AppDbContext _context;
        private readonly MedicineService _medicineService;
        public MedicineForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _medicineRepository = new MedicineRepository(_context);
            _medicineService = new MedicineService(_medicineRepository);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Medicine medicine = new Medicine()
                {
                    IsActive = true,
                    Name = txt_ilacAdi.Text,
                    Price = Convert.ToDouble(txt_fiyat.Text),
                };
                _medicineService.Create(medicine);
                MessageBox.Show("Kayıt başarılı.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            GetAllMedicine();
        }

        private void GetAllMedicine()
        {
            _medicineService.GetAll().ToList().ForEach(x => lstList.Items.Add(x)); ;
        }
    }
}
