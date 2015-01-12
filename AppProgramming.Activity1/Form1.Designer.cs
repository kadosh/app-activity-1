namespace AppProgramming.Activity1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPyramidCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPyramidHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPyramidBase = new System.Windows.Forms.TextBox();
            this.btnPyramidClear = new System.Windows.Forms.Button();
            this.picPyramid = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPyramidReplace = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPyramidResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPyramid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "VOLUMEN DE UNA PIRÁMIDE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPyramidCalculate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPyramidHeight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPyramidBase);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos para el cálculo";
            // 
            // btnPyramidCalculate
            // 
            this.btnPyramidCalculate.Location = new System.Drawing.Point(80, 114);
            this.btnPyramidCalculate.Name = "btnPyramidCalculate";
            this.btnPyramidCalculate.Size = new System.Drawing.Size(139, 23);
            this.btnPyramidCalculate.TabIndex = 3;
            this.btnPyramidCalculate.Text = "CALCULAR";
            this.btnPyramidCalculate.UseVisualStyleBackColor = true;
            this.btnPyramidCalculate.Click += new System.EventHandler(this.btnPyramidCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altura";
            // 
            // txtPyramidHeight
            // 
            this.txtPyramidHeight.Location = new System.Drawing.Point(80, 67);
            this.txtPyramidHeight.Name = "txtPyramidHeight";
            this.txtPyramidHeight.Size = new System.Drawing.Size(139, 20);
            this.txtPyramidHeight.TabIndex = 2;
            this.txtPyramidHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPyramidHeight_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base";
            // 
            // txtPyramidBase
            // 
            this.txtPyramidBase.Location = new System.Drawing.Point(80, 30);
            this.txtPyramidBase.Name = "txtPyramidBase";
            this.txtPyramidBase.Size = new System.Drawing.Size(139, 20);
            this.txtPyramidBase.TabIndex = 1;
            this.txtPyramidBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPyramidBase_KeyPress);
            // 
            // btnPyramidClear
            // 
            this.btnPyramidClear.Location = new System.Drawing.Point(171, 372);
            this.btnPyramidClear.Name = "btnPyramidClear";
            this.btnPyramidClear.Size = new System.Drawing.Size(75, 23);
            this.btnPyramidClear.TabIndex = 5;
            this.btnPyramidClear.Text = "Limpiar";
            this.btnPyramidClear.UseVisualStyleBackColor = true;
            this.btnPyramidClear.Click += new System.EventHandler(this.btnPyramidClear_Click);
            // 
            // picPyramid
            // 
            this.picPyramid.Image = global::AppProgramming.Activity1.Resources._0_15_0;
            this.picPyramid.Location = new System.Drawing.Point(281, 71);
            this.picPyramid.Name = "picPyramid";
            this.picPyramid.Size = new System.Drawing.Size(127, 163);
            this.picPyramid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPyramid.TabIndex = 2;
            this.picPyramid.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPyramidReplace, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 240);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.95699F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.04301F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "SUSTITUCIÓN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "FÓRMULA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 68);
            this.label7.TabIndex = 3;
            this.label7.Text = "V =  ( base X altura  ) / 3\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPyramidReplace
            // 
            this.lbPyramidReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPyramidReplace.AutoSize = true;
            this.lbPyramidReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPyramidReplace.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbPyramidReplace.Location = new System.Drawing.Point(202, 30);
            this.lbPyramidReplace.Name = "lbPyramidReplace";
            this.lbPyramidReplace.Size = new System.Drawing.Size(189, 68);
            this.lbPyramidReplace.TabIndex = 4;
            this.lbPyramidReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Resultado:";
            // 
            // lbPyramidResult
            // 
            this.lbPyramidResult.AutoSize = true;
            this.lbPyramidResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPyramidResult.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbPyramidResult.Location = new System.Drawing.Point(212, 349);
            this.lbPyramidResult.Name = "lbPyramidResult";
            this.lbPyramidResult.Size = new System.Drawing.Size(40, 17);
            this.lbPyramidResult.TabIndex = 6;
            this.lbPyramidResult.Text = "0.00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(420, 414);
            this.Controls.Add(this.lbPyramidResult);
            this.Controls.Add(this.btnPyramidClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picPyramid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Programming";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPyramid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picPyramid;
        private System.Windows.Forms.Button btnPyramidClear;
        private System.Windows.Forms.Button btnPyramidCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPyramidHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPyramidBase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPyramidReplace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPyramidResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

