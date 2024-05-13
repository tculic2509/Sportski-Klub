namespace Klub_aplikacija
{
    partial class TrenerForm
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
            this.username = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.inputLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.MenuText;
            this.username.Location = new System.Drawing.Point(208, 133);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(97, 24);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lozinka.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lozinka.Location = new System.Drawing.Point(208, 178);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(74, 24);
            this.lozinka.TabIndex = 1;
            this.lozinka.Text = "Lozinka";
            // 
            // inputUsername
            // 
            this.inputUsername.BackColor = System.Drawing.SystemColors.Info;
            this.inputUsername.Location = new System.Drawing.Point(311, 137);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(175, 20);
            this.inputUsername.TabIndex = 2;
            //this.inputUsername.TextChanged += new System.EventHandler(this.inputUsername_TextChanged);
            // 
            // inputLozinka
            // 
            this.inputLozinka.BackColor = System.Drawing.SystemColors.Info;
            this.inputLozinka.Location = new System.Drawing.Point(311, 183);
            this.inputLozinka.Name = "inputLozinka";
            this.inputLozinka.Size = new System.Drawing.Size(175, 20);
            this.inputLozinka.TabIndex = 3;
            //this.inputLozinka.TextChanged += new System.EventHandler(this.inputLozinka_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.login);
            // 
            // TrenerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputLozinka);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.username);
            this.Name = "TrenerForm";
            this.Text = "Admin Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label lozinka;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.TextBox inputLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}