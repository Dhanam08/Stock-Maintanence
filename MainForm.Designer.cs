namespace STORE
{
    partial class MainForm
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
            this.vwrequiredbtn = new System.Windows.Forms.Button();
            this.vwavailbtn = new System.Windows.Forms.Button();
            this.salebtn = new System.Windows.Forms.Button();
            this.stockgv = new System.Windows.Forms.DataGridView();
            this.newstockbtn = new System.Windows.Forms.Button();
            this.vwsalestockbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockgv)).BeginInit();
            this.SuspendLayout();
            // 
            // vwrequiredbtn
            // 
            this.vwrequiredbtn.Location = new System.Drawing.Point(40, 100);
            this.vwrequiredbtn.Name = "vwrequiredbtn";
            this.vwrequiredbtn.Size = new System.Drawing.Size(98, 57);
            this.vwrequiredbtn.TabIndex = 1;
            this.vwrequiredbtn.Text = "View Requried Stock";
            this.vwrequiredbtn.UseVisualStyleBackColor = true;
            this.vwrequiredbtn.Click += new System.EventHandler(this.vwrequiredbtn_Click);
            // 
            // vwavailbtn
            // 
            this.vwavailbtn.Location = new System.Drawing.Point(40, 210);
            this.vwavailbtn.Name = "vwavailbtn";
            this.vwavailbtn.Size = new System.Drawing.Size(98, 59);
            this.vwavailbtn.TabIndex = 2;
            this.vwavailbtn.Text = "View Available  Stock";
            this.vwavailbtn.UseVisualStyleBackColor = true;
            this.vwavailbtn.Click += new System.EventHandler(this.availbtn_Click);
            // 
            // salebtn
            // 
            this.salebtn.Location = new System.Drawing.Point(562, 433);
            this.salebtn.Name = "salebtn";
            this.salebtn.Size = new System.Drawing.Size(112, 41);
            this.salebtn.TabIndex = 3;
            this.salebtn.Text = "Sale";
            this.salebtn.UseVisualStyleBackColor = true;
            this.salebtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // stockgv
            // 
            this.stockgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stockgv.Location = new System.Drawing.Point(155, 100);
            this.stockgv.Name = "stockgv";
            this.stockgv.Size = new System.Drawing.Size(519, 301);
            this.stockgv.TabIndex = 4;
            // 
            // newstockbtn
            // 
            this.newstockbtn.Location = new System.Drawing.Point(26, 429);
            this.newstockbtn.Name = "newstockbtn";
            this.newstockbtn.Size = new System.Drawing.Size(112, 45);
            this.newstockbtn.TabIndex = 5;
            this.newstockbtn.Text = "New Stock";
            this.newstockbtn.UseVisualStyleBackColor = true;
            this.newstockbtn.Click += new System.EventHandler(this.newstockbtn_Click);
            // 
            // vwsalestockbtn
            // 
            this.vwsalestockbtn.Location = new System.Drawing.Point(40, 332);
            this.vwsalestockbtn.Name = "vwsalestockbtn";
            this.vwsalestockbtn.Size = new System.Drawing.Size(98, 53);
            this.vwsalestockbtn.TabIndex = 6;
            this.vwsalestockbtn.Text = "View Sales Stock";
            this.vwsalestockbtn.UseVisualStyleBackColor = true;
            this.vwsalestockbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "STOCK INFORMATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(694, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vwsalestockbtn);
            this.Controls.Add(this.newstockbtn);
            this.Controls.Add(this.stockgv);
            this.Controls.Add(this.salebtn);
            this.Controls.Add(this.vwavailbtn);
            this.Controls.Add(this.vwrequiredbtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.stockgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vwrequiredbtn;
        private System.Windows.Forms.Button vwavailbtn;
        private System.Windows.Forms.Button salebtn;
        private System.Windows.Forms.DataGridView stockgv;
        private System.Windows.Forms.Button newstockbtn;
        private System.Windows.Forms.Button vwsalestockbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}