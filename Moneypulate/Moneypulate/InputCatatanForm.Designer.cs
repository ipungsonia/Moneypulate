
namespace Moneypulate
{
    partial class InputCatatanForm
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
            this.pNama = new System.Windows.Forms.Label();
            this.pIncome = new System.Windows.Forms.Label();
            this.pOutcome = new System.Windows.Forms.Label();
            this.pStatus = new System.Windows.Forms.Label();
            this.btnAksi = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbPenghasilan = new System.Windows.Forms.TextBox();
            this.tbPengeluaran = new System.Windows.Forms.TextBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // pNama
            // 
            this.pNama.AutoSize = true;
            this.pNama.Location = new System.Drawing.Point(66, 44);
            this.pNama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pNama.Name = "pNama";
            this.pNama.Size = new System.Drawing.Size(92, 25);
            this.pNama.TabIndex = 0;
            this.pNama.Text = "Nama :";
            // 
            // pIncome
            // 
            this.pIncome.AutoSize = true;
            this.pIncome.Location = new System.Drawing.Point(66, 108);
            this.pIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pIncome.Name = "pIncome";
            this.pIncome.Size = new System.Drawing.Size(154, 25);
            this.pIncome.TabIndex = 1;
            this.pIncome.Text = "Penghasilan :";
            // 
            // pOutcome
            // 
            this.pOutcome.AutoSize = true;
            this.pOutcome.Location = new System.Drawing.Point(66, 169);
            this.pOutcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pOutcome.Name = "pOutcome";
            this.pOutcome.Size = new System.Drawing.Size(162, 25);
            this.pOutcome.TabIndex = 2;
            this.pOutcome.Text = "Pengeluaran :";
            // 
            // pStatus
            // 
            this.pStatus.AutoSize = true;
            this.pStatus.Location = new System.Drawing.Point(66, 236);
            this.pStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(88, 25);
            this.pStatus.TabIndex = 3;
            this.pStatus.Text = "Status :";
            // 
            // btnAksi
            // 
            this.btnAksi.Location = new System.Drawing.Point(499, 418);
            this.btnAksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAksi.Name = "btnAksi";
            this.btnAksi.Size = new System.Drawing.Size(150, 39);
            this.btnAksi.TabIndex = 7;
            this.btnAksi.Text = "Aksi";
            this.btnAksi.UseVisualStyleBackColor = true;
            this.btnAksi.Click += new System.EventHandler(this.btnAksi_Click);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(267, 36);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(221, 34);
            this.tbNama.TabIndex = 9;
            // 
            // tbPenghasilan
            // 
            this.tbPenghasilan.Location = new System.Drawing.Point(267, 104);
            this.tbPenghasilan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPenghasilan.Name = "tbPenghasilan";
            this.tbPenghasilan.Size = new System.Drawing.Size(221, 34);
            this.tbPenghasilan.TabIndex = 10;
            // 
            // tbPengeluaran
            // 
            this.tbPengeluaran.Location = new System.Drawing.Point(267, 169);
            this.tbPengeluaran.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPengeluaran.Name = "tbPengeluaran";
            this.tbPengeluaran.Size = new System.Drawing.Size(221, 34);
            this.tbPengeluaran.TabIndex = 11;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(267, 234);
            this.rbA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(142, 29);
            this.rbA.TabIndex = 12;
            this.rbA.TabStop = true;
            this.rbA.Text = "Melajang";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(267, 283);
            this.rbB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(365, 29);
            this.rbB.TabIndex = 13;
            this.rbB.TabStop = true;
            this.rbB.Text = "Menikah, belum memiliki anak";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(267, 332);
            this.rbC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(289, 29);
            this.rbC.TabIndex = 14;
            this.rbC.TabStop = true;
            this.rbC.Text = "Menikah, memiliki anak";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // InputCatatanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 492);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.tbPengeluaran);
            this.Controls.Add(this.tbPenghasilan);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btnAksi);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.pOutcome);
            this.Controls.Add(this.pIncome);
            this.Controls.Add(this.pNama);
            this.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InputCatatanForm";
            this.Text = "Lengkapi Data Diri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pNama;
        private System.Windows.Forms.Label pIncome;
        private System.Windows.Forms.Label pOutcome;
        private System.Windows.Forms.Label pStatus;
        private System.Windows.Forms.Button btnAksi;
        private System.Windows.Forms.TextBox tbNama;
        protected System.Windows.Forms.RadioButton rbA;
        protected System.Windows.Forms.TextBox tbPenghasilan;
        protected System.Windows.Forms.TextBox tbPengeluaran;
        protected System.Windows.Forms.RadioButton rbB;
        protected System.Windows.Forms.RadioButton rbC;
    }
}