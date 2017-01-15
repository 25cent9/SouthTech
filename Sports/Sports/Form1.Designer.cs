namespace Sports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBasketball = new System.Windows.Forms.Button();
            this.btnCrew = new System.Windows.Forms.Button();
            this.btnFootball = new System.Windows.Forms.Button();
            this.btnLacrosse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coachName = new System.Windows.Forms.Label();
            this.btnSoccer = new System.Windows.Forms.Button();
            this.btnTennis = new System.Windows.Forms.Button();
            this.lblStudentFName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbSports = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCoachSport = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnBasketball
            // 
            this.btnBasketball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBasketball.Location = new System.Drawing.Point(14, 15);
            this.btnBasketball.Name = "btnBasketball";
            this.btnBasketball.Size = new System.Drawing.Size(75, 23);
            this.btnBasketball.TabIndex = 1;
            this.btnBasketball.Text = "Basketball";
            this.btnBasketball.UseVisualStyleBackColor = true;
            this.btnBasketball.Click += new System.EventHandler(this.btnBasketball_Click);
            // 
            // btnCrew
            // 
            this.btnCrew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrew.Location = new System.Drawing.Point(95, 15);
            this.btnCrew.Name = "btnCrew";
            this.btnCrew.Size = new System.Drawing.Size(75, 23);
            this.btnCrew.TabIndex = 2;
            this.btnCrew.Text = "Crew";
            this.btnCrew.UseVisualStyleBackColor = true;
            this.btnCrew.Click += new System.EventHandler(this.btnCrew_Click);
            // 
            // btnFootball
            // 
            this.btnFootball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFootball.Location = new System.Drawing.Point(176, 15);
            this.btnFootball.Name = "btnFootball";
            this.btnFootball.Size = new System.Drawing.Size(75, 23);
            this.btnFootball.TabIndex = 3;
            this.btnFootball.Text = "Football";
            this.btnFootball.UseVisualStyleBackColor = true;
            this.btnFootball.Click += new System.EventHandler(this.btnFootball_Click);
            // 
            // btnLacrosse
            // 
            this.btnLacrosse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLacrosse.Location = new System.Drawing.Point(257, 15);
            this.btnLacrosse.Name = "btnLacrosse";
            this.btnLacrosse.Size = new System.Drawing.Size(75, 23);
            this.btnLacrosse.TabIndex = 4;
            this.btnLacrosse.Text = "Lacrosse";
            this.btnLacrosse.UseVisualStyleBackColor = true;
            this.btnLacrosse.Click += new System.EventHandler(this.btnLacrosse_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coach Name: ";
            // 
            // coachName
            // 
            this.coachName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coachName.AutoSize = true;
            this.coachName.Location = new System.Drawing.Point(96, 207);
            this.coachName.Name = "coachName";
            this.coachName.Size = new System.Drawing.Size(0, 13);
            this.coachName.TabIndex = 6;
            // 
            // btnSoccer
            // 
            this.btnSoccer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSoccer.Location = new System.Drawing.Point(339, 14);
            this.btnSoccer.Name = "btnSoccer";
            this.btnSoccer.Size = new System.Drawing.Size(75, 23);
            this.btnSoccer.TabIndex = 7;
            this.btnSoccer.Text = "Soccer";
            this.btnSoccer.UseVisualStyleBackColor = true;
            this.btnSoccer.Click += new System.EventHandler(this.btnSoccer_Click);
            // 
            // btnTennis
            // 
            this.btnTennis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTennis.Location = new System.Drawing.Point(421, 14);
            this.btnTennis.Name = "btnTennis";
            this.btnTennis.Size = new System.Drawing.Size(75, 23);
            this.btnTennis.TabIndex = 8;
            this.btnTennis.Text = "Tennis";
            this.btnTennis.UseVisualStyleBackColor = true;
            this.btnTennis.Click += new System.EventHandler(this.btnTennis_Click);
            // 
            // lblStudentFName
            // 
            this.lblStudentFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentFName.AutoSize = true;
            this.lblStudentFName.Location = new System.Drawing.Point(15, 90);
            this.lblStudentFName.Name = "lblStudentFName";
            this.lblStudentFName.Size = new System.Drawing.Size(60, 13);
            this.lblStudentFName.TabIndex = 9;
            this.lblStudentFName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Location = new System.Drawing.Point(108, 87);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(366, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Student Number:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentNumber.Location = new System.Drawing.Point(108, 126);
            this.txtStudentNumber.MaxLength = 6;
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNumber.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sport:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(170, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(256, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbSports
            // 
            this.cmbSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSports.FormattingEnabled = true;
            this.cmbSports.Items.AddRange(new object[] {
            "Basketball",
            "Tennis",
            "Crew",
            "Soccer",
            "Football",
            "Lacrosse"});
            this.cmbSports.Location = new System.Drawing.Point(366, 126);
            this.cmbSports.Name = "cmbSports";
            this.cmbSports.Size = new System.Drawing.Size(100, 21);
            this.cmbSports.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sport:";
            // 
            // lblCoachSport
            // 
            this.lblCoachSport.AutoSize = true;
            this.lblCoachSport.Location = new System.Drawing.Point(403, 208);
            this.lblCoachSport.Name = "lblCoachSport";
            this.lblCoachSport.Size = new System.Drawing.Size(0, 13);
            this.lblCoachSport.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 457);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCoachSport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSports);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblStudentFName);
            this.Controls.Add(this.btnTennis);
            this.Controls.Add(this.btnSoccer);
            this.Controls.Add(this.coachName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLacrosse);
            this.Controls.Add(this.btnFootball);
            this.Controls.Add(this.btnCrew);
            this.Controls.Add(this.btnBasketball);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Sports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBasketball;
        private System.Windows.Forms.Button btnCrew;
        private System.Windows.Forms.Button btnFootball;
        private System.Windows.Forms.Button btnLacrosse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coachName;
        private System.Windows.Forms.Button btnSoccer;
        private System.Windows.Forms.Button btnTennis;
        private System.Windows.Forms.Label lblStudentFName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbSports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCoachSport;
        private System.Windows.Forms.Button btnClear;
    }
}

