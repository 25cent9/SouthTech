namespace Education
{
    partial class menu
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
            this.rdioBtnGrad = new System.Windows.Forms.RadioButton();
            this.rdioBtnUGrad = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdioBtnGrad
            // 
            this.rdioBtnGrad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rdioBtnGrad.AutoSize = true;
            this.rdioBtnGrad.Location = new System.Drawing.Point(122, 334);
            this.rdioBtnGrad.Name = "rdioBtnGrad";
            this.rdioBtnGrad.Size = new System.Drawing.Size(48, 17);
            this.rdioBtnGrad.TabIndex = 2;
            this.rdioBtnGrad.TabStop = true;
            this.rdioBtnGrad.Text = "Grad";
            this.rdioBtnGrad.UseVisualStyleBackColor = true;
            // 
            // rdioBtnUGrad
            // 
            this.rdioBtnUGrad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rdioBtnUGrad.AutoSize = true;
            this.rdioBtnUGrad.Location = new System.Drawing.Point(122, 357);
            this.rdioBtnUGrad.Name = "rdioBtnUGrad";
            this.rdioBtnUGrad.Size = new System.Drawing.Size(80, 17);
            this.rdioBtnUGrad.TabIndex = 3;
            this.rdioBtnUGrad.TabStop = true;
            this.rdioBtnUGrad.Text = "Under Grad";
            this.rdioBtnUGrad.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSubmit.Location = new System.Drawing.Point(122, 380);
            this.btnSubmit.MaximumSize = new System.Drawing.Size(67, 37);
            this.btnSubmit.MinimumSize = new System.Drawing.Size(67, 37);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(67, 37);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.Location = new System.Drawing.Point(122, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 6;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(331, 488);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdioBtnUGrad);
            this.Controls.Add(this.rdioBtnGrad);
            this.Name = "menu";
            this.Controls.SetChildIndex(this.rdioBtnGrad, 0);
            this.Controls.SetChildIndex(this.rdioBtnUGrad, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdioBtnGrad;
        private System.Windows.Forms.RadioButton rdioBtnUGrad;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
