namespace Odev
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
            this.BtnDosyaAl = new System.Windows.Forms.Button();
            this.btnStackeOku = new System.Windows.Forms.Button();
            this.lstBoxBilgi = new System.Windows.Forms.ListBox();
            this.txtBoxKelimeAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDosyaAl
            // 
            this.BtnDosyaAl.Location = new System.Drawing.Point(40, 22);
            this.BtnDosyaAl.Name = "BtnDosyaAl";
            this.BtnDosyaAl.Size = new System.Drawing.Size(184, 45);
            this.BtnDosyaAl.TabIndex = 0;
            this.BtnDosyaAl.Text = "Dosya Al";
            this.BtnDosyaAl.UseVisualStyleBackColor = true;
            this.BtnDosyaAl.Click += new System.EventHandler(this.BtnDosyaAl_Click);
            // 
            // btnStackeOku
            // 
            this.btnStackeOku.Location = new System.Drawing.Point(268, 22);
            this.btnStackeOku.Name = "btnStackeOku";
            this.btnStackeOku.Size = new System.Drawing.Size(182, 46);
            this.btnStackeOku.TabIndex = 1;
            this.btnStackeOku.Text = "Stack\'e Oku";
            this.btnStackeOku.UseVisualStyleBackColor = true;
            this.btnStackeOku.Click += new System.EventHandler(this.btnStackeOku_Click);
            // 
            // lstBoxBilgi
            // 
            this.lstBoxBilgi.FormattingEnabled = true;
            this.lstBoxBilgi.ItemHeight = 20;
            this.lstBoxBilgi.Location = new System.Drawing.Point(40, 88);
            this.lstBoxBilgi.Name = "lstBoxBilgi";
            this.lstBoxBilgi.Size = new System.Drawing.Size(410, 324);
            this.lstBoxBilgi.TabIndex = 2;
            // 
            // txtBoxKelimeAra
            // 
            this.txtBoxKelimeAra.Location = new System.Drawing.Point(528, 88);
            this.txtBoxKelimeAra.Name = "txtBoxKelimeAra";
            this.txtBoxKelimeAra.Size = new System.Drawing.Size(286, 26);
            this.txtBoxKelimeAra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(523, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aranacak Kelimeyi Giriniz:";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(528, 135);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(286, 42);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Arama";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAgacaAktar.Location = new System.Drawing.Point(40, 436);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(410, 68);
            this.btnAgacaAktar.TabIndex = 6;
            this.btnAgacaAktar.Text = "Metindeki Kelimeleri Ağaca Aktarma";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 573);
            this.Controls.Add(this.btnAgacaAktar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxKelimeAra);
            this.Controls.Add(this.lstBoxBilgi);
            this.Controls.Add(this.btnStackeOku);
            this.Controls.Add(this.BtnDosyaAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDosyaAl;
        private System.Windows.Forms.Button btnStackeOku;
        private System.Windows.Forms.ListBox lstBoxBilgi;
        private System.Windows.Forms.TextBox txtBoxKelimeAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnAgacaAktar;
    }
}

