
namespace EProdajaRacunarskeOpreme.WinUI.Dobavljaci
{
    partial class frmPrikazDobavljaca
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
            this.btn_PrikaziDobavljaca = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Dobavljaci = new System.Windows.Forms.DataGridView();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZiroRacuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Novi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_PrikaziDobavljaca);
            this.groupBox2.Controls.Add(this.txtPretraga);
            this.groupBox2.Location = new System.Drawing.Point(34, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // btn_Novi
            // 
            this.btn_Novi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Novi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Novi.Location = new System.Drawing.Point(628, 58);
            this.btn_Novi.Name = "btn_Novi";
            this.btn_Novi.Size = new System.Drawing.Size(102, 20);
            this.btn_Novi.TabIndex = 3;
            this.btn_Novi.Text = "Novi dobavljac";
            this.btn_Novi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novi.UseVisualStyleBackColor = false;
            this.btn_Novi.Click += new System.EventHandler(this.btn_Novi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv";
            // 
            // btn_PrikaziDobavljaca
            // 
            this.btn_PrikaziDobavljaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_PrikaziDobavljaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_PrikaziDobavljaca.Location = new System.Drawing.Point(487, 58);
            this.btn_PrikaziDobavljaca.Name = "btn_PrikaziDobavljaca";
            this.btn_PrikaziDobavljaca.Size = new System.Drawing.Size(102, 20);
            this.btn_PrikaziDobavljaca.TabIndex = 1;
            this.btn_PrikaziDobavljaca.Text = "Prikazi";
            this.btn_PrikaziDobavljaca.UseVisualStyleBackColor = false;
            this.btn_PrikaziDobavljaca.Click += new System.EventHandler(this.btn_PrikaziDobavljaca_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPretraga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretraga.ForeColor = System.Drawing.Color.Black;
            this.txtPretraga.Location = new System.Drawing.Point(23, 58);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(208, 13);
            this.txtPretraga.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Dobavljaci);
            this.groupBox1.Location = new System.Drawing.Point(28, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dobavljaci";
            // 
            // dgv_Dobavljaci
            // 
            this.dgv_Dobavljaci.AllowUserToAddRows = false;
            this.dgv_Dobavljaci.AllowUserToDeleteRows = false;
            this.dgv_Dobavljaci.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_Dobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KontaktOsoba,
            this.Adresa,
            this.Email,
            this.Telefon,
            this.ZiroRacuni});
            this.dgv_Dobavljaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Dobavljaci.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_Dobavljaci.Location = new System.Drawing.Point(3, 16);
            this.dgv_Dobavljaci.Name = "dgv_Dobavljaci";
            this.dgv_Dobavljaci.ReadOnly = true;
            this.dgv_Dobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Dobavljaci.Size = new System.Drawing.Size(739, 262);
            this.dgv_Dobavljaci.TabIndex = 0;
            this.dgv_Dobavljaci.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Dobavljaci_CellContentDoubleClick);
            // 
            // KontaktOsoba
            // 
            this.KontaktOsoba.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KontaktOsoba.DataPropertyName = "KontaktOsoba";
            this.KontaktOsoba.HeaderText = "Kontakt";
            this.KontaktOsoba.Name = "KontaktOsoba";
            this.KontaktOsoba.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa ";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email ";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon ";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // ZiroRacuni
            // 
            this.ZiroRacuni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ZiroRacuni.DataPropertyName = "ZiroRacuni";
            this.ZiroRacuni.HeaderText = "Broj računa";
            this.ZiroRacuni.Name = "ZiroRacuni";
            this.ZiroRacuni.ReadOnly = true;
            // 
            // frmPrikazDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazDobavljaca";
            this.Text = "frmPrikazDobavljaca";
            this.Load += new System.EventHandler(this.frmPrikazDobavljaca_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dobavljaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Novi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PrikaziDobavljaca;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Dobavljaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZiroRacuni;
    }
}