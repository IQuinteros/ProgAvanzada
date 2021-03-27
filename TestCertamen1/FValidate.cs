using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCertamen1
{
    public partial class FValidate : Form
    {
        protected const string PASSWORD = "1919ABC";

        public FValidate()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(PASSWORD))
            {
                FMaestro maestroForm = new FMaestro();

                this.Hide();
                maestroForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.");
            }
        }
    }
}
