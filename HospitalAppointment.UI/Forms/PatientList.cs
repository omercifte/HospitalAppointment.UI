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
    public partial class PatientList : Form
    {
        private readonly PatientService _pService;
        private readonly PatientRepository _pRepository;
        public PatientList()
        {
            InitializeComponent();
            var context = new AppDbContext();
            _pRepository = new PatientRepository(context);
            _pService = new PatientService(_pRepository);
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            GetAllPatients();

        }
        private void GetAllPatients()
        {
            lstPatients.Items.Clear();
            _pService.GetAll().ToList().ForEach(x => lstPatients.Items.Add(x));
        }

    }
}
