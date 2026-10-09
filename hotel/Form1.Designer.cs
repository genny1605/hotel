namespace hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chk_parcheggio = new System.Windows.Forms.CheckBox();
            this.cmb_selezionesrtagione = new System.Windows.Forms.ComboBox();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.txt_giorni = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_parcheggio
            // 
            this.chk_parcheggio.AutoSize = true;
            this.chk_parcheggio.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_parcheggio.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk_parcheggio.Location = new System.Drawing.Point(203, 229);
            this.chk_parcheggio.Name = "chk_parcheggio";
            this.chk_parcheggio.Size = new System.Drawing.Size(89, 30);
            this.chk_parcheggio.TabIndex = 0;
            this.chk_parcheggio.Text = "parcheggio";
            this.chk_parcheggio.UseVisualStyleBackColor = true;
            // 
            // cmb_selezionesrtagione
            // 
            this.cmb_selezionesrtagione.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_selezionesrtagione.ForeColor = System.Drawing.Color.Fuchsia;
            this.cmb_selezionesrtagione.FormattingEnabled = true;
            this.cmb_selezionesrtagione.Items.AddRange(new object[] {
            "bassa stagione",
            "media stagione",
            "alta stagione"});
            this.cmb_selezionesrtagione.Location = new System.Drawing.Point(15, 127);
            this.cmb_selezionesrtagione.Name = "cmb_selezionesrtagione";
            this.cmb_selezionesrtagione.Size = new System.Drawing.Size(152, 34);
            this.cmb_selezionesrtagione.TabIndex = 1;
            this.cmb_selezionesrtagione.Text = "seleziona la stagione";
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_titolo.Location = new System.Drawing.Point(346, 9);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(278, 45);
            this.lbl_titolo.TabIndex = 3;
            this.lbl_titolo.Text = "Benvenuti all\'hotel Blu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, -250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 211);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(12, 63);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(319, 17);
            this.lbl_n1.TabIndex = 6;
            this.lbl_n1.Text = "immaginati un eseperienza di totale relax e confort";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(9, 85);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(658, 17);
            this.lbl_n2.TabIndex = 7;
            this.lbl_n2.Text = "all\'interno della nostra struttura situata lungo mare dove potrai riposarti duran" +
    "te i tuoi gioirni di vacanza";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(12, 188);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(329, 18);
            this.lbl_n3.TabIndex = 8;
            this.lbl_n3.Text = "inserisci quanti giorni vuoi soggiornare nell\'hotel";
            // 
            // txt_giorni
            // 
            this.txt_giorni.Location = new System.Drawing.Point(354, 189);
            this.txt_giorni.Name = "txt_giorni";
            this.txt_giorni.Size = new System.Drawing.Size(100, 20);
            this.txt_giorni.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(690, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(12, 234);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(160, 15);
            this.lbl_n4.TabIndex = 11;
            this.lbl_n4.Text = "vuoi prenotare il parcheggio?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 480);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_giorni);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_titolo);
            this.Controls.Add(this.cmb_selezionesrtagione);
            this.Controls.Add(this.chk_parcheggio);
            this.Name = "Form1";
            this.Text = "seleziona la stagione";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_parcheggio;
        private System.Windows.Forms.ComboBox cmb_selezionesrtagione;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.TextBox txt_giorni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_n4;
    }
}

