namespace kuliSAP1
{
    partial class Emulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emulator));
            this.panel = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.lblBO = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblAddSub = new System.Windows.Forms.Label();
            this.lblAccu = new System.Windows.Forms.Label();
            this.lblCS = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblIM = new System.Windows.Forms.Label();
            this.lblMoving = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblAssembly = new System.Windows.Forms.Label();
            this.btnJump = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.lblState);
            this.panel.Controls.Add(this.lblBO);
            this.panel.Controls.Add(this.lblOR);
            this.panel.Controls.Add(this.lblReg);
            this.panel.Controls.Add(this.lblAddSub);
            this.panel.Controls.Add(this.lblAccu);
            this.panel.Controls.Add(this.lblCS);
            this.panel.Controls.Add(this.lblIR);
            this.panel.Controls.Add(this.lblRam);
            this.panel.Controls.Add(this.lblIM);
            this.panel.Controls.Add(this.lblMoving);
            this.panel.Controls.Add(this.lblPC);
            this.panel.Location = new System.Drawing.Point(348, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(680, 654);
            this.panel.TabIndex = 0;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(29, 552);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(92, 74);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State 1";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBO
            // 
            this.lblBO.AutoSize = true;
            this.lblBO.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblBO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBO.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBO.Location = new System.Drawing.Point(538, 497);
            this.lblBO.Name = "lblBO";
            this.lblBO.Size = new System.Drawing.Size(0, 23);
            this.lblBO.TabIndex = 4;
            this.lblBO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOR.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOR.Location = new System.Drawing.Point(507, 402);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(0, 23);
            this.lblOR.TabIndex = 4;
            this.lblOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReg.Location = new System.Drawing.Point(507, 306);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(0, 23);
            this.lblReg.TabIndex = 4;
            this.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddSub
            // 
            this.lblAddSub.AutoSize = true;
            this.lblAddSub.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAddSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddSub.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddSub.Location = new System.Drawing.Point(507, 203);
            this.lblAddSub.Name = "lblAddSub";
            this.lblAddSub.Size = new System.Drawing.Size(0, 23);
            this.lblAddSub.TabIndex = 4;
            this.lblAddSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccu
            // 
            this.lblAccu.AutoSize = true;
            this.lblAccu.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAccu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAccu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccu.Location = new System.Drawing.Point(507, 113);
            this.lblAccu.Name = "lblAccu";
            this.lblAccu.Size = new System.Drawing.Size(0, 23);
            this.lblAccu.TabIndex = 4;
            this.lblAccu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCS.Location = new System.Drawing.Point(121, 497);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(0, 23);
            this.lblCS.TabIndex = 4;
            this.lblCS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIR.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIR.Location = new System.Drawing.Point(104, 402);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(0, 23);
            this.lblIR.TabIndex = 4;
            this.lblIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblRam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRam.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRam.Location = new System.Drawing.Point(102, 306);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(0, 23);
            this.lblRam.TabIndex = 4;
            this.lblRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIM
            // 
            this.lblIM.AutoSize = true;
            this.lblIM.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIM.Location = new System.Drawing.Point(121, 209);
            this.lblIM.Name = "lblIM";
            this.lblIM.Size = new System.Drawing.Size(0, 23);
            this.lblIM.TabIndex = 4;
            this.lblIM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoving
            // 
            this.lblMoving.AutoSize = true;
            this.lblMoving.BackColor = System.Drawing.Color.SkyBlue;
            this.lblMoving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoving.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoving.Location = new System.Drawing.Point(121, 113);
            this.lblMoving.Name = "lblMoving";
            this.lblMoving.Size = new System.Drawing.Size(2, 25);
            this.lblMoving.TabIndex = 2;
            this.lblMoving.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMoving.Visible = false;
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPC.Location = new System.Drawing.Point(121, 113);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(0, 23);
            this.lblPC.TabIndex = 4;
            this.lblPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssembly
            // 
            this.lblAssembly.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAssembly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssembly.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssembly.Location = new System.Drawing.Point(12, 9);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(330, 319);
            this.lblAssembly.TabIndex = 1;
            this.lblAssembly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJump
            // 
            this.btnJump.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnJump.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJump.ForeColor = System.Drawing.Color.Black;
            this.btnJump.Location = new System.Drawing.Point(84, 396);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(184, 47);
            this.btnJump.TabIndex = 2;
            this.btnJump.Text = "Jump";
            this.btnJump.UseVisualStyleBackColor = false;
            // 
            // btnSync
            // 
            this.btnSync.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSync.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.ForeColor = System.Drawing.Color.Black;
            this.btnSync.Location = new System.Drawing.Point(84, 343);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(184, 47);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "Synchronous";
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Emulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 658);
            this.Controls.Add(this.btnJump);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.lblAssembly);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.Name = "Emulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emulator";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        protected internal System.Windows.Forms.Label lblAssembly;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnSync;
        protected internal System.Windows.Forms.Label lblMoving;
        protected internal System.Windows.Forms.Label lblIM;
        protected internal System.Windows.Forms.Label lblPC;
        protected internal System.Windows.Forms.Label lblRam;
        protected internal System.Windows.Forms.Label lblIR;
        protected internal System.Windows.Forms.Label lblCS;
        protected internal System.Windows.Forms.Label lblAccu;
        protected internal System.Windows.Forms.Label lblAddSub;
        protected internal System.Windows.Forms.Label lblReg;
        protected internal System.Windows.Forms.Label lblOR;
        protected internal System.Windows.Forms.Label lblBO;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblState;
    }
}