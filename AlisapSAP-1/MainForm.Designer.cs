namespace kuliSAP1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadViewSAP1FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblerEmulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assembleCreateBinFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBinFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSAP1EmulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAP1ArchitectureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glossaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSAP1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 

            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;

            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assemblerEmulatorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.menuStrip1_Paint);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadViewSAP1FileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadViewSAP1FileToolStripMenuItem
            // 
            this.loadViewSAP1FileToolStripMenuItem.Name = "loadViewSAP1FileToolStripMenuItem";
            this.loadViewSAP1FileToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.loadViewSAP1FileToolStripMenuItem.Text = "Load/View SAP-1 File";
            this.loadViewSAP1FileToolStripMenuItem.Click += new System.EventHandler(this.loadViewSAP1FileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // assemblerEmulatorToolStripMenuItem
            // 
            this.assemblerEmulatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assembleCreateBinFileToolStripMenuItem,
            this.loadBinFileToolStripMenuItem,
            this.openSAP1EmulatorToolStripMenuItem});
            this.assemblerEmulatorToolStripMenuItem.Name = "assemblerEmulatorToolStripMenuItem";
            this.assemblerEmulatorToolStripMenuItem.Size = new System.Drawing.Size(156, 23);
            this.assemblerEmulatorToolStripMenuItem.Text = "Assembler/Emulator";
            // 
            // assembleCreateBinFileToolStripMenuItem
            // 
            this.assembleCreateBinFileToolStripMenuItem.Name = "assembleCreateBinFileToolStripMenuItem";
            this.assembleCreateBinFileToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.assembleCreateBinFileToolStripMenuItem.Text = "Assemble/Create Bin File";
            this.assembleCreateBinFileToolStripMenuItem.Click += new System.EventHandler(this.assembleCreateBinFileToolStripMenuItem_Click);
            // 
            // loadBinFileToolStripMenuItem
            // 
            this.loadBinFileToolStripMenuItem.Name = "loadBinFileToolStripMenuItem";
            this.loadBinFileToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.loadBinFileToolStripMenuItem.Text = "Load Bin File";
            this.loadBinFileToolStripMenuItem.Click += new System.EventHandler(this.loadBinFileToolStripMenuItem_Click);
            // 
            // openSAP1EmulatorToolStripMenuItem
            // 
            this.openSAP1EmulatorToolStripMenuItem.Name = "openSAP1EmulatorToolStripMenuItem";
            this.openSAP1EmulatorToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.openSAP1EmulatorToolStripMenuItem.Text = "Open SAP-1 Emulator";
            this.openSAP1EmulatorToolStripMenuItem.Click += new System.EventHandler(this.openSAP1EmulatorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAP1ArchitectureToolStripMenuItem,
            this.glossaryToolStripMenuItem,
            this.aboutSAP1ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sAP1ArchitectureToolStripMenuItem
            // 
            this.sAP1ArchitectureToolStripMenuItem.Name = "sAP1ArchitectureToolStripMenuItem";
            this.sAP1ArchitectureToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.sAP1ArchitectureToolStripMenuItem.Text = "SAP-1 Architecture";
            this.sAP1ArchitectureToolStripMenuItem.Click += new System.EventHandler(this.sAP1ArchitectureToolStripMenuItem_Click);
            // 
            // glossaryToolStripMenuItem
            // 
            this.glossaryToolStripMenuItem.Name = "glossaryToolStripMenuItem";
            this.glossaryToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.glossaryToolStripMenuItem.Text = "Glossary";
            this.glossaryToolStripMenuItem.Click += new System.EventHandler(this.glossaryToolStripMenuItem_Click);
            // 
            // aboutSAP1ToolStripMenuItem
            // 
            this.aboutSAP1ToolStripMenuItem.Name = "aboutSAP1ToolStripMenuItem";
            this.aboutSAP1ToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.aboutSAP1ToolStripMenuItem.Text = "About kuliSAP";
            this.aboutSAP1ToolStripMenuItem.Click += new System.EventHandler(this.aboutSAP1ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.sap1";
            this.openFileDialog1.Filter = "Sap1 Files|*.sap1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "*.sap1";
            this.saveFileDialog1.Filter = "Sap1 Files(*.sap1)|*.sap1";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 644);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 

            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            this.tabPage1.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));

            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "new 1";

            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(473, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Machine Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Assembly Code";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(3, 498);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel4.Size = new System.Drawing.Size(970, 88);
            this.panel4.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.Red;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(10, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(946, 74);
            this.listBox1.TabIndex = 1;
            // 
            // panel3
            // 


            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.panel3.Controls.Add(this.tabControl2);
            this.panel3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(476, 30);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.panel3.Size = new System.Drawing.Size(497, 462);
            this.panel3.TabIndex = 4;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(15, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(465, 446);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 

            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;

            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(457, 419);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Assemble GUI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Assembly Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 14);
            this.label7.TabIndex = 3;
            this.label7.Text = "RAM Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.78475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.65022F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.56503F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.tabPage3.Size = new System.Drawing.Size(455, 418);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Bin File";
            // 
            // richTextBox2
            // 
            this.richTextBox2.AcceptsTab = true;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.richTextBox2.Location = new System.Drawing.Point(15, 7);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(425, 404);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // panel2
            // 

            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.panel2.Size = new System.Drawing.Size(467, 462);
            this.panel2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.BackColor = System.Drawing.Color.Azure;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(15, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(435, 446);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.MouseCaptureChanged += new System.EventHandler(this.richTextBox1_MouseCaptureChanged);
            // 
            // panel1
            // 

            this.panel1.BackColor = System.Drawing.Color.Transparent;

            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;

            this.panel1.Location = new System.Drawing.Point(3, 589);

            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 26);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Line";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "*.bin";
            this.saveFileDialog2.Filter = "Bin Files(*.bin)|*.bin";
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "*.bin";
            this.openFileDialog2.Filter = "Bin Files|*.bin";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 671);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadViewSAP1FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblerEmulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assembleCreateBinFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSAP1EmulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAP1ArchitectureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glossaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSAP1ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripMenuItem loadBinFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

