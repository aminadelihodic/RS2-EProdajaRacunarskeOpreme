
namespace EProdajaRacunarskeOpreme.WinUI.Narudzba
{
    partial class frmDodajUrediNarudzbu
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
            this.components = new System.ComponentModel.Container();
            this.btn_Nabavka = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojNabavke = new System.Windows.Forms.TextBox();
            this.ck_Otkazano = new System.Windows.Forms.CheckBox();
            this.ck_Status = new System.Windows.Forms.CheckBox();
            this.dtp_Datum = new System.Windows.Forms.DateTimePicker();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nabavka
            // 
            this.btn_Nabavka.BackColor = System.Drawing.Color.Silver;
            this.btn_Nabavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nabavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Nabavka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Nabavka.Location = new System.Drawing.Point(302, 395);
            this.btn_Nabavka.Name = "btn_Nabavka";
            this.btn_Nabavka.Size = new System.Drawing.Size(205, 35);
            this.btn_Nabavka.TabIndex = 74;
            this.btn_Nabavka.Text = "Sačuvaj";
            this.btn_Nabavka.UseVisualStyleBackColor = false;
            this.btn_Nabavka.Click += new System.EventHandler(this.btn_Nabavka_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(66, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Klijent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(64, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Šifra narudžbe";
            // 
            // txtBrojNabavke
            // 
            this.txtBrojNabavke.BackColor = System.Drawing.Color.LightGray;
            this.txtBrojNabavke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrojNabavke.Location = new System.Drawing.Point(216, 30);
            this.txtBrojNabavke.Name = "txtBrojNabavke";
            this.txtBrojNabavke.Size = new System.Drawing.Size(205, 20);
            this.txtBrojNabavke.TabIndex = 66;
            // 
            // ck_Otkazano
            // 
            this.ck_Otkazano.AutoSize = true;
            this.ck_Otkazano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ck_Otkazano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ck_Otkazano.Location = new System.Drawing.Point(216, 196);
            this.ck_Otkazano.Name = "ck_Otkazano";
            this.ck_Otkazano.Size = new System.Drawing.Size(80, 17);
            this.ck_Otkazano.TabIndex = 81;
            this.ck_Otkazano.Text = "Otkazano";
            this.ck_Otkazano.UseVisualStyleBackColor = true;
            // 
            // ck_Status
            // 
            this.ck_Status.AutoSize = true;
            this.ck_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ck_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ck_Status.Location = new System.Drawing.Point(367, 196);
            this.ck_Status.Name = "ck_Status";
            this.ck_Status.Size = new System.Drawing.Size(62, 17);
            this.ck_Status.TabIndex = 82;
            this.ck_Status.Text = "Status";
            this.ck_Status.UseVisualStyleBackColor = true;
            // 
            // dtp_Datum
            // 
            this.dtp_Datum.Location = new System.Drawing.Point(216, 154);
            this.dtp_Datum.Name = "dtp_Datum";
            this.dtp_Datum.Size = new System.Drawing.Size(207, 20);
            this.dtp_Datum.TabIndex = 83;
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.BackColor = System.Drawing.Color.LightGray;
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(216, 114);
            this.cmbKlijent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(207, 21);
            this.cmbKlijent.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(66, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "Cijena narudžbe";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AllowUserToDeleteRows = false;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proizvod,
            this.Cijena,
            this.Količina,
            this.UkupnaCijena});
            this.dgvStavke.Location = new System.Drawing.Point(44, 229);
            this.dgvStavke.MultiSelect = false;
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavke.Size = new System.Drawing.Size(463, 132);
            this.dgvStavke.TabIndex = 95;
            // 
            // Proizvod
            // 
            this.Proizvod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proizvod.DataPropertyName = "Proizvod";
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.Name = "Proizvod";
            this.Proizvod.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Količina.DataPropertyName = "Kolicina";
            this.Količina.HeaderText = "Količina";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupna cijena";
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.Color.LightGray;
            this.txtCijena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCijena.Location = new System.Drawing.Point(216, 73);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(44, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Proizvod:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(299, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Količina: ";
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProizvod.ForeColor = System.Drawing.Color.Salmon;
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(109, 365);
            this.cmbProizvod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(182, 21);
            this.cmbProizvod.TabIndex = 99;
            // 
            // txtKolicina
            // 
            this.txtKolicina.BackColor = System.Drawing.Color.LightGray;
            this.txtKolicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKolicina.Location = new System.Drawing.Point(359, 365);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(67, 20);
            this.txtKolicina.TabIndex = 100;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStavku.ForeColor = System.Drawing.Color.LightCoral;
            this.btnDodajStavku.Location = new System.Drawing.Point(432, 363);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajStavku.TabIndex = 101;
            this.btnDodajStavku.Text = "Dodaj";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // frmDodajUrediNarudzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(530, 442);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.cmbProizvod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.dtp_Datum);
            this.Controls.Add(this.ck_Status);
            this.Controls.Add(this.ck_Otkazano);
            this.Controls.Add(this.btn_Nabavka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojNabavke);
            this.Name = "frmDodajUrediNarudzbu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajUrediNarudzbu";
            this.Load += new System.EventHandler(this.frmDodajUrediNarudzbu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Nabavka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojNabavke;
        private System.Windows.Forms.CheckBox ck_Otkazano;
        private System.Windows.Forms.CheckBox ck_Status;
        private System.Windows.Forms.DateTimePicker dtp_Datum;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
    }
}