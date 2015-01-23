using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ActividadSplash;

namespace AppProgramming.Activity1
{
    public partial class Form1 : Form
    {
        private bool _formHasErrors
        {
            get
            {
                return this._ControlsWithErrors.Count > 0;
            }
        }

        private IList<Control> _ControlsWithErrors;

        private const string FORMAT_PYRAMID_REPLACE = "V = ( {0:0.00} X {1:0.00}  ) / 3";
        private const string FORMAT_CONE_REPLACE = "V = ( pi X ({0:0.00} ^ 2) X {1:0.00} ) / 3";
        private const string FORMAT_CYLINDER_REPLACE = "V = pi X ({0:0.00} ^ 2) X {1:0.00}";

        public Form1()
        {
            Thread newThread = new Thread(showSplash);
            newThread.Start();
            Thread.Sleep(5000);
            newThread.Abort();

            this._ControlsWithErrors = new List<Control>();
            InitializeComponent();
            this.panelCylinder.Location = this.pyramidPanel.Location;
            this.panelCone.Location = this.pyramidPanel.Location;
        }

        private void showSplash()
        {
            Splash splash = new Splash();
            splash.ShowDialog();
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

        private void validateConeHeight()
        {
            double testValue = 0d;

            Control found = this._ControlsWithErrors.Where(c => c.Name == txtConeHeight.Name).FirstOrDefault();

            if (!double.TryParse(txtConeHeight.Text, out testValue) || testValue == 0)
            {
                if (testValue == 0 && txtConeHeight.Text.Length > 0)
                {
                    errorProvider.SetError(txtConeHeight, "Por favor escribe un valor diferente de cero.");
                }
                else
                {
                    errorProvider.SetError(txtConeHeight, "Por favor escribe un valor numérico.");
                }

                if (null == found)
                {
                    this._ControlsWithErrors.Add(txtConeHeight);
                }
            }
            else
            {
                errorProvider.SetError(txtConeHeight, string.Empty);

                if (null != found)
                {
                    this._ControlsWithErrors.Remove(found);
                }
            }
        }

        private void validateConeRadio()
        {
            double testValue = 0d;

            Control found = this._ControlsWithErrors.Where(c => c.Name == txtConeRadio.Name).FirstOrDefault();

            if (!double.TryParse(txtConeRadio.Text, out testValue) || testValue == 0)
            {
                if (testValue == 0 && txtConeRadio.Text.Length > 0)
                {
                    errorProvider.SetError(txtConeRadio, "Por favor escribe un valor diferente de cero.");
                }
                else
                {
                    errorProvider.SetError(txtConeRadio, "Por favor escribe un valor numérico.");
                }

                if (null == found)
                {
                    this._ControlsWithErrors.Add(txtConeRadio);
                }
            }
            else
            {
                errorProvider.SetError(txtConeRadio, string.Empty);

                if (null != found)
                {
                    this._ControlsWithErrors.Remove(found);
                }
            }
        }

        private void validatePyramidBase()
        {
            double testValue = 0d;

            Control found = this._ControlsWithErrors.Where(c => c.Name == txtPyramidBase.Name).FirstOrDefault();

            // Try to convert the value to zero
            if (!double.TryParse(txtPyramidBase.Text, out testValue) || testValue == 0)
            {
                if (testValue == 0 && txtPyramidBase.Text.Length > 0)
                {
                    errorProvider.SetError(txtPyramidBase, "Por favor escribe un valor diferente de cero.");
                }
                else
                {
                    errorProvider.SetError(txtPyramidBase, "Por favor escribe un valor numérico.");
                }

                if (null == found)
                {
                    this._ControlsWithErrors.Add(txtPyramidBase);
                }
            }
            else
            {
                errorProvider.SetError(txtPyramidBase, string.Empty);

                if (null != found)
                {
                    this._ControlsWithErrors.Remove(found);
                }
            }
        }

        private void validateCylinderHeight()
        {
            double testValue = 0d;

            Control found = this._ControlsWithErrors.Where(c => c.Name == txtCylinderHeight.Name).FirstOrDefault();

            if (!double.TryParse(txtCylinderHeight.Text, out testValue) || testValue == 0)
            {
                if (testValue == 0 && txtCylinderHeight.Text.Length > 0)
                {
                    errorProvider.SetError(txtCylinderHeight, "Por favor escribe un valor diferente de cero.");
                }
                else
                {
                    errorProvider.SetError(txtCylinderHeight, "Por favor escribe un valor numérico.");
                }

                if (null == found)
                {
                    this._ControlsWithErrors.Add(txtCylinderHeight);
                }
            }
            else
            {
                errorProvider.SetError(txtCylinderHeight, string.Empty);

                if (null != found)
                {
                    this._ControlsWithErrors.Remove(found);
                }
            }
        }

        private void validateCylinderRadio()
        {
            double testValue = 0d;

            Control found = this._ControlsWithErrors.Where(c => c.Name == txtCylinderRadio.Name).FirstOrDefault();

            if (!double.TryParse(txtCylinderRadio.Text, out testValue) || testValue == 0)
            {
                if (testValue == 0 && txtCylinderRadio.Text.Length > 0)
                {
                    errorProvider.SetError(txtCylinderRadio, "Por favor escribe un valor diferente de cero.");
                }
                else
                {
                    errorProvider.SetError(txtCylinderRadio, "Por favor escribe un valor numérico.");
                }

                if (null == found)
                {
                    this._ControlsWithErrors.Add(txtCylinderRadio);
                }
            }
            else
            {
                errorProvider.SetError(txtCylinderRadio, string.Empty);

                if (null != found)
                {
                    this._ControlsWithErrors.Remove(found);
                }
            }
        }

        private void validatePyramidHeight()
        {
            double testValue = 0d;

            Control found = this._ControlsWithErrors.Where(c => c.Name == txtPyramidHeight.Name).FirstOrDefault();

            if (!double.TryParse(txtPyramidHeight.Text, out testValue) || testValue == 0)
            {
                if (testValue == 0 && txtPyramidHeight.Text.Length > 0)
                {
                    errorProvider.SetError(txtPyramidHeight, "Por favor escribe un valor diferente de cero.");
                }
                else
                {
                    errorProvider.SetError(txtPyramidHeight, "Por favor escribe un valor numérico.");
                }

                if (null == found)
                {
                    this._ControlsWithErrors.Add(txtPyramidHeight);
                }
            }
            else
            {
                errorProvider.SetError(txtPyramidHeight, string.Empty);

                if (null != found)
                {
                    this._ControlsWithErrors.Remove(found);
                }
            }
        }

        private void btnPyramidCalculate_Click(object sender, EventArgs e)
        {
            validatePyramidForm();

            if (_formHasErrors)
            {
                var first = (TextBox)this._ControlsWithErrors.OrderBy(c => c.TabIndex).First();
                first.Clear();
                first.Focus();
                return;
            }

            // Get values
            double baseValue = 0d;
            double heightValue = 0d;

            double.TryParse(txtPyramidBase.Text, out baseValue);
            double.TryParse(txtPyramidHeight.Text, out heightValue);

            double volume = (baseValue * heightValue) / 3;
            lbPyramidReplace.Text = string.Format(FORMAT_PYRAMID_REPLACE, baseValue, heightValue);
            lbPyramidResult.Text = string.Format("{0:0.000}", volume);

            btnPrint.Enabled = true;
        }

        private void txtPyramidBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPyramidHeight.Focus();
                return;
            }

