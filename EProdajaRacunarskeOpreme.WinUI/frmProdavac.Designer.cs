
namespace EProdajaRacunarskeOpreme.WinUI
{
    partial class frmProdavac
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
            this.btnNabavke = new System.Windows.Forms.Button();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNabavke
            // 
            this.btnNabavke.BackColor = System.Drawing.Color.MistyRose;
            this.btnNabavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNabavke.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnNabavke.Location = new System.Drawing.Point(68, 79);
            this.btnNabavke.Name = "btnNabavke";
            this.btnNabavke.Size = new System.Drawing.Size(231, 60);
            this.btnNabavke.TabIndex = 0;
            this.btnNabavke.Text = "Nabavke";
            this.btnNabavke.UseVisualStyleBackColor = false;
            this.btnNabavke.Click += new System.EventHandler(this.btnNabavke_Click);
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.BackColor = System.Drawing.Color.MistyRose;
            this.btnNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbe.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnNarudzbe.Location = new System.Drawing.Point(68, 205);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(231, 60);
            this.btnNarudzbe.TabIndex = 1;
            this.btnNarudzbe.Text = "Narudzbe";
            this.btnNarudzbe.UseVisualStyleBackColor = false;
            this.btnNarudzbe.Click += new System.EventHandler(this.btnNarudzbe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Location = new System.Drawing.Point(395, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 354);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EProdajaRacunarskeOpreme.WinUI.Properties.Resources.shopping_cart_trolley_supermarket_store_outline_flat_illustration_isolated_white_background_shopping_cart_trolley_135365708;
            this.pictureBox1.Location = new System.Drawing.Point(502, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmProdavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNarudzbe);
            this.Controls.Add(this.btnNabavke);
            this.Name = "frmProdavac";
            this.Text = "frmProdavac";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNabavke;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}