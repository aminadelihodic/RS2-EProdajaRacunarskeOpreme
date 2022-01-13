
namespace EProdajaRacunarskeOpreme.WinUI.Nabavka
{
    partial class frmNovaNabavka
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
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cmbDob = new System.Windows.Forms.ComboBox();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.dtp_Datum = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Kolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojNabavke = new System.Windows.Forms.TextBox();
            this.btn_Nabavka = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.Color.LightGray;
            this.txtCijena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCijena.Location = new System.Drawing.Point(198, 252);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(177, 20);
            this.txtCijena.TabIndex = 93;
            // 
            // cmbDob
            // 
            this.cmbDob.BackColor = System.Drawing.Color.LightGray;
            this.cmbDob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDob.ForeColor = System.Drawing.Color.Black;
            this.cmbDob.FormattingEnabled = true;
            this.cmbDob.Location = new System.Drawing.Point(198, 85);
            this.cmbDob.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDob.Name = "cmbDob";
            this.cmbDob.Size = new System.Drawing.Size(177, 21);
            this.cmbDob.TabIndex = 92;
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.BackColor = System.Drawing.Color.LightGray;
            this.cmbKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(198, 132);
            this.cmbKorisnik.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(177, 21);
            this.cmbKorisnik.TabIndex = 91;
            // 
            // dtp_Datum
            // 
            this.dtp_Datum.Location = new System.Drawing.Point(198, 305);
            this.dtp_Datum.Name = "dtp_Datum";
            this.dtp_Datum.Size = new System.Drawing.Size(177, 20);
            this.dtp_Datum.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(78, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Dobavljac";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(78, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Korisnik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(79, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Kolicina";
            // 
            // txt_Kolicina
            // 
            this.txt_Kolicina.BackColor = System.Drawing.Color.LightGray;
            this.txt_Kolicina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Kolicina.Location = new System.Drawing.Point(198, 191);
            this.txt_Kolicina.Name = "txt_Kolicina";
            this.txt_Kolicina.Size = new System.Drawing.Size(177, 20);
            this.txt_Kolicina.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(79, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(79, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Sifra nabavke";
            // 
            // txtBrojNabavke
            // 
            this.txtBrojNabavke.BackColor = System.Drawing.Color.LightGray;
            this.txtBrojNabavke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrojNabavke.Location = new System.Drawing.Point(200, 33);
            this.txtBrojNabavke.Name = "txtBrojNabavke";
            this.txtBrojNabavke.Size = new System.Drawing.Size(175, 20);
            this.txtBrojNabavke.TabIndex = 82;
            // 
            // btn_Nabavka
            // 
            this.btn_Nabavka.BackColor = System.Drawing.Color.Silver;
            this.btn_Nabavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nabavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Nabavka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Nabavka.Location = new System.Drawing.Point(82, 347);
            this.btn_Nabavka.Name = "btn_Nabavka";
            this.btn_Nabavka.Size = new System.Drawing.Size(290, 35);
            this.btn_Nabavka.TabIndex = 94;
            this.btn_Nabavka.Text = "Sačuvaj";
            this.btn_Nabavka.UseVisualStyleBackColor = false;
            this.btn_Nabavka.Click += new System.EventHandler(this.btn_Nabavka_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmNovaNabavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btn_Nabavka);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cmbDob);
            this.Controls.Add(this.cmbKorisnik);
            this.Controls.Add(this.dtp_Datum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Kolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojNabavke);
            this.Name = "frmNovaNabavka";
            this.Text = "frmNovaNabavka";
            this.Load += new System.EventHandler(this.frmNovaNabavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cmbDob;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.DateTimePicker dtp_Datum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Kolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojNabavke;
        private System.Windows.Forms.Button btn_Nabavka;
        private System.Windows.Forms.ErrorProvider err;
    }
}