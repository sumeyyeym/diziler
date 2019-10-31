namespace array_
{
    partial class Form2
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
            this.btnSon = new System.Windows.Forms.Button();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(12, 12);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(131, 23);
            this.btnSon.TabIndex = 0;
            this.btnSon.Text = "Son Elemanı Göster";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.BtnSon_Click);
            // 
            // btnRastgele
            // 
            this.btnRastgele.Location = new System.Drawing.Point(12, 41);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(131, 23);
            this.btnRastgele.TabIndex = 1;
            this.btnRastgele.Text = "Rastgele Eleman Göster";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.BtnRastgele_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 70);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(131, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Elemanları Listboxa Ekle";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 95);
            this.listBox1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 206);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.btnSon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox listBox1;
    }
}