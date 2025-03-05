using HospitalAppointment.Business.Abstractions;
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
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace HospitalAppointment.UI.Forms
{
    public partial class BranchPrice : Form
    {
        private readonly AppDbContext _dbContext;

        private readonly DoctorPriceRepository _dRepo;
        private readonly DoctorPriceService _dService;

        private readonly AppointmentRepository _aRepo;
        private readonly AppointmentService _aService;
        public BranchPrice()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            _dRepo = new DoctorPriceRepository(_dbContext);
            _dService = new DoctorPriceService(_dRepo);

            _aRepo = new AppointmentRepository(_dbContext);
            _aService = new AppointmentService(_aRepo);
        }

        private void BranchPrice_Load(object sender, EventArgs e)
        {
            GetAllBranch();
            GetAllPrice();

        }

        private void GetAllBranch()
        {
            cmbBransh.DataSource = Enum.GetValues(typeof(Branches));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Branches selectedBranch = (Branches)cmbBransh.SelectedItem;

                DoctorPrice d = new DoctorPrice()
                {

                    Branch = selectedBranch,
                     Price = (Double)Convert.ToDecimal(txtPrice.Text),


                };
                _dService.Create(d);
                MessageBox.Show("Kayıt Başarılı.");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lstList.Items.Clear();
            GetAllPrice();
               
        }

        private void GetAllPrice()
        {
            _dService.GetAll().ToList().ForEach(x => lstList.Items.Add(x)); ;
        }
    }
}
