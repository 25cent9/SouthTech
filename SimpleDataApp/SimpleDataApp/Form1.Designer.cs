namespace SimpleDataApp
{
    partial class frmMenu
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
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnFillOrCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to do?";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAccount.Location = new System.Drawing.Point(96, 195);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(108, 23);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add an Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnFillOrCancel
            // 
            this.btnFillOrCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFillOrCancel.Location = new System.Drawing.Point(301, 194);
            this.btnFillOrCancel.Name = "btnFillOrCancel";
            this.btnFillOrCancel.Size = new System.Drawing.Size(119, 23);
            this.btnFillOrCancel.TabIndex = 2;
            this.btnFillOrCancel.Text = "Fill or Cancel an Order";
            this.btnFillOrCancel.UseVisualStyleBackColor = true;
            this.btnFillOrCancel.Click += new System.EventHandler(this.btnFillOrCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(403, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 458);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFillOrCancel);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnFillOrCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

