using HospitalAppointment.UI.Tools;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void OpenForm(Form form)
        {
            if (!FormUtils.IsFormsOpen(form))
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void doktorKayıtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //OpenForm(new DoctorAddForm());
        }

        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenForm(new AddPatientForm());
        }

        private void ilaçYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenForm(new MedicineForm());
        }

        private void doktorBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenForm(new DoctorInfoForm());

        }

        private void randevuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doktorKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}