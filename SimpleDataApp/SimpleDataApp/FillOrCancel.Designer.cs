namespace SimpleDataApp
{
    partial class frmFillOrCancel
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnFindOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.gdvCustOrders = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCustOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID: ";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderID.Location = new System.Drawing.Point(114, 29);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 20);
            this.txtOrderID.TabIndex = 1;
            // 
            // btnFindOrder
            // 
            this.btnFindOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindOrder.Location = new System.Drawing.Point(221, 29);
            this.btnFindOrder.Name = "btnFindOrder";
            this.btnFindOrder.Size = new System.Drawing.Size(75, 23);
            this.btnFindOrder.TabIndex = 2;
            this.btnFindOrder.Text = "Find Order";
            this.btnFindOrder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "If filling an order, specify filled date: ";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(208, 100);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(103, 20);
            this.dtpFillDate.TabIndex = 4;
            // 
            // gdvCustOrders
            // 
            this.gdvCustOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCustOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gdvCustOrders.Location = new System.Drawing.Point(0, 196);
            this.gdvCustOrders.Name = "gdvCustOrders";
            this.gdvCustOrders.ReadOnly = true;
            this.gdvCustOrders.Size = new System.Drawing.Size(364, 162);
            this.gdvCustOrders.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(38, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel Orders";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFill
            // 
            this.btnFill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFill.Location = new System.Drawing.Point(150, 167);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(76, 23);
            this.btnFill.TabIndex = 6;
            this.btnFill.Text = "Fill Order";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinish.Location = new System.Drawing.Point(251, 167);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(70, 23);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // frmFillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 358);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gdvCustOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindOrder);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Name = "frmFillOrCancel";
            this.Text = "FillOrCancel";
            ((System.ComponentModel.ISupportInitialize)(this.gdvCustOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnFindOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView gdvCustOrders;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnFinish;
    }
}