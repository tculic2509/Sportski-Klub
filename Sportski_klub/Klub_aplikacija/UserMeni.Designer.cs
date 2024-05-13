namespace Klub_aplikacija
{
    partial class UserMeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMeni));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.buttonClanarina = new System.Windows.Forms.Button();
            this.buttonKlub = new System.Windows.Forms.Button();
            this.buttonTrener = new System.Windows.Forms.Button();
            this.buttonSportas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // buttonClanarina
            // 
            this.buttonClanarina.Location = new System.Drawing.Point(443, 152);
            this.buttonClanarina.Name = "buttonClanarina";
            this.buttonClanarina.Size = new System.Drawing.Size(152, 49);
            this.buttonClanarina.TabIndex = 2;
            this.buttonClanarina.Text = "CLANARINA";
            this.buttonClanarina.UseVisualStyleBackColor = true;
            this.buttonClanarina.Click += new System.EventHandler(this.buttonClanarina_Click);
            // 
            // buttonKlub
            // 
            this.buttonKlub.Location = new System.Drawing.Point(443, 224);
            this.buttonKlub.Name = "buttonKlub";
            this.buttonKlub.Size = new System.Drawing.Size(152, 60);
            this.buttonKlub.TabIndex = 3;
            this.buttonKlub.Text = "KLUB";
            this.buttonKlub.UseVisualStyleBackColor = true;
            this.buttonKlub.Click += new System.EventHandler(this.buttonKlub_Click);
            // 
            // buttonTrener
            // 
            this.buttonTrener.Location = new System.Drawing.Point(443, 307);
            this.buttonTrener.Name = "buttonTrener";
            this.buttonTrener.Size = new System.Drawing.Size(152, 51);
            this.buttonTrener.TabIndex = 4;
            this.buttonTrener.Text = "TRENER";
            this.buttonTrener.UseVisualStyleBackColor = true;
            this.buttonTrener.Click += new System.EventHandler(this.buttonTrener_Click);
            // 
            // buttonSportas
            // 
            this.buttonSportas.Location = new System.Drawing.Point(443, 381);
            this.buttonSportas.Name = "buttonSportas";
            this.buttonSportas.Size = new System.Drawing.Size(152, 55);
            this.buttonSportas.TabIndex = 5;
            this.buttonSportas.Text = "SPORTAS";
            this.buttonSportas.UseVisualStyleBackColor = true;
            this.buttonSportas.Click += new System.EventHandler(this.buttonSportas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "GLAVNI MENI";
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSportas);
            this.Controls.Add(this.buttonTrener);
            this.Controls.Add(this.buttonKlub);
            this.Controls.Add(this.buttonClanarina);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Meni";
            this.Text = "Meni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button buttonClanarina;
        private System.Windows.Forms.Button buttonKlub;
        private System.Windows.Forms.Button buttonTrener;
        private System.Windows.Forms.Button buttonSportas;
        private System.Windows.Forms.Label label1;
    }
}