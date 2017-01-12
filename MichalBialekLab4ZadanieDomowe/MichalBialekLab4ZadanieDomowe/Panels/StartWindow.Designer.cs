namespace MichalBialekLab4ZadanieDomowe
{
    partial class StartWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSigIn = new System.Windows.Forms.Label();
            this.labelAdministratorPanel = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.buttonAdministratorPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witamy w wypożyczalni Samochodów";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogin.Location = new System.Drawing.Point(40, 99);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(221, 31);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Panel Logowania";
            // 
            // labelSigIn
            // 
            this.labelSigIn.AutoSize = true;
            this.labelSigIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSigIn.Location = new System.Drawing.Point(40, 173);
            this.labelSigIn.Name = "labelSigIn";
            this.labelSigIn.Size = new System.Drawing.Size(218, 31);
            this.labelSigIn.TabIndex = 2;
            this.labelSigIn.Text = "Panel Rejestracji";
            // 
            // labelAdministratorPanel
            // 
            this.labelAdministratorPanel.AutoSize = true;
            this.labelAdministratorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdministratorPanel.Location = new System.Drawing.Point(40, 246);
            this.labelAdministratorPanel.Name = "labelAdministratorPanel";
            this.labelAdministratorPanel.Size = new System.Drawing.Size(273, 31);
            this.labelAdministratorPanel.TabIndex = 3;
            this.labelAdministratorPanel.Text = "Panel Administratotra";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(390, 104);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(204, 33);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Logowanie";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.Location = new System.Drawing.Point(390, 173);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(204, 33);
            this.buttonSingIn.TabIndex = 5;
            this.buttonSingIn.Text = "Rejestracja";
            this.buttonSingIn.UseVisualStyleBackColor = true;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonUserSingIn_Click);
            // 
            // buttonAdministratorPanel
            // 
            this.buttonAdministratorPanel.Location = new System.Drawing.Point(390, 244);
            this.buttonAdministratorPanel.Name = "buttonAdministratorPanel";
            this.buttonAdministratorPanel.Size = new System.Drawing.Size(204, 33);
            this.buttonAdministratorPanel.TabIndex = 6;
            this.buttonAdministratorPanel.Text = "Admin";
            this.buttonAdministratorPanel.UseVisualStyleBackColor = true;
            this.buttonAdministratorPanel.Click += new System.EventHandler(this.buttonAdministratorPanel_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 391);
            this.Controls.Add(this.buttonAdministratorPanel);
            this.Controls.Add(this.buttonSingIn);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelAdministratorPanel);
            this.Controls.Add(this.labelSigIn);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label1);
            this.Name = "StartWindow";
            this.Text = "Start Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSigIn;
        private System.Windows.Forms.Label labelAdministratorPanel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSingIn;
        private System.Windows.Forms.Button buttonAdministratorPanel;
    }
}

