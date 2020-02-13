namespace STORE
{
    partial class AvailStockForm
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
            this.insertnewstockbtn = new System.Windows.Forms.Button();
            this.totalpricetxtbox = new System.Windows.Forms.TextBox();
            this.prodquantxtbox = new System.Windows.Forms.TextBox();
            this.prodpricetxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodnametxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insertnewstockbtn
            // 
            this.insertnewstockbtn.Location = new System.Drawing.Point(287, 394);
            this.insertnewstockbtn.Name = "insertnewstockbtn";
            this.insertnewstockbtn.Size = new System.Drawing.Size(155, 23);
            this.insertnewstockbtn.TabIndex = 19;
            this.insertnewstockbtn.Text = "INSERT NEW STOCK";
            this.insertnewstockbtn.UseVisualStyleBackColor = true;
            this.insertnewstockbtn.Click += new System.EventHandler(this.salepaybtn_Click);
            // 
            // totalpricetxtbox
            // 
            this.totalpricetxtbox.Location = new System.Drawing.Point(380, 286);
            this.totalpricetxtbox.Name = "totalpricetxtbox";
            this.totalpricetxtbox.Size = new System.Drawing.Size(187, 20);
            this.totalpricetxtbox.TabIndex = 18;
            // 
            // prodquantxtbox
            // 
            this.prodquantxtbox.Location = new System.Drawing.Point(380, 233);
            this.prodquantxtbox.Name = "prodquantxtbox";
            this.prodquantxtbox.Size = new System.Drawing.Size(187, 20);
            this.prodquantxtbox.TabIndex = 17;
            this.prodquantxtbox.TextChanged += new System.EventHandler(this.prodquantxtbox_TextChanged);
            // 
            // prodpricetxtbox
            // 
            this.prodpricetxtbox.Location = new System.Drawing.Point(380, 171);
            this.prodpricetxtbox.Name = "prodpricetxtbox";
            this.prodpricetxtbox.Size = new System.Drawing.Size(187, 20);
            this.prodpricetxtbox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product Price";
            // 
            // prodnametxtbox
            // 
            this.prodnametxtbox.Location = new System.Drawing.Point(380, 123);
            this.prodnametxtbox.Name = "prodnametxtbox";
            this.prodnametxtbox.Size = new System.Drawing.Size(187, 20);
            this.prodnametxtbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product Name";
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(681, 23);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 20;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "STORE IN NEW STOCK INTO AVAILABLE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AvailStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(778, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalpricetxtbox);
            this.Controls.Add(this.prodnametxtbox);
            this.Controls.Add(this.prodquantxtbox);
            this.Controls.Add(this.prodpricetxtbox);
            this.Controls.Add(this.insertnewstockbtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "AvailStockForm";
            this.Text = "AvailStockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertnewstockbtn;
        private System.Windows.Forms.TextBox totalpricetxtbox;
        private System.Windows.Forms.TextBox prodquantxtbox;
        private System.Windows.Forms.TextBox prodpricetxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prodnametxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Label label5;
    }
}