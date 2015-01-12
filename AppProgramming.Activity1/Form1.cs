using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppProgramming.Activity1
{
    public partial class Form1 : Form
    {
        private const string FORMAT_PYRAMID_REPLACE = "V = ( {0:0.00} X {1:0.00}  ) / 3";

        public Form1()
        {
            InitializeComponent();
        }

        private void filterDecimalsOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnPyramidCalculate_Click(object sender, EventArgs e)
        {
            // Get values
            double baseValue = 0d;
            double heightValue = 0d;

            if (!double.TryParse(txtPyramidBase.Text, out baseValue))
            {
                MessageBox.Show("Por favor escribe un valor numérico para la base de la pirámide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtPyramidHeight.Text, out heightValue))
            {
                MessageBox.Show("Por favor escribe un valor numérico para la altura de la pirámide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double volume = (baseValue * heightValue) / 3;
            lbPyramidReplace.Text = string.Format(FORMAT_PYRAMID_REPLACE, baseValue, heightValue);
            lbPyramidResult.Text = string.Format("{0:0.000}", volume);
        }

        private void txtPyramidBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterDecimalsOnly(sender, e);
        }

        private void txtPyramidHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            filterDecimalsOnly(sender, e);
        }

        private void btnPyramidClear_Click(object sender, EventArgs e)
        {
            lbPyramidResult.Text = string.Empty;
            lbPyramidReplace.Text = string.Empty;
            txtPyramidBase.Clear();
            txtPyramidHeight.Clear();
            txtPyramidBase.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
            }
        }

    }
}
