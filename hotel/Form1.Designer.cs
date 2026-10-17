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
			this.cmb_selezionestagione = new System.Windows.Forms.ComboBox();
			this.lbl_titolo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbl_n1 = new System.Windows.Forms.Label();
			this.lbl_n2 = new System.Windows.Forms.Label();
			this.lbl_n3 = new System.Windows.Forms.Label();
			this.txt_giorni = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_n4 = new System.Windows.Forms.Label();
			this.btn_prenota = new System.Windows.Forms.Button();
			this.lbl_n5 = new System.Windows.Forms.Label();
			this.cmb_selezionecamera = new System.Windows.Forms.ComboBox();
			this.btn_informazioni = new System.Windows.Forms.Button();
			this.lbl_n6 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.lbl_n7 = new System.Windows.Forms.Label();
			this.lbl_n8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// chk_parcheggio
			// 
			this.chk_parcheggio.AutoSize = true;
			this.chk_parcheggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chk_parcheggio.ForeColor = System.Drawing.Color.Fuchsia;
			this.chk_parcheggio.Location = new System.Drawing.Point(283, 346);
			this.chk_parcheggio.Margin = new System.Windows.Forms.Padding(4);
			this.chk_parcheggio.Name = "chk_parcheggio";
			this.chk_parcheggio.Size = new System.Drawing.Size(157, 33);
			this.chk_parcheggio.TabIndex = 0;
			this.chk_parcheggio.Text = "parcheggio";
			this.chk_parcheggio.UseVisualStyleBackColor = true;
			// 
			// cmb_selezionestagione
			// 
			this.cmb_selezionestagione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_selezionestagione.ForeColor = System.Drawing.Color.Fuchsia;
			this.cmb_selezionestagione.FormattingEnabled = true;
			this.cmb_selezionestagione.Items.AddRange(new object[] {
            "bassa stagione",
            "media stagione",
            "alta stagione"});
			this.cmb_selezionestagione.Location = new System.Drawing.Point(386, 169);
			this.cmb_selezionestagione.Margin = new System.Windows.Forms.Padding(4);
			this.cmb_selezionestagione.Name = "cmb_selezionestagione";
			this.cmb_selezionestagione.Size = new System.Drawing.Size(216, 33);
			this.cmb_selezionestagione.TabIndex = 1;
			this.cmb_selezionestagione.Text = "seleziona la stagione";
			// 
			// lbl_titolo
			// 
			this.lbl_titolo.AutoSize = true;
			this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lbl_titolo.Location = new System.Drawing.Point(461, 11);
			this.lbl_titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_titolo.Name = "lbl_titolo";
			this.lbl_titolo.Size = new System.Drawing.Size(501, 54);
			this.lbl_titolo.TabIndex = 3;
			this.lbl_titolo.Text = "Benvenuti all\'hotel Blu";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(256, -308);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(449, 260);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// lbl_n1
			// 
			this.lbl_n1.AutoSize = true;
			this.lbl_n1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_n1.Location = new System.Drawing.Point(16, 78);
			this.lbl_n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_n1.Name = "lbl_n1";
			this.lbl_n1.Size = new System.Drawing.Size(403, 21);
			this.lbl_n1.TabIndex = 6;
			this.lbl_n1.Text = "immaginati un eseperienza di totale relax e confort";
			// 
			// lbl_n2
			// 
			this.lbl_n2.AutoSize = true;
			this.lbl_n2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_n2.Location = new System.Drawing.Point(16, 98);
			this.lbl_n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_n2.Name = "lbl_n2";
			this.lbl_n2.Size = new System.Drawing.Size(824, 21);
			this.lbl_n2.TabIndex = 7;
			this.lbl_n2.Text = "all\'interno della nostra struttura situata lungo mare dove potrai riposarti duran" +
    "te i tuoi gioirni di vacanza";
			// 
			// lbl_n3
			// 
			this.lbl_n3.AutoSize = true;
			this.lbl_n3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_n3.Location = new System.Drawing.Point(3, 294);
			this.lbl_n3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_n3.Name = "lbl_n3";
			this.lbl_n3.Size = new System.Drawing.Size(406, 22);
			this.lbl_n3.TabIndex = 8;
			this.lbl_n3.Text = "inserisci quanti giorni vuoi soggiornare nell\'hotel";
			// 
			// txt_giorni
			// 
			this.txt_giorni.Location = new System.Drawing.Point(470, 296);
			this.txt_giorni.Margin = new System.Windows.Forms.Padding(4);
			this.txt_giorni.Name = "txt_giorni";
			this.txt_giorni.Size = new System.Drawing.Size(132, 22);
			this.txt_giorni.TabIndex = 9;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(894, 69);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(375, 228);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// lbl_n4
			// 
			this.lbl_n4.AutoSize = true;
			this.lbl_n4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_n4.Location = new System.Drawing.Point(16, 352);
			this.lbl_n4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_n4.Name = "lbl_n4";
			this.lbl_n4.Size = new System.Drawing.Size(243, 22);
			this.lbl_n4.TabIndex = 11;
			this.lbl_n4.Text = "vuoi prenotare il parcheggio?";
			// 
			// btn_prenota
			// 
			this.btn_prenota.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_prenota.ForeColor = System.Drawing.Color.Fuchsia;
			this.btn_prenota.Location = new System.Drawing.Point(20, 419);
			this.btn_prenota.Margin = new System.Windows.Forms.Padding(4);
			this.btn_prenota.Name = "btn_prenota";
			this.btn_prenota.Size = new System.Drawing.Size(131, 43);
			this.btn_prenota.TabIndex = 12;
			this.btn_prenota.Text = "Prenota";
			this.btn_prenota.UseVisualStyleBackColor = true;
			this.btn_prenota.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbl_n5
			// 
			this.lbl_n5.AutoSize = true;
			this.lbl_n5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_n5.ForeColor = System.Drawing.Color.Fuchsia;
			this.lbl_n5.Location = new System.Drawing.Point(16, 497);
			this.lbl_n5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_n5.Name = "lbl_n5";
			this.lbl_n5.Size = new System.Drawing.Size(105, 22);
			this.lbl_n5.TabIndex = 13;
			this.lbl_n5.Text = "spesa totale:";
			// 
			// cmb_selezionecamera
			// 
			this.cmb_selezionecamera.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmb_selezionecamera.ForeColor = System.Drawing.Color.Fuchsia;
			this.cmb_selezionecamera.FormattingEnabled = true;
			this.cmb_selezionecamera.Items.AddRange(new object[] {
            "bassa",
            "media",
            "alta"});
			this.cmb_selezionecamera.Location = new System.Drawing.Point(470, 232);
			this.cmb_selezionecamera.Margin = new System.Windows.Forms.Padding(4);
			this.cmb_selezionecamera.Name = "cmb_selezionecamera";
			this.cmb_selezionecamera.Size = new System.Drawing.Size(175, 30);
			this.cmb_selezionecamera.TabIndex = 14;
			this.cmb_selezionecamera.Text = "selezione camera";
			// 
			// btn_informazioni
			// 
			this.btn_informazioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btn_informazioni.ForeColor = System.Drawing.Color.Black;
			this.btn_informazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_informazioni.Location = new System.Drawing.Point(418, 545);
			this.btn_informazioni.Margin = new System.Windows.Forms.Padding(4);
			this.btn_informazioni.Name = "btn_informazioni";
			this.btn_informazioni.Size = new System.Drawing.Size(76, 28);
			this.btn_informazioni.TabIndex = 15;
			this.btn_informazioni.Text = "?";
			this.btn_informazioni.UseVisualStyleBackColor = false;
			// 
			// lbl_n6
			// 
			this.lbl_n6.AutoSize = true;
			this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_n6.Location = new System.Drawing.Point(13, 548);
			this.lbl_n6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_n6.Name = "lbl_n6";
			this.lbl_n6.Size = new System.Drawing.Size(367, 25);
			this.lbl_n6.TabIndex = 16;
			this.lbl_n6.Text = "premere qui per per informazioni sul hotel";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(753, 294);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(280, 213);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 17;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(1145, 288);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(265, 219);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 18;
			this.pictureBox4.TabStop = false;
			// 
			// lbl_n7
			// 
			this.lbl_n7.AutoSize = true;
			this.lbl_n7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_n7.Location = new System.Drawing.Point(3, 174);
			this.lbl_n7.Name = "lbl_n7";
			this.lbl_n7.Size = new System.Drawing.Size(313, 22);
			this.lbl_n7.TabIndex = 19;
			this.lbl_n7.Text = "Clicca qui per scegliere la tua stagione";
			// 
			// lbl_n8
			// 
			this.lbl_n8.AutoSize = true;
			this.lbl_n8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_n8.Location = new System.Drawing.Point(3, 240);
			this.lbl_n8.Name = "lbl_n8";
			this.lbl_n8.Size = new System.Drawing.Size(435, 22);
			this.lbl_n8.TabIndex = 20;
			this.lbl_n8.Text = "Clicca qui per scegliere il tipo di stanza che preferisci";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1422, 640);
			this.Controls.Add(this.lbl_n8);
			this.Controls.Add(this.lbl_n7);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.lbl_n6);
			this.Controls.Add(this.btn_informazioni);
			this.Controls.Add(this.cmb_selezionecamera);
			this.Controls.Add(this.lbl_n5);
			this.Controls.Add(this.btn_prenota);
			this.Controls.Add(this.lbl_n4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txt_giorni);
			this.Controls.Add(this.lbl_n3);
			this.Controls.Add(this.lbl_n2);
			this.Controls.Add(this.lbl_n1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbl_titolo);
			this.Controls.Add(this.cmb_selezionestagione);
			this.Controls.Add(this.chk_parcheggio);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "seleziona la stagione";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_parcheggio;
        private System.Windows.Forms.ComboBox cmb_selezionestagione;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.TextBox txt_giorni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Button btn_prenota;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.ComboBox cmb_selezionecamera;
        private System.Windows.Forms.Button btn_informazioni;
        private System.Windows.Forms.Label lbl_n6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label lbl_n7;
		private System.Windows.Forms.Label lbl_n8;
	}
}

