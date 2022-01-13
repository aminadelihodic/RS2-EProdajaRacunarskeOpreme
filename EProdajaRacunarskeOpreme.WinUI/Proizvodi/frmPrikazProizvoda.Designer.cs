
namespace EProdajaRacunarskeOpreme.WinUI.Proizvodi
{
    partial class frmPrikazProizvoda
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
            this.btn_PrikaziProizvod = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Proizvodi = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaProizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Novi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_PrikaziProizvod);
            this.groupBox2.Controls.Add(this.txtNaziv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox2.Location = new System.Drawing.Point(34, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // btn_Novi
            // 
            this.btn_Novi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Novi.Location = new System.Drawing.Point(621, 58);
            this.btn_Novi.Name = "btn_Novi";
            this.btn_Novi.Size = new System.Drawing.Size(109, 28);
            this.btn_Novi.TabIndex = 3;
            this.btn_Novi.Text = "Novi proizvod";
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
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv";
            // 
            // btn_PrikaziProizvod
            // 
            this.btn_PrikaziProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrikaziProizvod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_PrikaziProizvod.Location = new System.Drawing.Point(487, 58);
            this.btn_PrikaziProizvod.Name = "btn_PrikaziProizvod";
            this.btn_PrikaziProizvod.Size = new System.Drawing.Size(102, 28);
            this.btn_PrikaziProizvod.TabIndex = 1;
            this.btn_PrikaziProizvod.Text = "Prikazi";
            this.btn_PrikaziProizvod.UseVisualStyleBackColor = true;
            this.btn_PrikaziProizvod.Click += new System.EventHandler(this.btn_PrikaziProizvod_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.LightGray;
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaziv.Location = new System.Drawing.Point(23, 58);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(208, 21);
            this.txtNaziv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Proizvodi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox1.Location = new System.Drawing.Point(28, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi";
            // 
            // dgv_Proizvodi
            // 
            this.dgv_Proizvodi.AllowUserToAddRows = false;
            this.dgv_Proizvodi.AllowUserToDeleteRows = false;
            this.dgv_Proizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.VrstaProizvoda,
            this.Proizvodjac});
            this.dgv_Proizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Proizvodi.Location = new System.Drawing.Point(3, 17);
            this.dgv_Proizvodi.Name = "dgv_Proizvodi";
            this.dgv_Proizvodi.ReadOnly = true;
            this.dgv_Proizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Proizvodi.Size = new System.Drawing.Size(739, 261);
            this.dgv_Proizvodi.TabIndex = 0;
            this.dgv_Proizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Proizvodi_CellContentClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // VrstaProizvoda
            // 
            this.VrstaProizvoda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VrstaProizvoda.DataPropertyName = "VrstaProizvoda";
            this.VrstaProizvoda.HeaderText = "Vrsta proizvoda";
            this.VrstaProizvoda.Name = "VrstaProizvoda";
            this.VrstaProizvoda.ReadOnly = true;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proizvodjac.DataPropertyName = "Proizvodjac";
            this.Proizvodjac.HeaderText = "Proizvodjac";
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.ReadOnly = true;
            // 
            // frmPrikazProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazProizvoda";
            this.Text = "frmPrikazProizvoda";
            this.Load += new System.EventHandler(this.frmPrikazProizvoda_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proizvodi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Novi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrikaziProizvod;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Proizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodjac;
    }
}