            filterDecimalsOnly(sender, e);
        }

        private void txtPyramidHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnPyramidCalculate.Focus();
                return;
            }

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
                    Application.Exit();
                    break;
            }
        }

        private void txtPyramidHeight_Leave(object sender, EventArgs e)
        {
            if (pyramidPanel.Visible == true)
            {
                validatePyramidHeight();
            }
        }

        private void txtPyramidBase_Leave(object sender, EventArgs e)
        {
            if (pyramidPanel.Visible == true)
            {
                validatePyramidBase();
            }
        }

        private void txtCylinderHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCylinderCalculate.Focus();
                return;
            }

            filterDecimalsOnly(sender, e);
        }

        private void btnCylinderCalculate_Click(object sender, EventArgs e)
        {
            validateCylinderForm();

            if (_formHasErrors)
            {
                var first = (TextBox)this._ControlsWithErrors.OrderBy(c => c.TabIndex).First();
                first.Clear();
                first.Focus();
                return;
            }

            // Get values
            double heightValue = 0d;
            double radioValue = 0d;

            double.TryParse(txtCylinderHeight.Text, out heightValue);
            double.TryParse(txtCylinderRadio.Text, out radioValue);

            double volume = System.Math.PI * (Math.Pow(radioValue, 2)) * heightValue;
            lbCylinderReplace.Text = string.Format(FORMAT_CYLINDER_REPLACE, radioValue, heightValue);
            lbCylinderResult.Text = string.Format("{0:0.000}", volume);

            btnPrint.Enabled = true;
        }

        private void txtCylinderRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCylinderHeight.Focus();
                return;
            }

            filterDecimalsOnly(sender, e);
        }

        private void txtCylinderHeight_Leave(object sender, EventArgs e)
        {
            if (panelCylinder.Visible == true)
            {
                validateCylinderHeight();
            }
        }

        private void txtCylinderRadio_Leave(object sender, EventArgs e)
        {
            if (panelCylinder.Visible == true)
            {
                validateCylinderRadio();
            }
        }

        private void pirámideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show print button and disabled it
            btnPrint.Show();
            btnPrint.Enabled = false;

            // Clear error information
            errorProvider.Clear();
            this._ControlsWithErrors.Clear();

            pyramidPanel.Visible = true;
            panelCylinder.Visible = false;
            panelCone.Visible = false;
        }

        private void btnCylinderClear_Click(object sender, EventArgs e)
        {
            // Show print button and disabled it
            btnPrint.Show();
            btnPrint.Enabled = false;

            // Clear error information
            errorProvider.Clear();
            this._ControlsWithErrors.Clear();

            // Clear fields
            txtCylinderHeight.Clear();
            txtCylinderRadio.Clear();
            lbCylinderReplace.Text = string.Empty;
            lbCylinderResult.Text = string.Empty;
        }

        private void cilindroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show print button and disabled it
            btnPrint.Show();
            btnPrint.Enabled = false;

            // Clear error information
            errorProvider.Clear();
            this._ControlsWithErrors.Clear();

            pyramidPanel.Visible = false;
            panelCylinder.Visible = true;
            panelCone.Visible = false;
        }

        private void conoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show print button and disabled it
            btnPrint.Show();
            btnPrint.Enabled = false;

            // Clear error information
            errorProvider.Clear();
            this._ControlsWithErrors.Clear();

            pyramidPanel.Visible = false;
            panelCylinder.Visible = false;
            panelCone.Visible = true;
        }

        private void btnConeClear_Click(object sender, EventArgs e)
        {
            txtConeRadio.Clear();
            txtConeHeight.Clear();
            lbConeReplace.Text = string.Empty;
            lbConeResult.Text = string.Empty;
            txtConeRadio.Focus();
        }

        private void validateCylinderForm()
        {
            errorProvider.Clear();

            validateCylinderRadio();
            validateCylinderHeight();
        }

        private void validateConeForm()
        {
            errorProvider.Clear();

            validateConeRadio();
            validateConeHeight();
        }

        private void validatePyramidForm()
        {
            errorProvider.Clear();

            validatePyramidBase();
            validatePyramidHeight();
        }

        private void btnConeCalculate_Click(object sender, EventArgs e)
        {
            validateConeForm();

            if (_formHasErrors)
            {
                var first = (TextBox)this._ControlsWithErrors.OrderBy(c => c.TabIndex).First();
                first.Clear();
                first.Focus();
                return;
            }

            // Get values
            double heightValue = 0d;
            double radioValue = 0d;

            double.TryParse(txtConeHeight.Text, out heightValue);
            double.TryParse(txtConeRadio.Text, out radioValue);

            double volume = (System.Math.PI * (Math.Pow(radioValue, 2)) * heightValue) / 3d;
            lbConeReplace.Text = string.Format(FORMAT_CONE_REPLACE, radioValue, heightValue);
            lbConeResult.Text = string.Format("{0:0.000}", volume);

            btnPrint.Enabled = true;
        }

        private void txtConeRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtConeHeight.Focus();
                return;
            }

            filterDecimalsOnly(sender, e);
        }

        private void txtConeHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConeCalculate.Focus();
                return;
            }

            filterDecimalsOnly(sender, e);
        }

        private void txtConeRadio_Leave(object sender, EventArgs e)
        {
            if (panelCone.Visible == true)
            {
                validateConeRadio();
            }
        }

        private void txtConeHeight_Leave(object sender, EventArgs e)
        {
            if (panelCone.Visible == true)
            {
                validateConeHeight();
            }
        }

        private void printCylinderReport(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Some fonts
            Font fontCambriaBig = new Font("Cambria", 19, FontStyle.Bold);
            Font tipoletCam = new Font("Cambria", 10);

            // Rectángulos y líneas
            Pen delgadoAzul = new Pen(Color.Blue, 1);
            Pen lapizNegro = new Pen(Color.Black, 1);
            Pen gruesoNegro = new Pen(Color.Black, 2);
            Pen gruesoVerde = new Pen(Color.DarkGreen, 2);

            // Container
            float containerX = 100;
            float containerY = 35;

            e.Graphics.DrawRectangle(gruesoNegro, containerX, containerY, 550, 285);

            // Render the title, date and the description process leyend
            e.Graphics.DrawString("CÁLCULO DE VOLUMEN DE UN CILINDRO", fontCambriaBig, Brushes.Black, containerX + 45, containerY + 5);
            e.Graphics.DrawString(string.Format("Fecha y hora: {0}", txtDate.Text), tipoletCam, Brushes.Black, containerX + 165, containerY + 35);
            e.Graphics.DrawString(string.Format("Descripción del cálculo:"), new Font("Cambria", 16, FontStyle.Bold), Brushes.Black, containerX + 182, containerY + 55);

            // Get the image resource and resize it to 142 x 200
            var image = Resources.cilidro001;
            var thumb = image.GetThumbnailImage(142, 200, null, IntPtr.Zero);

            // Render the image
            e.Graphics.DrawImage(thumb, new Point(110, 100));

            // Render description items
            e.Graphics.DrawRectangle(lapizNegro, containerX + 185, containerY + 85, 350, 50);
            e.Graphics.DrawString(lbCylinderFormula.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Black, containerX + 187, containerY + 98);
            e.Graphics.DrawString("Fórmula", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, containerX + 475, containerY + 120);

            e.Graphics.DrawRectangle(delgadoAzul, containerX + 185, containerY + 145, 350, 50);
            e.Graphics.DrawString(lbCylinderReplace.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Blue, containerX + 187, containerY + 160);
            e.Graphics.DrawString("Sustitución", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, containerX + 455, containerY + 178);

            e.Graphics.DrawRectangle(gruesoVerde, containerX + 185, containerY + 205, 350, 50);
            e.Graphics.DrawString(string.Format("V = {0:0.00}", lbCylinderResult.Text), new Font("Arial", 20, FontStyle.Italic), Brushes.DarkGreen, containerX + 187, containerY + 215);
            e.Graphics.DrawString("RESULTADO", new Font("Arial", 10, FontStyle.Bold), Brushes.DarkGreen, containerX + 445, containerY + 238);

            e.Graphics.DrawString("Desarrollado por: Iván Alejandro Ocampo", new Font("Cambria", 10, FontStyle.Italic), Brushes.Black, 385, 300);
        }

        private void printConeReport(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Some fonts
            Font fontCambriaBig = new Font("Cambria", 19, FontStyle.Bold);
            Font tipoletCam = new Font("Cambria", 10);

            // Rectángulos y líneas
            Pen delgadoAzul = new Pen(Color.Blue, 1);
            Pen lapizNegro = new Pen(Color.Black, 1);
            Pen gruesoNegro = new Pen(Color.Black, 2);
            Pen gruesoVerde = new Pen(Color.DarkGreen, 2);

            // Container
            float containerX = 100;
            float containerY = 35;

            e.Graphics.DrawRectangle(gruesoNegro, containerX, containerY, 550, 285);

            // Render the title, date and the description process leyend
            e.Graphics.DrawString("CÁLCULO DE VOLUMEN DE UN CONO", fontCambriaBig, Brushes.Black, containerX + 50, containerY + 5);
            e.Graphics.DrawString(string.Format("Fecha y hora: {0}", txtDate.Text), tipoletCam, Brushes.Black, containerX + 165, containerY + 35);
            e.Graphics.DrawString(string.Format("Descripción del cálculo:"), new Font("Cambria", 16, FontStyle.Bold), Brushes.Black, containerX + 182, containerY + 55);

            // Get the image resource and resize it to 142 x 200
            var image = Resources.cono001;
            var thumb = image.GetThumbnailImage(142, 200, null, IntPtr.Zero);

            // Render the image
            e.Graphics.DrawImage(thumb, new Point(110, 100));

            // Render description items
            e.Graphics.DrawRectangle(lapizNegro, containerX + 185, containerY + 85, 350, 50);
            e.Graphics.DrawString(lbConeFormula.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Black, containerX + 187, containerY + 98);
            e.Graphics.DrawString("Fórmula", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, containerX + 475, containerY + 120);

            e.Graphics.DrawRectangle(delgadoAzul, containerX + 185, containerY + 145, 350, 50);
            e.Graphics.DrawString(lbConeReplace.Text, new Font("Arial", 12, FontStyle.Italic), Brushes.Blue, containerX + 187, containerY + 160);
            e.Graphics.DrawString("Sustitución", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, containerX + 455, containerY + 178);

            e.Graphics.DrawRectangle(gruesoVerde, containerX + 185, containerY + 205, 350, 50);
            e.Graphics.DrawString(string.Format("V = {0:0.00}", lbConeResult.Text), new Font("Arial", 20, FontStyle.Italic), Brushes.DarkGreen, containerX + 187, containerY + 215);
            e.Graphics.DrawString("RESULTADO", new Font("Arial", 10, FontStyle.Bold), Brushes.DarkGreen, containerX + 445, containerY + 238);

            e.Graphics.DrawString("Desarrollado por: Iván Alejandro Ocampo", new Font("Cambria", 10, FontStyle.Italic), Brushes.Black, 385, 300);
        }

        private void printPyramidReport(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Some fonts
            Font fontCambriaBig = new Font("Cambria", 19, FontStyle.Bold);
            Font tipoletCam = new Font("Cambria", 10);

            // Some stuff
            Pen delgadoAzul = new Pen(Color.Blue, 1);
            Pen lapizNegro = new Pen(Color.Black, 1);
            Pen gruesoNegro = new Pen(Color.Black, 2);
            Pen gruesoVerde = new Pen(Color.DarkGreen, 2);

            // Container
            float containerX = 100;
            float containerY = 35;

            // Render the main container
            e.Graphics.DrawRectangle(gruesoNegro, containerX, containerY, 550, 285);

            // Render the title, date and the description process leyend
            e.Graphics.DrawString("CÁLCULO DE VOLUMEN DE UNA PIRÁMIDE", fontCambriaBig, Brushes.Black, containerX + 10, containerY + 5);
            e.Graphics.DrawString(string.Format("Fecha y hora: {0}", txtDate.Text), tipoletCam, Brushes.Black, containerX + 165, containerY + 35);
            e.Graphics.DrawString(string.Format("Descripción del cálculo:"), new Font("Cambria", 16, FontStyle.Bold), Brushes.Black, containerX + 182, containerY + 55);

            // Get the image resource and resize it to 142 x 200
            var image = Resources.cono001;
            var thumb = image.GetThumbnailImage(142, 200, null, IntPtr.Zero);
            e.Graphics.DrawImage(thumb, new Point(110, 100));

            // Render the description process items
            e.Graphics.DrawRectangle(lapizNegro, containerX + 185, containerY + 85, 350, 50);
            e.Graphics.DrawString(lbPyramidFormula.Text, new Font("Arial", 14, FontStyle.Italic), Brushes.Black, containerX + 187, containerY + 98);
            e.Graphics.DrawString("Fórmula", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, containerX + 475, containerY + 120);

            e.Graphics.DrawRectangle(delgadoAzul, containerX + 185, containerY + 145, 350, 50);
            e.Graphics.DrawString(lbPyramidReplace.Text, new Font("Arial", 14, FontStyle.Italic), Brushes.Blue, containerX + 187, containerY + 160);
            e.Graphics.DrawString("Sustitución", new Font("Arial", 10, FontStyle.Bold), Brushes.Blue, containerX + 455, containerY + 178);

            e.Graphics.DrawRectangle(gruesoVerde, containerX + 185, containerY + 205, 350, 50);
            e.Graphics.DrawString(string.Format("V = {0:0.00}", lbPyramidResult.Text), new Font("Arial", 20, FontStyle.Italic), Brushes.DarkGreen, containerX + 187, containerY + 215);
            e.Graphics.DrawString("RESULTADO", new Font("Arial", 10, FontStyle.Bold), Brushes.DarkGreen, containerX + 445, containerY + 238);

            e.Graphics.DrawString("Desarrollado por: Iván Alejandro Ocampo", new Font("Cambria", 10, FontStyle.Italic), Brushes.Black, 385, 300);
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (pyramidPanel.Visible == true)
            {
                printPyramidReport(sender, e);
                return;
            }

            if (panelCone.Visible == true)
            {
                printConeReport(sender, e);
                return;
            }

            if (panelCylinder.Visible == true)
            {
                printCylinderReport(sender, e);
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (pyramidPanel.Visible == true)
            {
                validatePyramidForm();
            }
            else if (panelCone.Visible == true)
            {
                validateConeForm();
            }
            else if (panelCylinder.Visible == true)
            {
                validateCylinderForm();
            }

            if (_formHasErrors)
            {
                var first = (TextBox)this._ControlsWithErrors.OrderBy(c => c.TabIndex).First();
                first.Clear();
                first.Focus();
                return;
            }

            printDocument.Print();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void txtPyramidBase_TextChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
        }

        private void txtPyramidHeight_TextChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
        }

        private void txtCylinderRadio_TextChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
        }

        private void txtCylinderHeight_TextChanged(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
        }
    }
}
