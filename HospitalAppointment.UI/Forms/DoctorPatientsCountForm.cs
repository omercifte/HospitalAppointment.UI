using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointment.DataAccess.Abstractions;
using HospitalAppointment.DataAccess.Context;
using HospitalAppointment.DataAccess.Repositories;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace HospitalAppointment.UI.Forms
{
    public partial class DoctorPatientsCountForm : Form
    {
        private readonly AppDbContext _context;
        public DoctorPatientsCountForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void DoctorPatientsCountForm_Load(object sender, EventArgs e)
        {
            DoctorPatientsCount();
        }

        private void DoctorPatientsCount()
        {
            var branchCounts = _context.Appointments
                .Include(x => x.Doctor)
                .Where(x => x.Doctor != null && x.Doctor.Branch != null)
                .GroupBy(x => x.Doctor.Id)
                .Select(group => new
                {
                    doctorname = group.FirstOrDefault().Doctor.FullName,
                    AppointmentCount = group.Count()
                })
                .ToList();

            lstCount.Items.Clear();
            foreach (var item in branchCounts)
            {
                lstCount.Items.Add($"{item.doctorname}: {item.AppointmentCount} randevu");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (lstCount.Items.Count == 0)
            {
                MessageBox.Show("Liste boş, dışa aktarılacak veri bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Dosyası|*.pdf",
                Title = "PDF Dosyası Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // pdf olusturulan kısım bura
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    doc.Open();
                    doc.Add(new Paragraph("Branslara Göre Randevu Sayilari"));
                    doc.Add(new Paragraph(" "));

                    // listbox içindeki verileri pdf e aktarıyor
                    foreach (var item in lstCount.Items)
                    {
                        doc.Add(new Paragraph(item.ToString()));
                    }

                    doc.Close();
                    MessageBox.Show("PDF başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF oluşturulurken hata meydana geldi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (lstCount.Items.Count == 0)
            {
                MessageBox.Show("Liste boş, dışa aktarılacak veri bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Dosyası|*.xlsx",
                Title = "Excel Dosyası Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //lisans olmadıgı için bu lazım
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        var worksheet = excelPackage.Workbook.Worksheets.Add("Randevu Sayıları");

                        // Başlık ekleme
                        worksheet.Cells[1, 1].Value = "Branslara Göre Randevu Sayilari";

                        // ListBox verilerini Excel'e aktarma
                        for (int i = 0; i < lstCount.Items.Count; i++)
                        {
                            worksheet.Cells[i + 2, 1].Value = lstCount.Items[i].ToString();
                        }

                        // Dosyayı kaydetme
                        File.WriteAllBytes(saveFileDialog.FileName, excelPackage.GetAsByteArray());
                        MessageBox.Show("Excel dosyası başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel oluşturulurken hata meydana geldi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
