namespace STORE
{
    partial class SalesManinfo
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
            this.salemaninfogv = new System.Windows.Forms.DataGridView();
            this.salemanperbtn = new System.Windows.Forms.Button();
            this.salesmansalbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salemaninfogv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALESMAN INFORMATION";
            // 
            // salemaninfogv
            // 
            this.salemaninfogv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salemaninfogv.Location = new System.Drawing.Point(193, 88);
            this.salemaninfogv.Name = "salemaninfogv";
            this.salemaninfogv.Size = new System.Drawing.Size(464, 272);
            this.salemaninfogv.TabIndex = 1;
            // 
            // salemanperbtn
            // 
            this.salemanperbtn.Location = new System.Drawing.Point(60, 136);
            this.salemanperbtn.Name = "salemanperbtn";
            this.salemanperbtn.Size = new System.Drawing.Size(75, 43);
            this.salemanperbtn.TabIndex = 2;
            this.salemanperbtn.Text = "Saleman Performance";
            this.salemanperbtn.UseVisualStyleBackColor = true;
            this.salemanperbtn.Click += new System.EventHandler(this.salemanperbtn_Click);
            // 
            // salesmansalbtn
            // 
            this.salesmansalbtn.Location = new System.Drawing.Point(60, 251);
            this.salesmansalbtn.Name = "salesmansalbtn";
            this.salesmansalbtn.Size = new System.Drawing.Size(75, 41);
            this.salesmansalbtn.TabIndex = 3;
            this.salesmansalbtn.Text = "SalesMan Salary";
            this.salesmansalbtn.UseVisualStyleBackColor = true;
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(582, 28);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 4;
            this.homebtn.Text = "HOME";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // SalesManinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(720, 489);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.salesmansalbtn);
            this.Controls.Add(this.salemanperbtn);
            this.Controls.Add(this.salemaninfogv);
            this.Controls.Add(this.label1);
            this.Name = "SalesManinfo";
            this.Text = "SalesManinfo";
            ((System.ComponentModel.ISupportInitialize)(this.salemaninfogv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView salemaninfogv;
        private System.Windows.Forms.Button salemanperbtn;
        private System.Windows.Forms.Button salesmansalbtn;
        private System.Windows.Forms.Button homebtn;
    }
}