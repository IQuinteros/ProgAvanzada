using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCertamen1.Models;
using TestCertamen1.Utils;

namespace TestCertamen1
{
    public partial class FDetalle : Form
    {
        private Detail detail;

        public FDetalle(Detail detail)
        {
            InitializeComponent();

            this.detail = detail;

            CheckEnergyLimits(detail.SelectedTipo);
        }

        private void CheckEnergyLimits(ETipo tipo)
        {
            if(tipo == ETipo.Alfa1)
            {
                numEnergia.Minimum = 0;
                numEnergia.Maximum = 100;
            }
            else
            {
                numEnergia.Minimum = 0;
                numEnergia.Maximum = 50;
            }
        }

        private void chkAg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAg.Checked)
            {
                chkCu.Checked = false;
                chkBr.Checked = false;
            }
        }

        private void chkCu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCu.Checked)
            {
                chkAg.Checked = false;
                chkBr.Checked = false;
            }
        }

        private void chkBr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBr.Checked)
            {
                chkAg.Checked = false;
                chkCu.Checked = false;
            }
        }

        private string GetSelectedCatalizador()
        {
            if (chkAg.Checked)
                return "Ag";
            if (chkBr.Checked)
                return "Br";
            if (chkCu.Checked)
                return "Cu";

            return "No seleccionado";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            detail.Energia = Convert.ToInt32(numEnergia.Value);
            detail.Catalizador = GetSelectedCatalizador();

            FReport reportForm = new FReport(detail);
            reportForm.Show();
        }
    }
}
