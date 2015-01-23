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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPyramidCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPyramidHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPyramidBase = new System.Windows.Forms.TextBox();
            this.btnPyramidClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPyramidFormula = new System.Windows.Forms.Label();
            this.lbPyramidReplace = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPyramidResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirámideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cilindroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pyramidPanel = new System.Windows.Forms.Panel();
            this.picPyramid = new System.Windows.Forms.PictureBox();
            this.panelCylinder = new System.Windows.Forms.Panel();
            this.btnCylinderClear = new System.Windows.Forms.Button();
            this.lbCylinderResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCylinderRadio = new System.Windows.Forms.TextBox();
            this.btnCylinderCalculate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCylinderHeight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbCylinderFormula = new System.Windows.Forms.Label();
            this.lbCylinderReplace = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelCone = new System.Windows.Forms.Panel();
            this.btnConeClear = new System.Windows.Forms.Button();
            this.lbConeResult = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtConeRadio = new System.Windows.Forms.TextBox();
            this.btnConeCalculate = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtConeHeight = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbConeFormula = new System.Windows.Forms.Label();
            this.lbConeReplace = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pyramidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPyramid)).BeginInit();
            this.panelCylinder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelCone.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(15, 12);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 44);
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
            this.txtPyramidHeight.TextChanged += new System.EventHandler(this.txtPyramidHeight_TextChanged);
            this.txtPyramidHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPyramidHeight_KeyPress);
            this.txtPyramidHeight.Leave += new System.EventHandler(this.txtPyramidHeight_Leave);
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
            this.txtPyramidBase.TextChanged += new System.EventHandler(this.txtPyramidBase_TextChanged);
            this.txtPyramidBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPyramidBase_KeyPress);
            this.txtPyramidBase.Leave += new System.EventHandler(this.txtPyramidBase_Leave);
            // 
            // btnPyramidClear
            // 
            this.btnPyramidClear.Location = new System.Drawing.Point(172, 351);
            this.btnPyramidClear.Name = "btnPyramidClear";
            this.btnPyramidClear.Size = new System.Drawing.Size(75, 23);
            this.btnPyramidClear.TabIndex = 5;
            this.btnPyramidClear.Text = "Limpiar";
            this.btnPyramidClear.UseVisualStyleBackColor = true;
            this.btnPyramidClear.Click += new System.EventHandler(this.btnPyramidClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbPyramidFormula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPyramidReplace, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 219);
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
            // lbPyramidFormula
            // 
            this.lbPyramidFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPyramidFormula.AutoSize = true;
            this.lbPyramidFormula.Location = new System.Drawing.Point(5, 30);
            this.lbPyramidFormula.Name = "lbPyramidFormula";
            this.lbPyramidFormula.Size = new System.Drawing.Size(189, 68);
            this.lbPyramidFormula.TabIndex = 3;
            this.lbPyramidFormula.Text = "V =  ( base X altura  ) / 3\r\n";
            this.lbPyramidFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label6.Location = new System.Drawing.Point(129, 328);
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
            this.lbPyramidResult.Location = new System.Drawing.Point(211, 328);
            this.lbPyramidResult.Name = "lbPyramidResult";
            this.lbPyramidResult.Size = new System.Drawing.Size(40, 17);
            this.lbPyramidResult.TabIndex = 6;
            this.lbPyramidResult.Text = "0.00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figuraToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figuraToolStripMenuItem
            // 
            this.figuraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pirámideToolStripMenuItem,
            this.cilindroToolStripMenuItem,
            this.conoToolStripMenuItem});
            this.figuraToolStripMenuItem.Name = "figuraToolStripMenuItem";
            this.figuraToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.figuraToolStripMenuItem.Text = "Figura";
            // 
            // pirámideToolStripMenuItem
            // 
            this.pirámideToolStripMenuItem.Name = "pirámideToolStripMenuItem";
            this.pirámideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pirámideToolStripMenuItem.Text = "Pirámide";
            this.pirámideToolStripMenuItem.Click += new System.EventHandler(this.pirámideToolStripMenuItem_Click);
            // 
            // cilindroToolStripMenuItem
            // 
            this.cilindroToolStripMenuItem.Name = "cilindroToolStripMenuItem";
            this.cilindroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cilindroToolStripMenuItem.Text = "Cilindro";
            this.cilindroToolStripMenuItem.Click += new System.EventHandler(this.cilindroToolStripMenuItem_Click);
            // 
            // conoToolStripMenuItem
            // 
            this.conoToolStripMenuItem.Name = "conoToolStripMenuItem";
            this.conoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conoToolStripMenuItem.Text = "Cono";
            this.conoToolStripMenuItem.Click += new System.EventHandler(this.conoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // pyramidPanel
            // 
            this.pyramidPanel.Controls.Add(this.label1);
            this.pyramidPanel.Controls.Add(this.lbPyramidResult);
            this.pyramidPanel.Controls.Add(this.groupBox1);
            this.pyramidPanel.Controls.Add(this.btnPyramidClear);
            this.pyramidPanel.Controls.Add(this.picPyramid);
            this.pyramidPanel.Controls.Add(this.label6);
            this.pyramidPanel.Controls.Add(this.tableLayoutPanel1);
            this.pyramidPanel.Location = new System.Drawing.Point(0, 27);
            this.pyramidPanel.Name = "pyramidPanel";
            this.pyramidPanel.Size = new System.Drawing.Size(419, 388);
            this.pyramidPanel.TabIndex = 8;
            this.pyramidPanel.Visible = false;
            // 
            // picPyramid
            // 
            this.picPyramid.Image = global::AppProgramming.Activity1.Resources.pyramid;
            this.picPyramid.Location = new System.Drawing.Point(280, 50);
            this.picPyramid.Name = "picPyramid";
            this.picPyramid.Size = new System.Drawing.Size(127, 163);
            this.picPyramid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPyramid.TabIndex = 2;
            this.picPyramid.TabStop = false;
            // 
            // panelCylinder
            // 
            this.panelCylinder.Controls.Add(this.btnCylinderClear);
            this.panelCylinder.Controls.Add(this.lbCylinderResult);
            this.panelCylinder.Controls.Add(this.groupBox2);
            this.panelCylinder.Controls.Add(this.pictureBox1);
            this.panelCylinder.Controls.Add(this.label12);
            this.panelCylinder.Controls.Add(this.tableLayoutPanel2);
            this.panelCylinder.Controls.Add(this.label8);
            this.panelCylinder.Location = new System.Drawing.Point(425, 27);
            this.panelCylinder.Name = "panelCylinder";
            this.panelCylinder.Size = new System.Drawing.Size(421, 388);
            this.panelCylinder.TabIndex = 9;
            this.panelCylinder.Visible = false;
            // 
            // btnCylinderClear
            // 
            this.btnCylinderClear.Location = new System.Drawing.Point(178, 351);
            this.btnCylinderClear.Name = "btnCylinderClear";
            this.btnCylinderClear.Size = new System.Drawing.Size(75, 23);
            this.btnCylinderClear.TabIndex = 12;
            this.btnCylinderClear.Text = "Limpiar";
            this.btnCylinderClear.UseVisualStyleBackColor = true;
            this.btnCylinderClear.Click += new System.EventHandler(this.btnCylinderClear_Click);
            // 
            // lbCylinderResult
            // 
            this.lbCylinderResult.AutoSize = true;
            this.lbCylinderResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCylinderResult.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbCylinderResult.Location = new System.Drawing.Point(191, 328);
            this.lbCylinderResult.Name = "lbCylinderResult";
            this.lbCylinderResult.Size = new System.Drawing.Size(40, 17);
            this.lbCylinderResult.TabIndex = 11;
            this.lbCylinderResult.Text = "0.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCylinderRadio);
            this.groupBox2.Controls.Add(this.btnCylinderCalculate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCylinderHeight);
            this.groupBox2.Location = new System.Drawing.Point(12, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 169);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos para el cálculo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Radio";
            // 
            // txtCylinderRadio
            // 
            this.txtCylinderRadio.Location = new System.Drawing.Point(80, 28);
            this.txtCylinderRadio.Name = "txtCylinderRadio";
            this.txtCylinderRadio.Size = new System.Drawing.Size(139, 20);
            this.txtCylinderRadio.TabIndex = 1;
            this.txtCylinderRadio.TextChanged += new System.EventHandler(this.txtCylinderRadio_TextChanged);
            this.txtCylinderRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCylinderRadio_KeyPress);
            this.txtCylinderRadio.Leave += new System.EventHandler(this.txtCylinderRadio_Leave);
            // 
            // btnCylinderCalculate
            // 
            this.btnCylinderCalculate.Location = new System.Drawing.Point(80, 114);
            this.btnCylinderCalculate.Name = "btnCylinderCalculate";
            this.btnCylinderCalculate.Size = new System.Drawing.Size(139, 23);
            this.btnCylinderCalculate.TabIndex = 3;
            this.btnCylinderCalculate.Text = "CALCULAR";
            this.btnCylinderCalculate.UseVisualStyleBackColor = true;
            this.btnCylinderCalculate.Click += new System.EventHandler(this.btnCylinderCalculate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Altura";
            // 
            // txtCylinderHeight
            // 
            this.txtCylinderHeight.Location = new System.Drawing.Point(80, 67);
            this.txtCylinderHeight.Name = "txtCylinderHeight";
            this.txtCylinderHeight.Size = new System.Drawing.Size(139, 20);
            this.txtCylinderHeight.TabIndex = 2;
            this.txtCylinderHeight.TextChanged += new System.EventHandler(this.txtCylinderHeight_TextChanged);
            this.txtCylinderHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCylinderHeight_KeyPress);
            this.txtCylinderHeight.Leave += new System.EventHandler(this.txtCylinderHeight_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppProgramming.Activity1.Resources.cilidro001;
            this.pictureBox1.Location = new System.Drawing.Point(276, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(111, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Resultado:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbCylinderFormula, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbCylinderReplace, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 217);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.95699F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.04301F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(396, 100);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(202, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "SUSTITUCIÓN";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "FÓRMULA";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCylinderFormula
            // 
            this.lbCylinderFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCylinderFormula.AutoSize = true;
            this.lbCylinderFormula.Location = new System.Drawing.Point(5, 30);
            this.lbCylinderFormula.Name = "lbCylinderFormula";
            this.lbCylinderFormula.Size = new System.Drawing.Size(189, 68);
            this.lbCylinderFormula.TabIndex = 3;
            this.lbCylinderFormula.Text = "V = pi X (radio ^ 2) X altura";
            this.lbCylinderFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCylinderReplace
            // 
            this.lbCylinderReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCylinderReplace.AutoSize = true;
            this.lbCylinderReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCylinderReplace.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbCylinderReplace.Location = new System.Drawing.Point(202, 30);
            this.lbCylinderReplace.Name = "lbCylinderReplace";
            this.lbCylinderReplace.Size = new System.Drawing.Size(189, 68);
            this.lbCylinderReplace.TabIndex = 4;
            this.lbCylinderReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(31, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(368, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "VOLUMEN DE UN CILINDRO";
            // 
            // panelCone
            // 
            this.panelCone.Controls.Add(this.btnConeClear);
            this.panelCone.Controls.Add(this.lbConeResult);
            this.panelCone.Controls.Add(this.groupBox3);
            this.panelCone.Controls.Add(this.pictureBox2);
            this.panelCone.Controls.Add(this.label18);
            this.panelCone.Controls.Add(this.tableLayoutPanel3);
            this.panelCone.Controls.Add(this.label23);
            this.panelCone.Location = new System.Drawing.Point(852, 27);
            this.panelCone.Name = "panelCone";
            this.panelCone.Size = new System.Drawing.Size(421, 388);
            this.panelCone.TabIndex = 10;
            this.panelCone.Visible = false;
            // 
            // btnConeClear
            // 
            this.btnConeClear.Location = new System.Drawing.Point(178, 351);
            this.btnConeClear.Name = "btnConeClear";
            this.btnConeClear.Size = new System.Drawing.Size(75, 23);
            this.btnConeClear.TabIndex = 12;
            this.btnConeClear.Text = "Limpiar";
            this.btnConeClear.UseVisualStyleBackColor = true;
            this.btnConeClear.Click += new System.EventHandler(this.btnConeClear_Click);
            // 
            // lbConeResult
            // 
            this.lbConeResult.AutoSize = true;
            this.lbConeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConeResult.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbConeResult.Location = new System.Drawing.Point(191, 328);
            this.lbConeResult.Name = "lbConeResult";
            this.lbConeResult.Size = new System.Drawing.Size(40, 17);
            this.lbConeResult.TabIndex = 11;
            this.lbConeResult.Text = "0.00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtConeRadio);
            this.groupBox3.Controls.Add(this.btnConeCalculate);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtConeHeight);
            this.groupBox3.Location = new System.Drawing.Point(12, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 169);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos para el cálculo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Radio";
            // 
            // txtConeRadio
            // 
            this.txtConeRadio.Location = new System.Drawing.Point(80, 28);
            this.txtConeRadio.Name = "txtConeRadio";
            this.txtConeRadio.Size = new System.Drawing.Size(139, 20);
            this.txtConeRadio.TabIndex = 1;
            this.txtConeRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConeRadio_KeyPress);
            this.txtConeRadio.Leave += new System.EventHandler(this.txtConeRadio_Leave);
            // 
            // btnConeCalculate
            // 
            this.btnConeCalculate.Location = new System.Drawing.Point(80, 114);
            this.btnConeCalculate.Name = "btnConeCalculate";
            this.btnConeCalculate.Size = new System.Drawing.Size(139, 23);
            this.btnConeCalculate.TabIndex = 3;
            this.btnConeCalculate.Text = "CALCULAR";
            this.btnConeCalculate.UseVisualStyleBackColor = true;
            this.btnConeCalculate.Click += new System.EventHandler(this.btnConeCalculate_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Altura";
            // 
            // txtConeHeight
            // 
            this.txtConeHeight.Location = new System.Drawing.Point(80, 67);
            this.txtConeHeight.Name = "txtConeHeight";
            this.txtConeHeight.Size = new System.Drawing.Size(139, 20);
            this.txtConeHeight.TabIndex = 2;
            this.txtConeHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConeHeight_KeyPress);
            this.txtConeHeight.Leave += new System.EventHandler(this.txtConeHeight_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppProgramming.Activity1.Resources.cono001;
            this.pictureBox2.Location = new System.Drawing.Point(276, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(111, 328);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 10;
            this.label18.Text = "Resultado:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.14721F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.85279F));
            this.tableLayoutPanel3.Controls.Add(this.label19, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbConeFormula, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbConeReplace, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 217);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.95699F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.04301F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(396, 100);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(175, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(216, 26);
            this.label19.TabIndex = 1;
            this.label19.Text = "SUSTITUCIÓN";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 26);
            this.label20.TabIndex = 1;
            this.label20.Text = "FÓRMULA";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbConeFormula
            // 
            this.lbConeFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConeFormula.AutoSize = true;
            this.lbConeFormula.Location = new System.Drawing.Point(5, 30);
            this.lbConeFormula.Name = "lbConeFormula";
            this.lbConeFormula.Size = new System.Drawing.Size(162, 68);
            this.lbConeFormula.TabIndex = 3;
            this.lbConeFormula.Text = "V = ( pi X (radio ^ 2) X altura ) / 3";
            this.lbConeFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbConeReplace
            // 
            this.lbConeReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConeReplace.AutoSize = true;
            this.lbConeReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConeReplace.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbConeReplace.Location = new System.Drawing.Point(175, 30);
            this.lbConeReplace.Name = "lbConeReplace";
            this.lbConeReplace.Size = new System.Drawing.Size(216, 68);
            this.lbConeReplace.TabIndex = 4;
            this.lbConeReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Teal;
            this.label23.Location = new System.Drawing.Point(50, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(321, 29);
            this.label23.TabIndex = 1;
            this.label23.Text = "VOLUMEN DE UN CONO";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(307, 412);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 47);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Reporte";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Azure;
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(295, 455);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(124, 13);
            this.txtDate.TabIndex = 12;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(420, 471);
            this.ControlBox = false;
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelCylinder);
            this.Controls.Add(this.pyramidPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelCone);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad #1 - Completa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pyramidPanel.ResumeLayout(false);
            this.pyramidPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPyramid)).EndInit();
            this.panelCylinder.ResumeLayout(false);
            this.panelCylinder.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelCone.ResumeLayout(false);
            this.panelCone.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.Label lbPyramidFormula;
        private System.Windows.Forms.Label lbPyramidReplace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPyramidResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel pyramidPanel;
        private System.Windows.Forms.Panel panelCylinder;
        private System.Windows.Forms.Label lbCylinderResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCylinderCalculate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCylinderHeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbCylinderFormula;
        private System.Windows.Forms.Label lbCylinderReplace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCylinderRadio;
        private System.Windows.Forms.ToolStripMenuItem figuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirámideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cilindroToolStripMenuItem;
        private System.Windows.Forms.Button btnCylinderClear;
        private System.Windows.Forms.Panel panelCone;
        private System.Windows.Forms.Button btnConeClear;
        private System.Windows.Forms.Label lbConeResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtConeRadio;
        private System.Windows.Forms.Button btnConeCalculate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtConeHeight;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbConeFormula;
        private System.Windows.Forms.Label lbConeReplace;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripMenuItem conoToolStripMenuItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Timer timer;
    }
}

