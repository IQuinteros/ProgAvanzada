using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCertamen1.Models;

namespace TestCertamen1
{
    public partial class FReport : Form
    {
        Detail detail;

        protected string Report;

        public FReport(Detail detail)
        {
            InitializeComponent();
            this.detail = detail;

            DisplayReport();
        }

        private void DisplayReport()
        {
            string report = "REPORTE\n---------------\n";

            report += "Tipo: " + detail.SelectedTipo.ToString() + "\n";
            report += "SubTipo: " + detail.SelectedSubTipo.ToString() + "\n";
            report += "Gramaje: " + detail.Gramaje.ToString() + "\n";
            report += "Origen: " + detail.Origen + "\n";
            if (detail.UseHumedad)
            {
                report += "Humedad: " + detail.Humedad.ToString() + "\n";

                report += "Fragmentación: " + CalculateFragmentacion().ToString() + "\n";
            }
            report += "Resultado: " + detail.Result + "\n";

            report += "Energía: " + detail.Energia + "\n";
            report += "Catalizador: " + detail.Catalizador + "\n";

            Report = report;

            txtReport.Text = Report;
        }

        private decimal CalculateFragmentacion()
        {
            return detail.Gramaje / detail.Humedad;
        }

        private async void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text file(*.txt)|*.txt";
            saveFileDialog.FilterIndex = 1;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(saveFileDialog.FileName);
                await stream.WriteAsync(Report);
                stream.Close();

                MessageBox.Show("Reporte guardado");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}
