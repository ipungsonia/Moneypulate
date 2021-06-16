
namespace Moneypulate
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
            this.btnCari = new System.Windows.Forms.Button();
            this.btnBuat = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.tbCariNama = new System.Windows.Forms.TextBox();
            this.tNama = new System.Windows.Forms.Label();
            this.tIncome = new System.Windows.Forms.Label();
            this.tOutcome = new System.Windows.Forms.Label();
            this.tProlog = new System.Windows.Forms.Label();
            this.tDanrat = new System.Windows.Forms.Label();
            this.tDanis = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblPenghasilan = new System.Windows.Forms.Label();
            this.lblPengeluaran = new System.Windows.Forms.Label();
            this.lblDanaDarurat = new System.Windows.Forms.Label();
            this.lblDanaInvestasi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(796, 33);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(222, 48);
            this.btnCari.TabIndex = 0;
            this.btnCari.Text = "Cari Catatan";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnBuat
            // 
            this.btnBuat.Location = new System.Drawing.Point(56, 40);
            this.btnBuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuat.Name = "btnBuat";
            this.btnBuat.Size = new System.Drawing.Size(222, 49);
            this.btnBuat.TabIndex = 1;
            this.btnBuat.Text = "Buat Catatan";
            this.btnBuat.UseVisualStyleBackColor = true;
            this.btnBuat.Click += new System.EventHandler(this.btnBuat_Click_1);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(56, 129);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(222, 49);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah Catatan";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // tbCariNama
            // 
            this.tbCariNama.Location = new System.Drawing.Point(344, 40);
            this.tbCariNama.Margin = new System.Windows.Forms.Padding(4);
            this.tbCariNama.Name = "tbCariNama";
            this.tbCariNama.Size = new System.Drawing.Size(408, 34);
            this.tbCariNama.TabIndex = 3;
            // 
            // tNama
            // 
            this.tNama.AutoSize = true;
            this.tNama.Location = new System.Drawing.Point(339, 108);
            this.tNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tNama.Name = "tNama";
            this.tNama.Size = new System.Drawing.Size(92, 25);
            this.tNama.TabIndex = 4;
            this.tNama.Text = "Nama :";
            // 
            // tIncome
            // 
            this.tIncome.AutoSize = true;
            this.tIncome.Location = new System.Drawing.Point(339, 153);
            this.tIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tIncome.Name = "tIncome";
            this.tIncome.Size = new System.Drawing.Size(154, 25);
            this.tIncome.TabIndex = 5;
            this.tIncome.Text = "Penghasilan :";
            // 
            // tOutcome
            // 
            this.tOutcome.AutoSize = true;
            this.tOutcome.Location = new System.Drawing.Point(339, 202);
            this.tOutcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tOutcome.Name = "tOutcome";
            this.tOutcome.Size = new System.Drawing.Size(162, 25);
            this.tOutcome.TabIndex = 6;
            this.tOutcome.Text = "Pengeluaran :";
            // 
            // tProlog
            // 
            this.tProlog.AutoSize = true;
            this.tProlog.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tProlog.Location = new System.Drawing.Point(339, 258);
            this.tProlog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tProlog.Name = "tProlog";
            this.tProlog.Size = new System.Drawing.Size(540, 26);
            this.tProlog.TabIndex = 7;
            this.tProlog.Text = "Uang yang sebaiknya disisihkan untuk keperluan";
            // 
            // tDanrat
            // 
            this.tDanrat.AutoSize = true;
            this.tDanrat.Location = new System.Drawing.Point(339, 314);
            this.tDanrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tDanrat.Name = "tDanrat";
            this.tDanrat.Size = new System.Drawing.Size(170, 25);
            this.tDanrat.TabIndex = 8;
            this.tDanrat.Text = "Dana Darurat :";
            // 
            // tDanis
            // 
            this.tDanis.AutoSize = true;
            this.tDanis.Location = new System.Drawing.Point(339, 355);
            this.tDanis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tDanis.Name = "tDanis";
            this.tDanis.Size = new System.Drawing.Size(180, 25);
            this.tDanis.TabIndex = 9;
            this.tDanis.Text = "Dana Investasi :";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(536, 108);
            this.lblNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(19, 25);
            this.lblNama.TabIndex = 10;
            this.lblNama.Text = "-";
            // 
            // lblPenghasilan
            // 
            this.lblPenghasilan.AutoSize = true;
            this.lblPenghasilan.Location = new System.Drawing.Point(536, 153);
            this.lblPenghasilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPenghasilan.Name = "lblPenghasilan";
            this.lblPenghasilan.Size = new System.Drawing.Size(19, 25);
            this.lblPenghasilan.TabIndex = 11;
            this.lblPenghasilan.Text = "-";
            // 
            // lblPengeluaran
            // 
            this.lblPengeluaran.AutoSize = true;
            this.lblPengeluaran.Location = new System.Drawing.Point(536, 202);
            this.lblPengeluaran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPengeluaran.Name = "lblPengeluaran";
            this.lblPengeluaran.Size = new System.Drawing.Size(19, 25);
            this.lblPengeluaran.TabIndex = 12;
            this.lblPengeluaran.Text = "-";
            // 
            // lblDanaDarurat
            // 
            this.lblDanaDarurat.AutoSize = true;
            this.lblDanaDarurat.Location = new System.Drawing.Point(536, 314);
            this.lblDanaDarurat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanaDarurat.Name = "lblDanaDarurat";
            this.lblDanaDarurat.Size = new System.Drawing.Size(19, 25);
            this.lblDanaDarurat.TabIndex = 13;
            this.lblDanaDarurat.Text = "-";
            // 
            // lblDanaInvestasi
            // 
            this.lblDanaInvestasi.AutoSize = true;
            this.lblDanaInvestasi.Location = new System.Drawing.Point(536, 355);
            this.lblDanaInvestasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanaInvestasi.Name = "lblDanaInvestasi";
            this.lblDanaInvestasi.Size = new System.Drawing.Size(19, 25);
            this.lblDanaInvestasi.TabIndex = 14;
            this.lblDanaInvestasi.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "/  bulan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(764, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "/  bulan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDanaInvestasi);
            this.Controls.Add(this.lblDanaDarurat);
            this.Controls.Add(this.lblPengeluaran);
            this.Controls.Add(this.lblPenghasilan);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.tDanis);
            this.Controls.Add(this.tDanrat);
            this.Controls.Add(this.tProlog);
            this.Controls.Add(this.tOutcome);
            this.Controls.Add(this.tIncome);
            this.Controls.Add(this.tNama);
            this.Controls.Add(this.tbCariNama);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnBuat);
            this.Controls.Add(this.btnCari);
            this.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Welcome to Moneypulate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnBuat;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.TextBox tbCariNama;
        private System.Windows.Forms.Label tNama;
        private System.Windows.Forms.Label tIncome;
        private System.Windows.Forms.Label tOutcome;
        private System.Windows.Forms.Label tProlog;
        private System.Windows.Forms.Label tDanrat;
        private System.Windows.Forms.Label tDanis;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblPenghasilan;
        private System.Windows.Forms.Label lblPengeluaran;
        private System.Windows.Forms.Label lblDanaDarurat;
        private System.Windows.Forms.Label lblDanaInvestasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

