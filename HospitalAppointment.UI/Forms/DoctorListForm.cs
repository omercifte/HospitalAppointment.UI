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
            lstDoctors.Items.Clear();
            _docService.GetAll().ToList().ForEach(x => lstDoctors.Items.Add(x));
        }
    }
}
