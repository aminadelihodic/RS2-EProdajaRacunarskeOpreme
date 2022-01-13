
namespace EProdajaRacunarskeOpreme.WinUI.Nabavka
{
    partial class frmNabavka2
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
            this.dgv_Nabavka = new System.Windows.Forms.DataGridView();
            this.BrojNabavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dobavljac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nabavka)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Novi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_PrikaziNabavku);
            this.groupBox2.Controls.Add(this.txtBroj);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox2.Location = new System.Drawing.Point(34, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // btn_Novi
            // 
            this.btn_Novi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Novi.Location = new System.Drawing.Point(628, 58);
            this.btn_Novi.Name = "btn_Novi";
            this.btn_Novi.Size = new System.Drawing.Size(102, 30);
            this.btn_Novi.TabIndex = 3;
            this.btn_Novi.Text = "Nova nabavka";
            this.btn_Novi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novi.UseVisualStyleBackColor = true;
            this.btn_Novi.Click += new System.EventHandler(this.btn_Novi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj nabavke";
            // 
            // btn_PrikaziNabavku
            // 
            this.btn_PrikaziNabavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrikaziNabavku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_PrikaziNabavku.Location = new System.Drawing.Point(487, 58);
            this.btn_PrikaziNabavku.Name = "btn_PrikaziNabavku";
            this.btn_PrikaziNabavku.Size = new System.Drawing.Size(102, 30);
            this.btn_PrikaziNabavku.TabIndex = 1;
            this.btn_PrikaziNabavku.Text = "Prikazi";
            this.btn_PrikaziNabavku.UseVisualStyleBackColor = true;
            this.btn_PrikaziNabavku.Click += new System.EventHandler(this.btn_PrikaziNabavku_Click);
            // 
            // txtBroj
            // 
            this.txtBroj.BackColor = System.Drawing.Color.LightGray;
            this.txtBroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBroj.Location = new System.Drawing.Point(23, 58);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(208, 21);
            this.txtBroj.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Nabavka);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox1.Location = new System.Drawing.Point(28, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nabavka";
            // 
            // dgv_Nabavka
            // 
            this.dgv_Nabavka.AllowUserToAddRows = false;
            this.dgv_Nabavka.AllowUserToDeleteRows = false;
            this.dgv_Nabavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nabavka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojNabavke,
            this.Dobavljac,
            this.Korisnik,
            this.Datum,
            this.Kolicina});
            this.dgv_Nabavka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Nabavka.Location = new System.Drawing.Point(3, 17);
            this.dgv_Nabavka.Name = "dgv_Nabavka";
            this.dgv_Nabavka.ReadOnly = true;
            this.dgv_Nabavka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Nabavka.Size = new System.Drawing.Size(739, 261);
            this.dgv_Nabavka.TabIndex = 0;
            // 
            // BrojNabavke
            // 
            this.BrojNabavke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojNabavke.DataPropertyName = "BrojNabavke";
            this.BrojNabavke.HeaderText = "Šifra nabavke";
            this.BrojNabavke.Name = "BrojNabavke";
            this.BrojNabavke.ReadOnly = true;
            // 
            // Dobavljac
            // 
            this.Dobavljac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dobavljac.DataPropertyName = "Dobavljac";
            this.Dobavljac.HeaderText = "Dobavljac";
            this.Dobavljac.Name = "Dobavljac";
            this.Dobavljac.ReadOnly = true;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina ";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // frmNabavka2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNabavka2";
            this.Text = "frmNabavka2";
            this.Load += new System.EventHandler(this.frmNabavka2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nabavka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Novi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrikaziNabavku;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Nabavka;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dobavljac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
    }
}