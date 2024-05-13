namespace Klub_aplikacija
{
    partial class Sportas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sportas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMjestoStanovanja = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.CLEAR = new System.Windows.Forms.Button();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.Label();
            this.Lijecnicki = new System.Windows.Forms.Label();
            this.DatumUpisa = new System.Windows.Forms.Label();
            this.txtDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.txtLijecnickiPregledVrijediDo = new System.Windows.Forms.DateTimePicker();
            this.txtDatumUpisa = new System.Windows.Forms.DateTimePicker();
            this.txtKlubID = new System.Windows.Forms.TextBox();
            this.txtTrenerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(134, 99);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(158, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(134, 177);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(158, 20);
            this.txtOIB.TabIndex = 4;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(134, 63);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(158, 20);
            this.txtIme.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PREZIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DATUM ROĐENJA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "OIB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MJESTO STANOVANJA";
            // 
            // txtMjestoStanovanja
            // 
            this.txtMjestoStanovanja.Location = new System.Drawing.Point(176, 226);
            this.txtMjestoStanovanja.Name = "txtMjestoStanovanja";
            this.txtMjestoStanovanja.Size = new System.Drawing.Size(158, 20);
            this.txtMjestoStanovanja.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Dodaj_ClickAsync);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "IZBRISI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Izbrisi_ClickAsync);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(908, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "SPREMI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.save_ClickAsync);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(440, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 192);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(134, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 20);
            this.txtID.TabIndex = 18;
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(440, 268);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 23);
            this.CLEAR.TabIndex = 19;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.Clear_Click);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(134, 268);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(158, 20);
            this.txtAdresa.TabIndex = 20;
            // 
            // Adresa
            // 
            this.Adresa.AutoSize = true;
            this.Adresa.Location = new System.Drawing.Point(16, 271);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(51, 13);
            this.Adresa.TabIndex = 23;
            this.Adresa.Text = "ADRESA";
            // 
            // Lijecnicki
            // 
            this.Lijecnicki.AutoSize = true;
            this.Lijecnicki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lijecnicki.Location = new System.Drawing.Point(16, 309);
            this.Lijecnicki.Name = "Lijecnicki";
            this.Lijecnicki.Size = new System.Drawing.Size(180, 13);
            this.Lijecnicki.TabIndex = 24;
            this.Lijecnicki.Text = "LIJECNICKI PREGLED VRIJEDI DO";
            // 
            // DatumUpisa
            // 
            this.DatumUpisa.AutoSize = true;
            this.DatumUpisa.Location = new System.Drawing.Point(16, 348);
            this.DatumUpisa.Name = "DatumUpisa";
            this.DatumUpisa.Size = new System.Drawing.Size(81, 13);
            this.DatumUpisa.TabIndex = 25;
            this.DatumUpisa.Text = "DATUM UPISA";
            // 
            // txtDatumRodenja
            // 
            this.txtDatumRodenja.Location = new System.Drawing.Point(134, 135);
            this.txtDatumRodenja.Name = "txtDatumRodenja";
            this.txtDatumRodenja.Size = new System.Drawing.Size(158, 20);
            this.txtDatumRodenja.TabIndex = 26;
            // 
            // txtLijecnickiPregledVrijediDo
            // 
            this.txtLijecnickiPregledVrijediDo.Location = new System.Drawing.Point(207, 303);
            this.txtLijecnickiPregledVrijediDo.Name = "txtLijecnickiPregledVrijediDo";
            this.txtLijecnickiPregledVrijediDo.Size = new System.Drawing.Size(156, 20);
            this.txtLijecnickiPregledVrijediDo.TabIndex = 27;
            // 
            // txtDatumUpisa
            // 
            this.txtDatumUpisa.Location = new System.Drawing.Point(134, 348);
            this.txtDatumUpisa.Name = "txtDatumUpisa";
            this.txtDatumUpisa.Size = new System.Drawing.Size(158, 20);
            this.txtDatumUpisa.TabIndex = 28;
            // 
            // txtKlubID
            // 
            this.txtKlubID.Location = new System.Drawing.Point(134, 389);
            this.txtKlubID.Name = "txtKlubID";
            this.txtKlubID.Size = new System.Drawing.Size(100, 20);
            this.txtKlubID.TabIndex = 29;
            // 
            // txtTrenerID
            // 
            this.txtTrenerID.Location = new System.Drawing.Point(134, 435);
            this.txtTrenerID.Name = "txtTrenerID";
            this.txtTrenerID.Size = new System.Drawing.Size(100, 20);
            this.txtTrenerID.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "KLUB ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "TRENER ID";
            // 
            // txtNazad
            // 
            this.txtNazad.Location = new System.Drawing.Point(908, 540);
            this.txtNazad.Name = "txtNazad";
            this.txtNazad.Size = new System.Drawing.Size(75, 23);
            this.txtNazad.TabIndex = 33;
            this.txtNazad.Text = "NAZAD";
            this.txtNazad.UseVisualStyleBackColor = true;
            this.txtNazad.Click += new System.EventHandler(this.txtNazad_Click);
            // 
            // Sportas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 606);
            this.Controls.Add(this.txtNazad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTrenerID);
            this.Controls.Add(this.txtKlubID);
            this.Controls.Add(this.txtDatumUpisa);
            this.Controls.Add(this.txtLijecnickiPregledVrijediDo);
            this.Controls.Add(this.txtDatumRodenja);
            this.Controls.Add(this.DatumUpisa);
            this.Controls.Add(this.Lijecnicki);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMjestoStanovanja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sportas";
            this.Text = "Sportas";
            this.Shown += new System.EventHandler(this.Sportas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMjestoStanovanja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label Adresa;
        private System.Windows.Forms.Label Lijecnicki;
        private System.Windows.Forms.Label DatumUpisa;
        private System.Windows.Forms.DateTimePicker txtDatumRodenja;
        private System.Windows.Forms.DateTimePicker txtLijecnickiPregledVrijediDo;
        private System.Windows.Forms.DateTimePicker txtDatumUpisa;
        private System.Windows.Forms.TextBox txtKlubID;
        private System.Windows.Forms.TextBox txtTrenerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtNazad;
    }
}