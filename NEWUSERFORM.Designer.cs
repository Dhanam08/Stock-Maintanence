namespace STORE
{
    partial class NEWUSERFORM
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NUnametxtbox = new System.Windows.Forms.TextBox();
            this.NUpasswordtxtbox = new System.Windows.Forms.TextBox();
            this.NUconpasswordtxtbox = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER YOUR DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // NUnametxtbox
            // 
            this.NUnametxtbox.Location = new System.Drawing.Point(367, 107);
            this.NUnametxtbox.Name = "NUnametxtbox";
            this.NUnametxtbox.Size = new System.Drawing.Size(100, 20);
            this.NUnametxtbox.TabIndex = 4;
            // 
            // NUpasswordtxtbox
            // 
            this.NUpasswordtxtbox.Location = new System.Drawing.Point(367, 190);
            this.NUpasswordtxtbox.Name = "NUpasswordtxtbox";
            this.NUpasswordtxtbox.PasswordChar = '*';
            this.NUpasswordtxtbox.Size = new System.Drawing.Size(100, 20);
            this.NUpasswordtxtbox.TabIndex = 5;
            // 
            // NUconpasswordtxtbox
            // 
            this.NUconpasswordtxtbox.Location = new System.Drawing.Point(367, 274);
            this.NUconpasswordtxtbox.Name = "NUconpasswordtxtbox";
            this.NUconpasswordtxtbox.PasswordChar = '*';
            this.NUconpasswordtxtbox.Size = new System.Drawing.Size(100, 20);
            this.NUconpasswordtxtbox.TabIndex = 6;
            this.NUconpasswordtxtbox.TextChanged += new System.EventHandler(this.NUconpasswordtxtbox_TextChanged);
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(222, 345);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(75, 23);
            this.registerbtn.TabIndex = 7;
            this.registerbtn.Text = "REGISTER";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(367, 345);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "CANCEL";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // NEWUSERFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(697, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.NUconpasswordtxtbox);
            this.Controls.Add(this.NUpasswordtxtbox);
            this.Controls.Add(this.NUnametxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NEWUSERFORM";
            this.Text = "NEWUSERFORM";
            this.Load += new System.EventHandler(this.NEWUSERFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NUnametxtbox;
        private System.Windows.Forms.TextBox NUpasswordtxtbox;
        private System.Windows.Forms.TextBox NUconpasswordtxtbox;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label5;
    }
}