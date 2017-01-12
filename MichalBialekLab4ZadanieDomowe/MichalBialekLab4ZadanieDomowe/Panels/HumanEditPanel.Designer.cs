namespace MichalBialekLab4ZadanieDomowe
{
    partial class HumanEditPanel
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
            this.dataGridViewHuman = new System.Windows.Forms.DataGridView();
            this.labelShowAllHuman = new System.Windows.Forms.Label();
            this.buttonShowAllHuman = new System.Windows.Forms.Button();
            this.buttonEditHuman = new System.Windows.Forms.Button();
            this.buttonDeleteHuman = new System.Windows.Forms.Button();
            this.labelDeleteHuman = new System.Windows.Forms.Label();
            this.buttonSelectById = new System.Windows.Forms.Button();
            this.labelSelectById = new System.Windows.Forms.Label();
            this.buttonSelectByPesel = new System.Windows.Forms.Button();
            this.labelSekectByPesel = new System.Windows.Forms.Label();
            this.textBoxSelectById = new System.Windows.Forms.TextBox();
            this.textBoxSelectByPesel = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxDrivingLicense = new System.Windows.Forms.TextBox();
            this.labelDrivingLicense = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.textBoxSearchBySurname = new System.Windows.Forms.TextBox();
            this.buttonSearchBySurname = new System.Windows.Forms.Button();
            this.labelSearchBySurname = new System.Windows.Forms.Label();
            this.textBoxSearchByName = new System.Windows.Forms.TextBox();
            this.buttonSearchByName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHuman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHuman
            // 
            this.dataGridViewHuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHuman.Location = new System.Drawing.Point(1, 58);
            this.dataGridViewHuman.Name = "dataGridViewHuman";
            this.dataGridViewHuman.Size = new System.Drawing.Size(582, 308);
            this.dataGridViewHuman.TabIndex = 0;
            // 
            // labelShowAllHuman
            // 
            this.labelShowAllHuman.AutoSize = true;
            this.labelShowAllHuman.Location = new System.Drawing.Point(4, 379);
            this.labelShowAllHuman.Name = "labelShowAllHuman";
            this.labelShowAllHuman.Size = new System.Drawing.Size(91, 26);
            this.labelShowAllHuman.TabIndex = 1;
            this.labelShowAllHuman.Text = "Pokaz wszystkich\r\nużytkoniwkow";
            // 
            // buttonShowAllHuman
            // 
            this.buttonShowAllHuman.Location = new System.Drawing.Point(4, 408);
            this.buttonShowAllHuman.Name = "buttonShowAllHuman";
            this.buttonShowAllHuman.Size = new System.Drawing.Size(123, 57);
            this.buttonShowAllHuman.TabIndex = 2;
            this.buttonShowAllHuman.Text = "Pokaż \r\nużytkowników";
            this.buttonShowAllHuman.UseVisualStyleBackColor = true;
            this.buttonShowAllHuman.Click += new System.EventHandler(this.buttonShowAllUsers_Click);
            // 
            // buttonEditHuman
            // 
            this.buttonEditHuman.Location = new System.Drawing.Point(593, 2);
            this.buttonEditHuman.Name = "buttonEditHuman";
            this.buttonEditHuman.Size = new System.Drawing.Size(83, 44);
            this.buttonEditHuman.TabIndex = 4;
            this.buttonEditHuman.Text = "Edytuj \r\nUżytkownika";
            this.buttonEditHuman.UseVisualStyleBackColor = true;
            this.buttonEditHuman.Click += new System.EventHandler(this.buttonEditHuman_Click);
            // 
            // buttonDeleteHuman
            // 
            this.buttonDeleteHuman.Location = new System.Drawing.Point(140, 404);
            this.buttonDeleteHuman.Name = "buttonDeleteHuman";
            this.buttonDeleteHuman.Size = new System.Drawing.Size(94, 36);
            this.buttonDeleteHuman.TabIndex = 6;
            this.buttonDeleteHuman.Text = "Usun Użytkownika";
            this.buttonDeleteHuman.UseVisualStyleBackColor = true;
            this.buttonDeleteHuman.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // labelDeleteHuman
            // 
            this.labelDeleteHuman.AutoSize = true;
            this.labelDeleteHuman.Location = new System.Drawing.Point(140, 379);
            this.labelDeleteHuman.Name = "labelDeleteHuman";
            this.labelDeleteHuman.Size = new System.Drawing.Size(94, 13);
            this.labelDeleteHuman.TabIndex = 5;
            this.labelDeleteHuman.Text = "Usuń użytkownika";
            // 
            // buttonSelectById
            // 
            this.buttonSelectById.Location = new System.Drawing.Point(243, 430);
            this.buttonSelectById.Name = "buttonSelectById";
            this.buttonSelectById.Size = new System.Drawing.Size(75, 35);
            this.buttonSelectById.TabIndex = 8;
            this.buttonSelectById.Text = "Wyszukaj po id";
            this.buttonSelectById.UseVisualStyleBackColor = true;
            this.buttonSelectById.Click += new System.EventHandler(this.buttonSelectById_Click);
            // 
            // labelSelectById
            // 
            this.labelSelectById.AutoSize = true;
            this.labelSelectById.Location = new System.Drawing.Point(240, 379);
            this.labelSelectById.Name = "labelSelectById";
            this.labelSelectById.Size = new System.Drawing.Size(80, 13);
            this.labelSelectById.TabIndex = 7;
            this.labelSelectById.Text = "Wyszukaj po Id";
            // 
            // buttonSelectByPesel
            // 
            this.buttonSelectByPesel.Location = new System.Drawing.Point(341, 430);
            this.buttonSelectByPesel.Name = "buttonSelectByPesel";
            this.buttonSelectByPesel.Size = new System.Drawing.Size(75, 35);
            this.buttonSelectByPesel.TabIndex = 10;
            this.buttonSelectByPesel.Text = "Wyszukaj po peselu";
            this.buttonSelectByPesel.UseVisualStyleBackColor = true;
            this.buttonSelectByPesel.Click += new System.EventHandler(this.buttonSelectByPesel_Click);
            // 
            // labelSekectByPesel
            // 
            this.labelSekectByPesel.AutoSize = true;
            this.labelSekectByPesel.Location = new System.Drawing.Point(338, 379);
            this.labelSekectByPesel.Name = "labelSekectByPesel";
            this.labelSekectByPesel.Size = new System.Drawing.Size(102, 13);
            this.labelSekectByPesel.TabIndex = 9;
            this.labelSekectByPesel.Text = "Wyszukaj po peselu";
            // 
            // textBoxSelectById
            // 
            this.textBoxSelectById.Location = new System.Drawing.Point(243, 404);
            this.textBoxSelectById.Name = "textBoxSelectById";
            this.textBoxSelectById.Size = new System.Drawing.Size(75, 20);
            this.textBoxSelectById.TabIndex = 11;
            // 
            // textBoxSelectByPesel
            // 
            this.textBoxSelectByPesel.Location = new System.Drawing.Point(341, 403);
            this.textBoxSelectByPesel.Name = "textBoxSelectByPesel";
            this.textBoxSelectByPesel.Size = new System.Drawing.Size(75, 20);
            this.textBoxSelectByPesel.TabIndex = 12;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(590, 58);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(590, 74);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(590, 113);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 16;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(590, 97);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(36, 13);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Hasło";
            // 
            // textBoxDrivingLicense
            // 
            this.textBoxDrivingLicense.Location = new System.Drawing.Point(590, 152);
            this.textBoxDrivingLicense.Name = "textBoxDrivingLicense";
            this.textBoxDrivingLicense.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrivingLicense.TabIndex = 18;
            // 
            // labelDrivingLicense
            // 
            this.labelDrivingLicense.AutoSize = true;
            this.labelDrivingLicense.Location = new System.Drawing.Point(590, 136);
            this.labelDrivingLicense.Name = "labelDrivingLicense";
            this.labelDrivingLicense.Size = new System.Drawing.Size(64, 13);
            this.labelDrivingLicense.TabIndex = 17;
            this.labelDrivingLicense.Text = "Prawo jazdy";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(590, 191);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(590, 175);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Imie";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(590, 230);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 22;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(590, 214);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 21;
            this.labelSurname.Text = "Nazwisko";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(590, 269);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdress.TabIndex = 24;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(590, 253);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(39, 13);
            this.labelAdress.TabIndex = 23;
            this.labelAdress.Text = "Adress";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(587, 308);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 26;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(587, 292);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 25;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(587, 347);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 28;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(587, 331);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(83, 13);
            this.labelPhoneNumber.TabIndex = 27;
            this.labelPhoneNumber.Text = "Numer Telefonu";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(1, 5);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 39);
            this.buttonPrevious.TabIndex = 29;
            this.buttonPrevious.Text = "<-- Cofnij";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // textBoxSearchBySurname
            // 
            this.textBoxSearchBySurname.Location = new System.Drawing.Point(449, 403);
            this.textBoxSearchBySurname.Name = "textBoxSearchBySurname";
            this.textBoxSearchBySurname.Size = new System.Drawing.Size(83, 20);
            this.textBoxSearchBySurname.TabIndex = 32;
            // 
            // buttonSearchBySurname
            // 
            this.buttonSearchBySurname.Location = new System.Drawing.Point(449, 430);
            this.buttonSearchBySurname.Name = "buttonSearchBySurname";
            this.buttonSearchBySurname.Size = new System.Drawing.Size(83, 35);
            this.buttonSearchBySurname.TabIndex = 31;
            this.buttonSearchBySurname.Text = "Wyszukaj po Nazwisku";
            this.buttonSearchBySurname.UseVisualStyleBackColor = true;
            this.buttonSearchBySurname.Click += new System.EventHandler(this.buttonSearchBySurname_Click);
            // 
            // labelSearchBySurname
            // 
            this.labelSearchBySurname.AutoSize = true;
            this.labelSearchBySurname.Location = new System.Drawing.Point(446, 379);
            this.labelSearchBySurname.Name = "labelSearchBySurname";
            this.labelSearchBySurname.Size = new System.Drawing.Size(117, 13);
            this.labelSearchBySurname.TabIndex = 30;
            this.labelSearchBySurname.Text = "Wyszukaj po Nazwisku";
            // 
            // textBoxSearchByName
            // 
            this.textBoxSearchByName.Location = new System.Drawing.Point(571, 403);
            this.textBoxSearchByName.Name = "textBoxSearchByName";
            this.textBoxSearchByName.Size = new System.Drawing.Size(75, 20);
            this.textBoxSearchByName.TabIndex = 35;
            // 
            // buttonSearchByName
            // 
            this.buttonSearchByName.Location = new System.Drawing.Point(571, 430);
            this.buttonSearchByName.Name = "buttonSearchByName";
            this.buttonSearchByName.Size = new System.Drawing.Size(75, 35);
            this.buttonSearchByName.TabIndex = 34;
            this.buttonSearchByName.Text = "Wyszukaj po imieniu";
            this.buttonSearchByName.UseVisualStyleBackColor = true;
            this.buttonSearchByName.Click += new System.EventHandler(this.buttonSearchByName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Wyszukaj po Imieniu";
            // 
            // HumanEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 465);
            this.Controls.Add(this.textBoxSearchByName);
            this.Controls.Add(this.buttonSearchByName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchBySurname);
            this.Controls.Add(this.buttonSearchBySurname);
            this.Controls.Add(this.labelSearchBySurname);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDrivingLicense);
            this.Controls.Add(this.labelDrivingLicense);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxSelectByPesel);
            this.Controls.Add(this.textBoxSelectById);
            this.Controls.Add(this.buttonSelectByPesel);
            this.Controls.Add(this.labelSekectByPesel);
            this.Controls.Add(this.buttonSelectById);
            this.Controls.Add(this.labelSelectById);
            this.Controls.Add(this.buttonDeleteHuman);
            this.Controls.Add(this.labelDeleteHuman);
            this.Controls.Add(this.buttonEditHuman);
            this.Controls.Add(this.buttonShowAllHuman);
            this.Controls.Add(this.labelShowAllHuman);
            this.Controls.Add(this.dataGridViewHuman);
            this.Name = "HumanEditPanel";
            this.Text = "UserEditPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHuman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHuman;
        private System.Windows.Forms.Label labelShowAllHuman;
        private System.Windows.Forms.Button buttonShowAllHuman;
        private System.Windows.Forms.Button buttonEditHuman;
        private System.Windows.Forms.Button buttonDeleteHuman;
        private System.Windows.Forms.Label labelDeleteHuman;
        private System.Windows.Forms.Button buttonSelectById;
        private System.Windows.Forms.Label labelSelectById;
        private System.Windows.Forms.Button buttonSelectByPesel;
        private System.Windows.Forms.Label labelSekectByPesel;
        private System.Windows.Forms.TextBox textBoxSelectById;
        private System.Windows.Forms.TextBox textBoxSelectByPesel;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxDrivingLicense;
        private System.Windows.Forms.Label labelDrivingLicense;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.TextBox textBoxSearchBySurname;
        private System.Windows.Forms.Button buttonSearchBySurname;
        private System.Windows.Forms.Label labelSearchBySurname;
        private System.Windows.Forms.TextBox textBoxSearchByName;
        private System.Windows.Forms.Button buttonSearchByName;
        private System.Windows.Forms.Label label2;
    }
}