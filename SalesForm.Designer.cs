namespace STORE
{
    partial class SalesForm
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
            this.prodpricetxtbox = new System.Windows.Forms.TextBox();
            this.prodquantxtbox = new System.Windows.Forms.TextBox();
            this.totalpricetxtbox = new System.Windows.Forms.TextBox();
            this.salepaybtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cusnumbertxtbox = new System.Windows.Forms.TextBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.prodnametxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Price";
            // 
            // prodpricetxtbox
            // 
            this.prodpricetxtbox.Location = new System.Drawing.Point(311, 185);
            this.prodpricetxtbox.Name = "prodpricetxtbox";
            this.prodpricetxtbox.Size = new System.Drawing.Size(210, 20);
            this.prodpricetxtbox.TabIndex = 5;
            // 
            // prodquantxtbox
            // 
            this.prodquantxtbox.Location = new System.Drawing.Point(311, 243);
            this.prodquantxtbox.Name = "prodquantxtbox";
            this.prodquantxtbox.Size = new System.Drawing.Size(210, 20);
            this.prodquantxtbox.TabIndex = 6;
            this.prodquantxtbox.TextChanged += new System.EventHandler(this.prodquantxtbox_TextChanged);
            // 
            // totalpricetxtbox
            // 
            this.totalpricetxtbox.Location = new System.Drawing.Point(311, 303);
            this.totalpricetxtbox.Name = "totalpricetxtbox";
            this.totalpricetxtbox.Size = new System.Drawing.Size(210, 20);
            this.totalpricetxtbox.TabIndex = 7;
            this.totalpricetxtbox.TextChanged += new System.EventHandler(this.totalpricetxtbox_TextChanged);
            // 
            // salepaybtn
            // 
            this.salepaybtn.Location = new System.Drawing.Point(241, 443);
            this.salepaybtn.Name = "salepaybtn";
            this.salepaybtn.Size = new System.Drawing.Size(75, 23);
            this.salepaybtn.TabIndex = 8;
            this.salepaybtn.Text = "PAY";
            this.salepaybtn.UseVisualStyleBackColor = true;
            this.salepaybtn.Click += new System.EventHandler(this.salepaybtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Customer Number";
            // 
            // cusnumbertxtbox
            // 
            this.cusnumbertxtbox.Location = new System.Drawing.Point(311, 367);
            this.cusnumbertxtbox.Name = "cusnumbertxtbox";
            this.cusnumbertxtbox.Size = new System.Drawing.Size(210, 20);
            this.cusnumbertxtbox.TabIndex = 10;
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(674, 28);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 11;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // prodnametxtbox
            // 
            this.prodnametxtbox.Location = new System.Drawing.Point(311, 123);
            this.prodnametxtbox.Name = "prodnametxtbox";
            this.prodnametxtbox.Size = new System.Drawing.Size(210, 20);
            this.prodnametxtbox.TabIndex = 1;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(797, 490);
            this.Controls.Add(this.salepaybtn);
            this.Controls.Add(this.cusnumbertxtbox);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodnametxtbox);
            this.Controls.Add(this.prodpricetxtbox);
            this.Controls.Add(this.prodquantxtbox);
            this.Controls.Add(this.totalpricetxtbox);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prodpricetxtbox;
        private System.Windows.Forms.TextBox prodquantxtbox;
        private System.Windows.Forms.TextBox totalpricetxtbox;
        private System.Windows.Forms.Button salepaybtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cusnumbertxtbox;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.TextBox prodnametxtbox;
    }
}