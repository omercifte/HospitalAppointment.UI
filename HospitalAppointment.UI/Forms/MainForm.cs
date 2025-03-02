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
            DoctorAddForm dockayitForm = new DoctorAddForm();
            dockayitForm.MdiParent = this;
            GetForm(dockayitForm);
        }

        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OpenForm(new AddPatientForm());
        }


        private void doktorBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorInfoForm docinfoForm = new DoctorInfoForm();
            docinfoForm.MdiParent = this;
            GetForm(docinfoForm);

        }

        private void randevuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doktorKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doktorListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorListForm doclistForm = new DoctorListForm();
            doclistForm.MdiParent = this;
            GetForm(doclistForm);

        }
        private static void GetForm(Form form)
        {
            if (FormUtils.IsFormsOpen(form))
            {
                MessageBox.Show("Form zaten açık.");
            }
            else
            {
                form.Show();
            }
        }

        private void hastaKayıtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddPatientForm addpatientForm = new AddPatientForm();
            addpatientForm.MdiParent = this;
            GetForm(addpatientForm);
        }
        protected override void OnLoad(EventArgs e) // arka plan resmini buradan getirttim formdan sildim
        {
            base.OnLoad(e);

            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient mdiClient)
                {  
                    mdiClient.BackgroundImage = Properties.Resources.bg;  
                }
            }
        }

    }
}