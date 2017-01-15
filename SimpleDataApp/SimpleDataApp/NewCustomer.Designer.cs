namespace SimpleDataApp
{
    partial class frmNewCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOrderAmt = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnAnother = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtCustId);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.lblCustID);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Location = new System.Drawing.Point(122, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Account";
            // 
            // lblCustName
            // 
            this.lblCustName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(5, 15);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(88, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer Name: ";
            // 
            // lblCustID
            // 
            this.lblCustID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(5, 69);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(68, 13);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "Customer ID:";
            // 
            // txtCustName
            // 
            this.txtCustName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustName.Location = new System.Drawing.Point(99, 15);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(97, 20);
            this.txtCustName.TabIndex = 1;
            // 
            // txtCustId
            // 
            this.txtCustId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustId.Location = new System.Drawing.Point(99, 62);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.ReadOnly = true;
            this.txtCustId.Size = new System.Drawing.Size(97, 20);
            this.txtCustId.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Location = new System.Drawing.Point(404, 93);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 45);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dtpOrderDate);
            this.groupBox2.Controls.Add(this.numOrderAmt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(122, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Order";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Amount: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Date: ";
            // 
            // numOrderAmt
            // 
            this.numOrderAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numOrderAmt.Location = new System.Drawing.Point(90, 16);
            this.numOrderAmt.Name = "numOrderAmt";
            this.numOrderAmt.Size = new System.Drawing.Size(58, 20);
            this.numOrderAmt.TabIndex = 1;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(90, 50);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(106, 20);
            this.dtpOrderDate.TabIndex = 2;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.Location = new System.Drawing.Point(120, 297);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(82, 48);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnAnother
            // 
            this.btnAnother.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnother.Location = new System.Drawing.Point(207, 297);
            this.btnAnother.Name = "btnAnother";
            this.btnAnother.Size = new System.Drawing.Size(111, 48);
            this.btnAnother.TabIndex = 3;
            this.btnAnother.Text = "Add Another Account";
            this.btnAnother.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrder.Location = new System.Drawing.Point(321, 297);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(72, 48);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 366);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnAnother);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNewCustomer";
            this.Text = "NewCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.NumericUpDown numOrderAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnAnother;
        private System.Windows.Forms.Button btnOrder;
    }
}