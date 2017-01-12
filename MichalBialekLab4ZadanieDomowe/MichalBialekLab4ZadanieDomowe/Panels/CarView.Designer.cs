namespace MichalBialekLab4ZadanieDomowe
{
    partial class CarView
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
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.buttonShowAllCars = new System.Windows.Forms.Button();
            this.buttonSelectAvaliableCars = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGetByYear = new System.Windows.Forms.Button();
            this.textBoxYearFrom = new System.Windows.Forms.TextBox();
            this.textBoxYearTo = new System.Windows.Forms.TextBox();
            this.buttonShowCarByBrand = new System.Windows.Forms.Button();
            this.textBoxShowCarByBrand = new System.Windows.Forms.TextBox();
            this.textBoxShowModel = new System.Windows.Forms.TextBox();
            this.buttonShowModel = new System.Windows.Forms.Button();
            this.checkBoxPb = new System.Windows.Forms.CheckBox();
            this.checkBoxDiesel = new System.Windows.Forms.CheckBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFuelType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Location = new System.Drawing.Point(-1, 38);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.Size = new System.Drawing.Size(782, 389);
            this.dataGridViewCar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sortuj według";
            // 
            // comboBoxOrderBy
            // 
            this.comboBoxOrderBy.FormattingEnabled = true;
            this.comboBoxOrderBy.Items.AddRange(new object[] {
            "Id",
            "Vin",
            "Brand",
            "Model",
            "Year"});
            this.comboBoxOrderBy.Location = new System.Drawing.Point(12, 475);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrderBy.TabIndex = 2;
            this.comboBoxOrderBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderBy_SelectedIndexChanged);
            // 
            // buttonShowAllCars
            // 
            this.buttonShowAllCars.Location = new System.Drawing.Point(169, 443);
            this.buttonShowAllCars.Name = "buttonShowAllCars";
            this.buttonShowAllCars.Size = new System.Drawing.Size(121, 23);
            this.buttonShowAllCars.TabIndex = 3;
            this.buttonShowAllCars.Text = "Pokaz wszystkie auta";
            this.buttonShowAllCars.UseVisualStyleBackColor = true;
            this.buttonShowAllCars.Click += new System.EventHandler(this.buttonShowAllCars_Click);
            // 
            // buttonSelectAvaliableCars
            // 
            this.buttonSelectAvaliableCars.Location = new System.Drawing.Point(169, 475);
            this.buttonSelectAvaliableCars.Name = "buttonSelectAvaliableCars";
            this.buttonSelectAvaliableCars.Size = new System.Drawing.Size(121, 23);
            this.buttonSelectAvaliableCars.TabIndex = 4;
            this.buttonSelectAvaliableCars.Text = "Pokaż dostępne auta";
            this.buttonSelectAvaliableCars.UseVisualStyleBackColor = true;
            this.buttonSelectAvaliableCars.Click += new System.EventHandler(this.buttonSelectAvaliableCars_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "do";
            // 
            // buttonGetByYear
            // 
            this.buttonGetByYear.Location = new System.Drawing.Point(327, 443);
            this.buttonGetByYear.Name = "buttonGetByYear";
            this.buttonGetByYear.Size = new System.Drawing.Size(121, 23);
            this.buttonGetByYear.TabIndex = 7;
            this.buttonGetByYear.Text = "Pokaż Auta z rocznika";
            this.buttonGetByYear.UseVisualStyleBackColor = true;
            this.buttonGetByYear.Click += new System.EventHandler(this.buttonGetByYear_Click);
            // 
            // textBoxYearFrom
            // 
            this.textBoxYearFrom.Location = new System.Drawing.Point(349, 480);
            this.textBoxYearFrom.Name = "textBoxYearFrom";
            this.textBoxYearFrom.Size = new System.Drawing.Size(57, 20);
            this.textBoxYearFrom.TabIndex = 8;
            // 
            // textBoxYearTo
            // 
            this.textBoxYearTo.Location = new System.Drawing.Point(349, 506);
            this.textBoxYearTo.Name = "textBoxYearTo";
            this.textBoxYearTo.Size = new System.Drawing.Size(57, 20);
            this.textBoxYearTo.TabIndex = 9;
            // 
            // buttonShowCarByBrand
            // 
            this.buttonShowCarByBrand.Location = new System.Drawing.Point(469, 443);
            this.buttonShowCarByBrand.Name = "buttonShowCarByBrand";
            this.buttonShowCarByBrand.Size = new System.Drawing.Size(102, 23);
            this.buttonShowCarByBrand.TabIndex = 10;
            this.buttonShowCarByBrand.Text = "Pokaż Auta marki";
            this.buttonShowCarByBrand.UseVisualStyleBackColor = true;
            this.buttonShowCarByBrand.Click += new System.EventHandler(this.buttonShowCarByBrand_Click);
            // 
            // textBoxShowCarByBrand
            // 
            this.textBoxShowCarByBrand.Location = new System.Drawing.Point(469, 483);
            this.textBoxShowCarByBrand.Name = "textBoxShowCarByBrand";
            this.textBoxShowCarByBrand.Size = new System.Drawing.Size(102, 20);
            this.textBoxShowCarByBrand.TabIndex = 11;
            // 
            // textBoxShowModel
            // 
            this.textBoxShowModel.Location = new System.Drawing.Point(589, 483);
            this.textBoxShowModel.Name = "textBoxShowModel";
            this.textBoxShowModel.Size = new System.Drawing.Size(85, 20);
            this.textBoxShowModel.TabIndex = 13;
            // 
            // buttonShowModel
            // 
            this.buttonShowModel.Location = new System.Drawing.Point(589, 443);
            this.buttonShowModel.Name = "buttonShowModel";
            this.buttonShowModel.Size = new System.Drawing.Size(85, 23);
            this.buttonShowModel.TabIndex = 12;
            this.buttonShowModel.Text = "Pokaż  model";
            this.buttonShowModel.UseVisualStyleBackColor = true;
            this.buttonShowModel.Click += new System.EventHandler(this.buttonShowModel_Click);
            // 
            // checkBoxPb
            // 
            this.checkBoxPb.AutoSize = true;
            this.checkBoxPb.Location = new System.Drawing.Point(688, 447);
            this.checkBoxPb.Name = "checkBoxPb";
            this.checkBoxPb.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPb.TabIndex = 14;
            this.checkBoxPb.Text = "Benzyna";
            this.checkBoxPb.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiesel
            // 
            this.checkBoxDiesel.AutoSize = true;
            this.checkBoxDiesel.Location = new System.Drawing.Point(688, 470);
            this.checkBoxDiesel.Name = "checkBoxDiesel";
            this.checkBoxDiesel.Size = new System.Drawing.Size(55, 17);
            this.checkBoxDiesel.TabIndex = 15;
            this.checkBoxDiesel.Text = "Diesel";
            this.checkBoxDiesel.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(-1, 2);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 39);
            this.buttonPrevious.TabIndex = 16;
            this.buttonPrevious.Text = "<-- Cofnij";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFuelType
            // 
            this.buttonFuelType.Location = new System.Drawing.Point(688, 493);
            this.buttonFuelType.Name = "buttonFuelType";
            this.buttonFuelType.Size = new System.Drawing.Size(93, 36);
            this.buttonFuelType.TabIndex = 17;
            this.buttonFuelType.Text = "Pokaz o rodzaju Paliwa";
            this.buttonFuelType.UseVisualStyleBackColor = true;
            this.buttonFuelType.Click += new System.EventHandler(this.buttonFuelType_Click);
            // 
            // CarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 587);
            this.Controls.Add(this.buttonFuelType);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.checkBoxDiesel);
            this.Controls.Add(this.checkBoxPb);
            this.Controls.Add(this.textBoxShowModel);
            this.Controls.Add(this.buttonShowModel);
            this.Controls.Add(this.textBoxShowCarByBrand);
            this.Controls.Add(this.buttonShowCarByBrand);
            this.Controls.Add(this.textBoxYearTo);
            this.Controls.Add(this.textBoxYearFrom);
            this.Controls.Add(this.buttonGetByYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSelectAvaliableCars);
            this.Controls.Add(this.buttonShowAllCars);
            this.Controls.Add(this.comboBoxOrderBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCar);
            this.Name = "CarView";
            this.Text = "CarView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Button buttonShowAllCars;
        private System.Windows.Forms.Button buttonSelectAvaliableCars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGetByYear;
        private System.Windows.Forms.TextBox textBoxYearFrom;
        private System.Windows.Forms.TextBox textBoxYearTo;
        private System.Windows.Forms.Button buttonShowCarByBrand;
        private System.Windows.Forms.TextBox textBoxShowCarByBrand;
        private System.Windows.Forms.TextBox textBoxShowModel;
        private System.Windows.Forms.Button buttonShowModel;
        private System.Windows.Forms.CheckBox checkBoxPb;
        private System.Windows.Forms.CheckBox checkBoxDiesel;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFuelType;
    }
}