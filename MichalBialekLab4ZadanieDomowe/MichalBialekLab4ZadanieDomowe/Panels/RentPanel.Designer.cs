namespace MichalBialekLab4ZadanieDomowe
{
    partial class RentPanel
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
            this.dataGridViewRents = new System.Windows.Forms.DataGridView();
            this.labelUserId = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxCarId = new System.Windows.Forms.TextBox();
            this.labelCarId = new System.Windows.Forms.Label();
            this.buttonAddRent = new System.Windows.Forms.Button();
            this.buttonShowAllRents = new System.Windows.Forms.Button();
            this.buttonShowRentWhereId = new System.Windows.Forms.Button();
            this.textBoxShowRentWhereId = new System.Windows.Forms.TextBox();
            this.labelEditRent = new System.Windows.Forms.Label();
            this.buttonDeleteRent = new System.Windows.Forms.Button();
            this.labelExpense = new System.Windows.Forms.Label();
            this.textBoxRentExpense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRentDateOfEnd = new System.Windows.Forms.Label();
            this.textBoxRentUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRentCarId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEditRent = new System.Windows.Forms.Button();
            this.ExampleData = new System.Windows.Forms.Label();
            this.buttonPickURent = new System.Windows.Forms.Button();
            this.maskedTextBoxRentDateOfHire = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDateOfEnd = new System.Windows.Forms.MaskedTextBox();
            this.buttonShowRentsWhereData = new System.Windows.Forms.Button();
            this.maskedTextBoxRentFrom = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRentTo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRentFrom = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRents
            // 
            this.dataGridViewRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRents.Location = new System.Drawing.Point(5, 68);
            this.dataGridViewRents.Name = "dataGridViewRents";
            this.dataGridViewRents.Size = new System.Drawing.Size(787, 227);
            this.dataGridViewRents.TabIndex = 0;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(2, 328);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(41, 13);
            this.labelUserId.TabIndex = 1;
            this.labelUserId.Text = "User Id";
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(49, 328);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserId.TabIndex = 2;
            // 
            // textBoxCarId
            // 
            this.textBoxCarId.Location = new System.Drawing.Point(49, 363);
            this.textBoxCarId.Name = "textBoxCarId";
            this.textBoxCarId.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarId.TabIndex = 5;
            // 
            // labelCarId
            // 
            this.labelCarId.AutoSize = true;
            this.labelCarId.Location = new System.Drawing.Point(2, 363);
            this.labelCarId.Name = "labelCarId";
            this.labelCarId.Size = new System.Drawing.Size(35, 13);
            this.labelCarId.TabIndex = 4;
            this.labelCarId.Text = "Car Id";
            // 
            // buttonAddRent
            // 
            this.buttonAddRent.Location = new System.Drawing.Point(49, 389);
            this.buttonAddRent.Name = "buttonAddRent";
            this.buttonAddRent.Size = new System.Drawing.Size(100, 35);
            this.buttonAddRent.TabIndex = 6;
            this.buttonAddRent.Text = "Dodaj Wypozyczenie";
            this.buttonAddRent.UseVisualStyleBackColor = true;
            this.buttonAddRent.Click += new System.EventHandler(this.buttonAddRent_Click);
            // 
            // buttonShowAllRents
            // 
            this.buttonShowAllRents.Location = new System.Drawing.Point(170, 328);
            this.buttonShowAllRents.Name = "buttonShowAllRents";
            this.buttonShowAllRents.Size = new System.Drawing.Size(94, 37);
            this.buttonShowAllRents.TabIndex = 7;
            this.buttonShowAllRents.Text = "Pokaz Wypozyczenia";
            this.buttonShowAllRents.UseVisualStyleBackColor = true;
            this.buttonShowAllRents.Click += new System.EventHandler(this.buttonShowAllRents_Click);
            // 
            // buttonShowRentWhereId
            // 
            this.buttonShowRentWhereId.Location = new System.Drawing.Point(421, 325);
            this.buttonShowRentWhereId.Name = "buttonShowRentWhereId";
            this.buttonShowRentWhereId.Size = new System.Drawing.Size(107, 40);
            this.buttonShowRentWhereId.TabIndex = 8;
            this.buttonShowRentWhereId.Text = "Pokaz Wypozyczenie o Id";
            this.buttonShowRentWhereId.UseVisualStyleBackColor = true;
            this.buttonShowRentWhereId.Click += new System.EventHandler(this.buttonShowRentWhereId_Click);
            // 
            // textBoxShowRentWhereId
            // 
            this.textBoxShowRentWhereId.Location = new System.Drawing.Point(421, 371);
            this.textBoxShowRentWhereId.Name = "textBoxShowRentWhereId";
            this.textBoxShowRentWhereId.Size = new System.Drawing.Size(100, 20);
            this.textBoxShowRentWhereId.TabIndex = 9;
            // 
            // labelEditRent
            // 
            this.labelEditRent.AutoSize = true;
            this.labelEditRent.Location = new System.Drawing.Point(821, 77);
            this.labelEditRent.Name = "labelEditRent";
            this.labelEditRent.Size = new System.Drawing.Size(105, 13);
            this.labelEditRent.TabIndex = 10;
            this.labelEditRent.Text = "Edytuj wypożyczenie";
            // 
            // buttonDeleteRent
            // 
            this.buttonDeleteRent.Location = new System.Drawing.Point(290, 328);
            this.buttonDeleteRent.Name = "buttonDeleteRent";
            this.buttonDeleteRent.Size = new System.Drawing.Size(94, 37);
            this.buttonDeleteRent.TabIndex = 11;
            this.buttonDeleteRent.Text = "Usun Wypożyczenie";
            this.buttonDeleteRent.UseVisualStyleBackColor = true;
            this.buttonDeleteRent.Click += new System.EventHandler(this.buttonDeleteRent_Click);
            // 
            // labelExpense
            // 
            this.labelExpense.AutoSize = true;
            this.labelExpense.Location = new System.Drawing.Point(821, 104);
            this.labelExpense.Name = "labelExpense";
            this.labelExpense.Size = new System.Drawing.Size(48, 13);
            this.labelExpense.TabIndex = 12;
            this.labelExpense.Text = "Expense";
            // 
            // textBoxRentExpense
            // 
            this.textBoxRentExpense.Location = new System.Drawing.Point(821, 120);
            this.textBoxRentExpense.Name = "textBoxRentExpense";
            this.textBoxRentExpense.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentExpense.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "DateOfHire";
            // 
            // labelRentDateOfEnd
            // 
            this.labelRentDateOfEnd.AutoSize = true;
            this.labelRentDateOfEnd.Location = new System.Drawing.Point(824, 236);
            this.labelRentDateOfEnd.Name = "labelRentDateOfEnd";
            this.labelRentDateOfEnd.Size = new System.Drawing.Size(60, 13);
            this.labelRentDateOfEnd.TabIndex = 16;
            this.labelRentDateOfEnd.Text = "DateOfEnd";
            // 
            // textBoxRentUserId
            // 
            this.textBoxRentUserId.Location = new System.Drawing.Point(824, 301);
            this.textBoxRentUserId.Name = "textBoxRentUserId";
            this.textBoxRentUserId.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentUserId.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(824, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "User Id";
            // 
            // textBoxRentCarId
            // 
            this.textBoxRentCarId.Location = new System.Drawing.Point(824, 341);
            this.textBoxRentCarId.Name = "textBoxRentCarId";
            this.textBoxRentCarId.Size = new System.Drawing.Size(100, 20);
            this.textBoxRentCarId.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(824, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Car Id";
            // 
            // buttonEditRent
            // 
            this.buttonEditRent.Location = new System.Drawing.Point(827, 378);
            this.buttonEditRent.Name = "buttonEditRent";
            this.buttonEditRent.Size = new System.Drawing.Size(99, 38);
            this.buttonEditRent.TabIndex = 22;
            this.buttonEditRent.Text = "Edytuj wypożyczenie";
            this.buttonEditRent.UseVisualStyleBackColor = true;
            this.buttonEditRent.Click += new System.EventHandler(this.buttonEditRent_Click);
            // 
            // ExampleData
            // 
            this.ExampleData.AutoSize = true;
            this.ExampleData.Location = new System.Drawing.Point(798, 159);
            this.ExampleData.Name = "ExampleData";
            this.ExampleData.Size = new System.Drawing.Size(147, 13);
            this.ExampleData.TabIndex = 23;
            this.ExampleData.Text = "Example Data DD.MM.YYYY ";
            // 
            // buttonPickURent
            // 
            this.buttonPickURent.Location = new System.Drawing.Point(698, 329);
            this.buttonPickURent.Name = "buttonPickURent";
            this.buttonPickURent.Size = new System.Drawing.Size(94, 35);
            this.buttonPickURent.TabIndex = 24;
            this.buttonPickURent.Text = "Odbierz zamowienie";
            this.buttonPickURent.UseVisualStyleBackColor = true;
            this.buttonPickURent.Click += new System.EventHandler(this.buttonPickURent_Click);
            // 
            // maskedTextBoxRentDateOfHire
            // 
            this.maskedTextBoxRentDateOfHire.Location = new System.Drawing.Point(824, 201);
            this.maskedTextBoxRentDateOfHire.Name = "maskedTextBoxRentDateOfHire";
            this.maskedTextBoxRentDateOfHire.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRentDateOfHire.TabIndex = 25;
            // 
            // maskedTextBoxDateOfEnd
            // 
            this.maskedTextBoxDateOfEnd.Location = new System.Drawing.Point(824, 252);
            this.maskedTextBoxDateOfEnd.Name = "maskedTextBoxDateOfEnd";
            this.maskedTextBoxDateOfEnd.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDateOfEnd.TabIndex = 26;
            // 
            // buttonShowRentsWhereData
            // 
            this.buttonShowRentsWhereData.Location = new System.Drawing.Point(549, 329);
            this.buttonShowRentsWhereData.Name = "buttonShowRentsWhereData";
            this.buttonShowRentsWhereData.Size = new System.Drawing.Size(129, 36);
            this.buttonShowRentsWhereData.TabIndex = 27;
            this.buttonShowRentsWhereData.Text = "Pokaż wypożyczenia z Datą";
            this.buttonShowRentsWhereData.UseVisualStyleBackColor = true;
            this.buttonShowRentsWhereData.Click += new System.EventHandler(this.buttonShowRentsWhereData_Click);
            // 
            // maskedTextBoxRentFrom
            // 
            this.maskedTextBoxRentFrom.Location = new System.Drawing.Point(549, 388);
            this.maskedTextBoxRentFrom.Name = "maskedTextBoxRentFrom";
            this.maskedTextBoxRentFrom.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBoxRentFrom.TabIndex = 28;
            // 
            // maskedTextBoxRentTo
            // 
            this.maskedTextBoxRentTo.Location = new System.Drawing.Point(549, 433);
            this.maskedTextBoxRentTo.Name = "maskedTextBoxRentTo";
            this.maskedTextBoxRentTo.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBoxRentTo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Do";
            // 
            // labelRentFrom
            // 
            this.labelRentFrom.AutoSize = true;
            this.labelRentFrom.Location = new System.Drawing.Point(588, 368);
            this.labelRentFrom.Name = "labelRentFrom";
            this.labelRentFrom.Size = new System.Drawing.Size(21, 13);
            this.labelRentFrom.TabIndex = 31;
            this.labelRentFrom.Text = "Od";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(-2, 0);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 39);
            this.buttonPrevious.TabIndex = 32;
            this.buttonPrevious.Text = "<-- Cofnij";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // RentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 464);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.labelRentFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxRentTo);
            this.Controls.Add(this.maskedTextBoxRentFrom);
            this.Controls.Add(this.buttonShowRentsWhereData);
            this.Controls.Add(this.maskedTextBoxDateOfEnd);
            this.Controls.Add(this.maskedTextBoxRentDateOfHire);
            this.Controls.Add(this.buttonPickURent);
            this.Controls.Add(this.ExampleData);
            this.Controls.Add(this.buttonEditRent);
            this.Controls.Add(this.textBoxRentCarId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRentUserId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRentDateOfEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRentExpense);
            this.Controls.Add(this.labelExpense);
            this.Controls.Add(this.buttonDeleteRent);
            this.Controls.Add(this.labelEditRent);
            this.Controls.Add(this.textBoxShowRentWhereId);
            this.Controls.Add(this.buttonShowRentWhereId);
            this.Controls.Add(this.buttonShowAllRents);
            this.Controls.Add(this.buttonAddRent);
            this.Controls.Add(this.textBoxCarId);
            this.Controls.Add(this.labelCarId);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.dataGridViewRents);
            this.Name = "RentPanel";
            this.Text = "RentAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRents;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxCarId;
        private System.Windows.Forms.Label labelCarId;
        private System.Windows.Forms.Button buttonAddRent;
        private System.Windows.Forms.Button buttonShowAllRents;
        private System.Windows.Forms.Button buttonShowRentWhereId;
        private System.Windows.Forms.TextBox textBoxShowRentWhereId;
        private System.Windows.Forms.Label labelEditRent;
        private System.Windows.Forms.Button buttonDeleteRent;
        private System.Windows.Forms.Label labelExpense;
        private System.Windows.Forms.TextBox textBoxRentExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRentDateOfEnd;
        private System.Windows.Forms.TextBox textBoxRentUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRentCarId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonEditRent;
        private System.Windows.Forms.Label ExampleData;
        private System.Windows.Forms.Button buttonPickURent;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRentDateOfHire;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDateOfEnd;
        private System.Windows.Forms.Button buttonShowRentsWhereData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRentFrom;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRentTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRentFrom;
        private System.Windows.Forms.Button buttonPrevious;
    }
}