namespace ProdavnicaKasa
{
    partial class Form1
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
            this.cbGrupa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArtikal = new System.Windows.Forms.Label();
            this.cbArtikal = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDodajNaRacun = new System.Windows.Forms.Button();
            this.btnIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.btnStorniranje = new System.Windows.Forms.Button();
            this.btnSledeciKupac = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSviRacuni = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrikaziRacun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGrupa
            // 
            this.cbGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrupa.FormattingEnabled = true;
            this.cbGrupa.Location = new System.Drawing.Point(16, 42);
            this.cbGrupa.Name = "cbGrupa";
            this.cbGrupa.Size = new System.Drawing.Size(205, 28);
            this.cbGrupa.TabIndex = 0;
            this.cbGrupa.SelectedIndexChanged += new System.EventHandler(this.cbGrupa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberi grupu:";
            // 
            // lblArtikal
            // 
            this.lblArtikal.AutoSize = true;
            this.lblArtikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikal.Location = new System.Drawing.Point(272, 9);
            this.lblArtikal.Name = "lblArtikal";
            this.lblArtikal.Size = new System.Drawing.Size(107, 20);
            this.lblArtikal.TabIndex = 3;
            this.lblArtikal.Text = "Izaberi artikal:";
            this.lblArtikal.Visible = false;
            // 
            // cbArtikal
            // 
            this.cbArtikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArtikal.FormattingEnabled = true;
            this.cbArtikal.Location = new System.Drawing.Point(276, 42);
            this.cbArtikal.Name = "cbArtikal";
            this.cbArtikal.Size = new System.Drawing.Size(388, 28);
            this.cbArtikal.TabIndex = 2;
            this.cbArtikal.Visible = false;
            this.cbArtikal.SelectedIndexChanged += new System.EventHandler(this.cbArtikal_SelectedIndexChanged);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKolicina.Location = new System.Drawing.Point(417, 84);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 26);
            this.txtKolicina.TabIndex = 4;
            this.txtKolicina.Text = "1";
            this.txtKolicina.Visible = false;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(272, 87);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(139, 20);
            this.lblKolicina.TabIndex = 5;
            this.lblKolicina.Text = "Količina proizvoda:";
            this.lblKolicina.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(648, 184);
            this.listBox1.TabIndex = 6;
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNaRacun.Location = new System.Drawing.Point(276, 116);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Size = new System.Drawing.Size(241, 34);
            this.btnDodajNaRacun.TabIndex = 7;
            this.btnDodajNaRacun.Text = "Dodaj na račun";
            this.btnDodajNaRacun.UseVisualStyleBackColor = true;
            this.btnDodajNaRacun.Visible = false;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.btnDodajNaRacun_Click);
            // 
            // btnIzdavanjeRacuna
            // 
            this.btnIzdavanjeRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzdavanjeRacuna.Location = new System.Drawing.Point(364, 236);
            this.btnIzdavanjeRacuna.Name = "btnIzdavanjeRacuna";
            this.btnIzdavanjeRacuna.Size = new System.Drawing.Size(303, 34);
            this.btnIzdavanjeRacuna.TabIndex = 9;
            this.btnIzdavanjeRacuna.Text = "Izdavanje računa";
            this.btnIzdavanjeRacuna.UseVisualStyleBackColor = true;
            this.btnIzdavanjeRacuna.Click += new System.EventHandler(this.btnIzdavanjeRacuna_Click);
            // 
            // btnStorniranje
            // 
            this.btnStorniranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorniranje.Location = new System.Drawing.Point(19, 236);
            this.btnStorniranje.Name = "btnStorniranje";
            this.btnStorniranje.Size = new System.Drawing.Size(303, 34);
            this.btnStorniranje.TabIndex = 9;
            this.btnStorniranje.Text = "Uklanjanje artikla sa računa";
            this.btnStorniranje.UseVisualStyleBackColor = true;
            this.btnStorniranje.Click += new System.EventHandler(this.btnStorniranje_Click);
            // 
            // btnSledeciKupac
            // 
            this.btnSledeciKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSledeciKupac.Location = new System.Drawing.Point(533, 84);
            this.btnSledeciKupac.Name = "btnSledeciKupac";
            this.btnSledeciKupac.Size = new System.Drawing.Size(131, 66);
            this.btnSledeciKupac.TabIndex = 10;
            this.btnSledeciKupac.Text = "Sledeći kupac";
            this.btnSledeciKupac.UseVisualStyleBackColor = true;
            this.btnSledeciKupac.Visible = false;
            this.btnSledeciKupac.Click += new System.EventHandler(this.btnSledeciKupac_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 471);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(256, 471);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 26);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Izaberite vremenski period:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Do:";
            // 
            // btnSviRacuni
            // 
            this.btnSviRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSviRacuni.Location = new System.Drawing.Point(425, 447);
            this.btnSviRacuni.Name = "btnSviRacuni";
            this.btnSviRacuni.Size = new System.Drawing.Size(239, 50);
            this.btnSviRacuni.TabIndex = 10;
            this.btnSviRacuni.Text = "Prikaz svih računa u odabranom periodu";
            this.btnSviRacuni.UseVisualStyleBackColor = true;
            this.btnSviRacuni.Click += new System.EventHandler(this.btnSviRacuni_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(16, 202);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(648, 184);
            this.listBox2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnStorniranje);
            this.panel1.Controls.Add(this.btnIzdavanjeRacuna);
            this.panel1.Location = new System.Drawing.Point(-3, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 285);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Račun:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Svi računi za izabrani period:";
            // 
            // btnPrikaziRacun
            // 
            this.btnPrikaziRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziRacun.Location = new System.Drawing.Point(16, 392);
            this.btnPrikaziRacun.Name = "btnPrikaziRacun";
            this.btnPrikaziRacun.Size = new System.Drawing.Size(648, 33);
            this.btnPrikaziRacun.TabIndex = 16;
            this.btnPrikaziRacun.Text = "Prikaži račun trenutnog kupca";
            this.btnPrikaziRacun.UseVisualStyleBackColor = true;
            this.btnPrikaziRacun.Click += new System.EventHandler(this.btnPrikaziRacun_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 66);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dodaj novi artikal u bazu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(425, 503);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(239, 30);
            this.btnIzbrisi.TabIndex = 18;
            this.btnIzbrisi.Text = "Izbriši račun iz baze";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Visible = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 545);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnPrikaziRacun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSviRacuni);
            this.Controls.Add(this.btnSledeciKupac);
            this.Controls.Add(this.btnDodajNaRacun);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblArtikal);
            this.Controls.Add(this.cbArtikal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGrupa);
            this.Name = "Form1";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGrupa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArtikal;
        private System.Windows.Forms.ComboBox cbArtikal;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDodajNaRacun;
        private System.Windows.Forms.Button btnIzdavanjeRacuna;
        private System.Windows.Forms.Button btnStorniranje;
        private System.Windows.Forms.Button btnSledeciKupac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSviRacuni;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrikaziRacun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}

