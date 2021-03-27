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
    public partial class FMaestro : Form
    {
        private decimal TempResult = 0;

        public FMaestro()
        {
            InitializeComponent();

            cbxTipo.Items.AddRange(TipoUtil.GetTiposAsString());
            cbxTipo.SelectedIndex = 0;

            UpdateSubTipos();
            CheckHumedadActivated();
        }

        private void UpdateSubTipos(bool clearItems = true)
        {
            if (clearItems)
                cbxSubTipo.Items.Clear();

            ETipo selectedTipo = TipoUtil.GetTipoFromString(cbxTipo.SelectedItem.ToString());
            List<ESubTipo> subTiposOfTipo = TipoUtil.GetSubTiposOfTipo(selectedTipo);

            cbxSubTipo.Items.AddRange(TipoUtil.GetSubTiposAsString(subTiposOfTipo));
            cbxSubTipo.SelectedIndex = 0;
        }

        private void CheckHumedadActivated()
        {
            numHumedad.Enabled = chkActivate.Checked;
        }

        private decimal Calculate(bool displayResult = true)
        {
            float multiplier = .0f;
            switch (TipoUtil.GetSubTipoFromString(cbxSubTipo.SelectedItem.ToString()))
            {
                case ESubTipo.Tetraedo: 
                    multiplier = .9f;
                    break;
                case ESubTipo.Piramidal:
                    multiplier = 1.1f;
                    break;
                case ESubTipo.Nuclear:
                    multiplier = 1.01f;
                    break;
                case ESubTipo.Bipolar:
                    multiplier = 0.85f;
                    break;
            }

            decimal result = numGramaje.Value * Convert.ToDecimal(multiplier);

            if(displayResult)
                labResultado.Text = "Resultado: " + result.ToString();

            TempResult = result;

            return result;
        }

        private void ClearResult()
        {
            labResultado.Text = "Resultado";
            SetBtnDetalleEnabled(false);
        }

        private void OpenDetalle()
        {
            ETipo selectedTipo = TipoUtil.GetTipoFromString(cbxTipo.SelectedItem.ToString());

            Detail detail = new Detail(
                selectedTipo, 
                Convert.ToInt32(numHumedad.Value), 
                chkActivate.Checked,
                numGramaje.Value,
                txtOrigen.Text,
                TempResult
            );

            FDetalle detalleForm = new FDetalle(detail);
            detalleForm.Show();
        }

        private void SetBtnDetalleEnabled(bool enabled)
        {
            if (!enabled)
            {
                btnDetalle.Enabled = enabled;
                return;
            }

            if (!string.IsNullOrEmpty(txtOrigen.Text))
            {
                btnDetalle.Enabled = enabled;
            }
            else
            {
                btnDetalle.Enabled = false;
            }
        }

        // EVENTS

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubTipos();
            SetBtnDetalleEnabled(false);
        }

        private void chkActivate_CheckedChanged(object sender, EventArgs e)
        {
            CheckHumedadActivated();
            SetBtnDetalleEnabled(false);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculate();
            SetBtnDetalleEnabled(true);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            OpenDetalle();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearResult();
        }
    }
}
