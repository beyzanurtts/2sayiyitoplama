namespace Basit_Sayı_Toplama_Uygulaması
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(55, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(31, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "sayi1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(55, 86);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(31, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "sayi2";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(55, 123);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(36, 13);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "sonuc";
            this.lblSonuc.Click += new System.EventHandler(this.lblSonuc_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(58, 149);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(135, 34);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "İki Sayı Topla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(92, 38);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(88, 20);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(92, 86);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(88, 20);
            this.txt2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 297);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}

