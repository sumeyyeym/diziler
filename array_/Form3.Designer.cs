namespace array_
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAclear = new System.Windows.Forms.Button();
            this.btnAcopy = new System.Windows.Forms.Button();
            this.btnAind = new System.Windows.Forms.Button();
            this.btnAlast = new System.Windows.Forms.Button();
            this.btnAresize = new System.Windows.Forms.Button();
            this.btnAsort = new System.Windows.Forms.Button();
            this.btnAreverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnAclear
            // 
            this.btnAclear.Location = new System.Drawing.Point(12, 38);
            this.btnAclear.Name = "btnAclear";
            this.btnAclear.Size = new System.Drawing.Size(108, 23);
            this.btnAclear.TabIndex = 1;
            this.btnAclear.Text = "Array Clear";
            this.btnAclear.UseVisualStyleBackColor = true;
            this.btnAclear.Click += new System.EventHandler(this.BtnAclear_Click);
            // 
            // btnAcopy
            // 
            this.btnAcopy.Location = new System.Drawing.Point(12, 67);
            this.btnAcopy.Name = "btnAcopy";
            this.btnAcopy.Size = new System.Drawing.Size(108, 23);
            this.btnAcopy.TabIndex = 2;
            this.btnAcopy.Text = "Array Copy";
            this.btnAcopy.UseVisualStyleBackColor = true;
            this.btnAcopy.Click += new System.EventHandler(this.BtnAcopy_Click);
            // 
            // btnAind
            // 
            this.btnAind.Location = new System.Drawing.Point(12, 96);
            this.btnAind.Name = "btnAind";
            this.btnAind.Size = new System.Drawing.Size(108, 23);
            this.btnAind.TabIndex = 3;
            this.btnAind.Text = "Array Index Of";
            this.btnAind.UseVisualStyleBackColor = true;
            this.btnAind.Click += new System.EventHandler(this.BtnAind_Click);
            // 
            // btnAlast
            // 
            this.btnAlast.Location = new System.Drawing.Point(12, 125);
            this.btnAlast.Name = "btnAlast";
            this.btnAlast.Size = new System.Drawing.Size(108, 23);
            this.btnAlast.TabIndex = 4;
            this.btnAlast.Text = "Array Last Index Of";
            this.btnAlast.UseVisualStyleBackColor = true;
            this.btnAlast.Click += new System.EventHandler(this.BtnAlast_Click);
            // 
            // btnAresize
            // 
            this.btnAresize.Location = new System.Drawing.Point(12, 154);
            this.btnAresize.Name = "btnAresize";
            this.btnAresize.Size = new System.Drawing.Size(108, 23);
            this.btnAresize.TabIndex = 5;
            this.btnAresize.Text = "Array Resize";
            this.btnAresize.UseVisualStyleBackColor = true;
            this.btnAresize.Click += new System.EventHandler(this.BtnAresize_Click);
            // 
            // btnAsort
            // 
            this.btnAsort.Location = new System.Drawing.Point(12, 183);
            this.btnAsort.Name = "btnAsort";
            this.btnAsort.Size = new System.Drawing.Size(108, 23);
            this.btnAsort.TabIndex = 6;
            this.btnAsort.Text = "Array Sort";
            this.btnAsort.UseVisualStyleBackColor = true;
            this.btnAsort.Click += new System.EventHandler(this.BtnAsort_Click);
            // 
            // btnAreverse
            // 
            this.btnAreverse.Location = new System.Drawing.Point(12, 212);
            this.btnAreverse.Name = "btnAreverse";
            this.btnAreverse.Size = new System.Drawing.Size(108, 23);
            this.btnAreverse.TabIndex = 7;
            this.btnAreverse.Text = "Array Reverse";
            this.btnAreverse.UseVisualStyleBackColor = true;
            this.btnAreverse.Click += new System.EventHandler(this.BtnAreverse_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 248);
            this.Controls.Add(this.btnAreverse);
            this.Controls.Add(this.btnAsort);
            this.Controls.Add(this.btnAresize);
            this.Controls.Add(this.btnAlast);
            this.Controls.Add(this.btnAind);
            this.Controls.Add(this.btnAcopy);
            this.Controls.Add(this.btnAclear);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAclear;
        private System.Windows.Forms.Button btnAcopy;
        private System.Windows.Forms.Button btnAind;
        private System.Windows.Forms.Button btnAlast;
        private System.Windows.Forms.Button btnAresize;
        private System.Windows.Forms.Button btnAsort;
        private System.Windows.Forms.Button btnAreverse;
    }
}