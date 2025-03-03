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
            PlayBackgroundMusic();
        }
        private void PlayBackgroundMusic()
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\ömer\\source\\repos\\HospitalAppointment.UI\\HospitalAppointment.UI\\Resources\\Relaxing Sleep Music + Insomnia - Stress Relief, Relaxing Music, Deep Sleeping Music (mp3cut.net).mp3"; // MP3 dosyanızın yolu
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.settings.volume = 100;
            axWindowsMediaPlayer1.Visible = false;
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
            PatientList plistForm = new PatientList();
            plistForm.MdiParent = this;
            GetForm(plistForm);
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

        private void hastaİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientCountForm countpatientForm = new PatientCountForm();
            countpatientForm.MdiParent = this;
            GetForm(countpatientForm);
        }

        private void randevuİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorPatientsCountForm dcountpatientForm = new DoctorPatientsCountForm();
            dcountpatientForm.MdiParent = this;
            GetForm(dcountpatientForm);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void yönlendirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorOriention doctororiention = new DoctorOriention();
            doctororiention.MdiParent = this;
            GetForm(doctororiention);
        }

        private void ilaçVeMedikalÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.MdiParent = this;
            GetForm(medicineForm);
        }
    }
}