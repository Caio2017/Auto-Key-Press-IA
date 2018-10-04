namespace AutoMouse
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
            this.lblSelectColor1 = new System.Windows.Forms.Label();
            this.lblSelectColor2 = new System.Windows.Forms.Label();
            this.lblSelectColor3 = new System.Windows.Forms.Label();
            this.txtKeyPress1 = new System.Windows.Forms.TextBox();
            this.txtKeyPress2 = new System.Windows.Forms.TextBox();
            this.txtKeyPress3 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAtivar = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerCordenadas = new System.Windows.Forms.Timer(this.components);
            this.lblInformation = new System.Windows.Forms.Label();
            this.timerPressKey = new System.Windows.Forms.Timer(this.components);
            this.lblTest = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblPrinted = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectColor1
            // 
            this.lblSelectColor1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSelectColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelectColor1.Location = new System.Drawing.Point(12, 39);
            this.lblSelectColor1.Name = "lblSelectColor1";
            this.lblSelectColor1.Size = new System.Drawing.Size(104, 28);
            this.lblSelectColor1.TabIndex = 2;
            this.lblSelectColor1.Tag = "1";
            this.lblSelectColor1.Click += new System.EventHandler(this.lblSelectColor123_Click);
            // 
            // lblSelectColor2
            // 
            this.lblSelectColor2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSelectColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelectColor2.Location = new System.Drawing.Point(12, 77);
            this.lblSelectColor2.Name = "lblSelectColor2";
            this.lblSelectColor2.Size = new System.Drawing.Size(104, 28);
            this.lblSelectColor2.TabIndex = 4;
            this.lblSelectColor2.Tag = "2";
            this.lblSelectColor2.Click += new System.EventHandler(this.lblSelectColor123_Click);
            // 
            // lblSelectColor3
            // 
            this.lblSelectColor3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSelectColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelectColor3.Location = new System.Drawing.Point(12, 117);
            this.lblSelectColor3.Name = "lblSelectColor3";
            this.lblSelectColor3.Size = new System.Drawing.Size(104, 30);
            this.lblSelectColor3.TabIndex = 7;
            this.lblSelectColor3.Tag = "3";
            this.lblSelectColor3.Click += new System.EventHandler(this.lblSelectColor123_Click);
            // 
            // txtKeyPress1
            // 
            this.txtKeyPress1.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyPress1.Location = new System.Drawing.Point(149, 47);
            this.txtKeyPress1.Name = "txtKeyPress1";
            this.txtKeyPress1.ReadOnly = true;
            this.txtKeyPress1.Size = new System.Drawing.Size(71, 20);
            this.txtKeyPress1.TabIndex = 9;
            this.txtKeyPress1.Tag = "1";
            this.txtKeyPress1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyPress123_KeyUp);
            // 
            // txtKeyPress2
            // 
            this.txtKeyPress2.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyPress2.Location = new System.Drawing.Point(149, 82);
            this.txtKeyPress2.Name = "txtKeyPress2";
            this.txtKeyPress2.ReadOnly = true;
            this.txtKeyPress2.Size = new System.Drawing.Size(71, 20);
            this.txtKeyPress2.TabIndex = 10;
            this.txtKeyPress2.Tag = "2";
            this.txtKeyPress2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyPress123_KeyUp);
            // 
            // txtKeyPress3
            // 
            this.txtKeyPress3.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyPress3.Location = new System.Drawing.Point(149, 117);
            this.txtKeyPress3.Name = "txtKeyPress3";
            this.txtKeyPress3.ReadOnly = true;
            this.txtKeyPress3.Size = new System.Drawing.Size(71, 20);
            this.txtKeyPress3.TabIndex = 11;
            this.txtKeyPress3.Tag = "3";
            this.txtKeyPress3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyPress123_KeyUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblAtivar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 195);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(242, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(103, 19);
            this.toolStripStatusLabel1.Text = "Status: Desativado";
            // 
            // lblAtivar
            // 
            this.lblAtivar.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblAtivar.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblAtivar.Margin = new System.Windows.Forms.Padding(40, 3, 0, 2);
            this.lblAtivar.Name = "lblAtivar";
            this.lblAtivar.Size = new System.Drawing.Size(71, 19);
            this.lblAtivar.Text = "Ativar (F10)";
            this.lblAtivar.Click += new System.EventHandler(this.lblAtivar_Click);
            // 
            // timerCordenadas
            // 
            this.timerCordenadas.Interval = 1;
            this.timerCordenadas.Tick += new System.EventHandler(this.timerCordenadas_Tick);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(9, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(118, 15);
            this.lblInformation.TabIndex = 13;
            this.lblInformation.Text = "Press F6 to SELECT";
            this.lblInformation.Visible = false;
            // 
            // timerPressKey
            // 
            this.timerPressKey.Interval = 1;
            this.timerPressKey.Tick += new System.EventHandler(this.timerPressKey_Tick);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTest.Location = new System.Drawing.Point(122, 85);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(16, 15);
            this.lblTest.TabIndex = 14;
            this.lblTest.Text = "T";
            this.lblTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTest_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(149, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Lock";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(25, 163);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 20);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "reset all";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "MS:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(182, 170);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            // 
            // lblPrinted
            // 
            this.lblPrinted.AutoSize = true;
            this.lblPrinted.Location = new System.Drawing.Point(146, 4);
            this.lblPrinted.Name = "lblPrinted";
            this.lblPrinted.Size = new System.Drawing.Size(53, 39);
            this.lblPrinted.TabIndex = 21;
            this.lblPrinted.Text = "ticks:\r\nprints:\r\nkeyPress:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 219);
            this.Controls.Add(this.lblPrinted);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtKeyPress3);
            this.Controls.Add(this.txtKeyPress2);
            this.Controls.Add(this.txtKeyPress1);
            this.Controls.Add(this.lblSelectColor3);
            this.Controls.Add(this.lblSelectColor2);
            this.Controls.Add(this.lblSelectColor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Key 1.0";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectColor1;
        private System.Windows.Forms.Label lblSelectColor2;
        private System.Windows.Forms.Label lblSelectColor3;
        private System.Windows.Forms.TextBox txtKeyPress1;
        private System.Windows.Forms.TextBox txtKeyPress2;
        private System.Windows.Forms.TextBox txtKeyPress3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblAtivar;
        private System.Windows.Forms.Timer timerCordenadas;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Timer timerPressKey;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblPrinted;
    }
}

