﻿
namespace EProdajaRacunarskeOpreme.WinUI.Narudzba
{
    partial class frmPrikazNarudzbe
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Novi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PrikaziNabavku = new System.Windows.Forms.Button();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Narudzba = new System.Windows.Forms.DataGridView();
            this.BrojNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Narudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Novi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_PrikaziNabavku);
            this.groupBox2.Controls.Add(this.txtBroj);
            this.groupBox2.Location = new System.Drawing.Point(34, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // btn_Novi
            // 
            this.btn_Novi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Novi.Location = new System.Drawing.Point(628, 58);
            this.btn_Novi.Name = "btn_Novi";
            this.btn_Novi.Size = new System.Drawing.Size(102, 20);
            this.btn_Novi.TabIndex = 3;
            this.btn_Novi.Text = "Nova narudzba";
            this.btn_Novi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novi.UseVisualStyleBackColor = true;
            this.btn_Novi.Click += new System.EventHandler(this.btn_Novi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj narudzbe";
            // 
            // btn_PrikaziNabavku
            // 
            this.btn_PrikaziNabavku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_PrikaziNabavku.Location = new System.Drawing.Point(487, 58);
            this.btn_PrikaziNabavku.Name = "btn_PrikaziNabavku";
            this.btn_PrikaziNabavku.Size = new System.Drawing.Size(102, 20);
            this.btn_PrikaziNabavku.TabIndex = 1;
            this.btn_PrikaziNabavku.Text = "Prikazi";
            this.btn_PrikaziNabavku.UseVisualStyleBackColor = true;
            this.btn_PrikaziNabavku.Click += new System.EventHandler(this.btn_PrikaziNabavku_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.Location = new System.Drawing.Point(23, 58);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(208, 20);
            this.txtBroj.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Narudzba);
            this.groupBox1.Location = new System.Drawing.Point(28, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narudzba";
            // 
            // dgv_Narudzba
            // 
            this.dgv_Narudzba.AllowUserToAddRows = false;
            this.dgv_Narudzba.AllowUserToDeleteRows = false;
            this.dgv_Narudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Narudzba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojNarudzbe,
            this.Datum,
            this.Status,
            this.Klijent});
            this.dgv_Narudzba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Narudzba.Location = new System.Drawing.Point(3, 16);
            this.dgv_Narudzba.Name = "dgv_Narudzba";
            this.dgv_Narudzba.ReadOnly = true;
            this.dgv_Narudzba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Narudzba.Size = new System.Drawing.Size(739, 262);
            this.dgv_Narudzba.TabIndex = 0;
            this.dgv_Narudzba.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Narudzba_CellContentDoubleClick);
            // 
            // BrojNarudzbe
            // 
            this.BrojNarudzbe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojNarudzbe.DataPropertyName = "BrojNarudzbe";
            this.BrojNarudzbe.HeaderText = "Šifra narudžbe";
            this.BrojNarudzbe.Name = "BrojNarudzbe";
            this.BrojNarudzbe.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum ";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status ";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Klijent
            // 
            this.Klijent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Klijent.DataPropertyName = "Klijent";
            this.Klijent.HeaderText = "Klijent";
            this.Klijent.Name = "Klijent";
            this.Klijent.ReadOnly = true;
            this.Klijent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Klijent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmPrikazNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazNarudzbe";
            this.Text = "frmPrikazNarudzbe";
            this.Load += new System.EventHandler(this.frmPrikazNarudzbe_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Narudzba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Novi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrikaziNabavku;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Narudzba;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klijent;
    }
}