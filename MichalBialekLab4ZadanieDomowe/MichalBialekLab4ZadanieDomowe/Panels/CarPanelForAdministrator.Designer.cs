namespace MichalBialekLab4ZadanieDomowe.Panels
{
    partial class CarPanelForAdministrator
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
            this.buttonFuelType = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.checkBoxDiesel = new System.Windows.Forms.CheckBox();
            this.checkBoxPb = new System.Windows.Forms.CheckBox();
            this.textBoxShowModel = new System.Windows.Forms.TextBox();
            this.buttonShowModel = new System.Windows.Forms.Button();
            this.textBoxShowCarByBrand = new System.Windows.Forms.TextBox();
            this.buttonShowCarByBrand = new System.Windows.Forms.Button();
            this.textBoxYearTo = new System.Windows.Forms.TextBox();
            this.textBoxYearFrom = new System.Windows.Forms.TextBox();
            this.buttonGetByYear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelectAvaliableCars = new System.Windows.Forms.Button();
            this.buttonShowAllCars = new System.Windows.Forms.Button();
            this.comboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVin = new System.Windows.Forms.TextBox();
            this.labelVin = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelFuel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.buttonEditCar = new System.Windows.Forms.Button();
            this.comboBoxAvaliable = new System.Windows.Forms.ComboBox();
            this.labelAvaliable = new System.Windows.Forms.Label();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCoast = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFuelType
            // 
            this.buttonFuelType.Location = new System.Drawing.Point(687, 492);
            this.buttonFuelType.Name = "buttonFuelType";
            this.buttonFuelType.Size = new System.Drawing.Size(93, 36);
            this.buttonFuelType.TabIndex = 35;
            this.buttonFuelType.Text = "Pokaz o rodzaju Paliwa";
            this.buttonFuelType.UseVisualStyleBackColor = true;
            this.buttonFuelType.Click += new System.EventHandler(this.buttonFuelType_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(-2, 1);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 39);
            this.buttonPrevious.TabIndex = 34;
            this.buttonPrevious.Text = "<-- Cofnij";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // checkBoxDiesel
            // 
            this.checkBoxDiesel.AutoSize = true;
            this.checkBoxDiesel.Location = new System.Drawing.Point(687, 469);
            this.checkBoxDiesel.Name = "checkBoxDiesel";
            this.checkBoxDiesel.Size = new System.Drawing.Size(55, 17);
            this.checkBoxDiesel.TabIndex = 33;
            this.checkBoxDiesel.Text = "Diesel";
            this.checkBoxDiesel.UseVisualStyleBackColor = true;
            // 
            // checkBoxPb
            // 
            this.checkBoxPb.AutoSize = true;
            this.checkBoxPb.Location = new System.Drawing.Point(687, 446);
            this.checkBoxPb.Name = "checkBoxPb";
            this.checkBoxPb.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPb.TabIndex = 32;
            this.checkBoxPb.Text = "Benzyna";
            this.checkBoxPb.UseVisualStyleBackColor = true;
            // 
            // textBoxShowModel
            // 
            this.textBoxShowModel.Location = new System.Drawing.Point(588, 482);
            this.textBoxShowModel.Name = "textBoxShowModel";
            this.textBoxShowModel.Size = new System.Drawing.Size(85, 20);
            this.textBoxShowModel.TabIndex = 31;
            // 
            // buttonShowModel
            // 
            this.buttonShowModel.Location = new System.Drawing.Point(588, 442);
            this.buttonShowModel.Name = "buttonShowModel";
            this.buttonShowModel.Size = new System.Drawing.Size(85, 23);
            this.buttonShowModel.TabIndex = 30;
            this.buttonShowModel.Text = "Pokaż  model";
            this.buttonShowModel.UseVisualStyleBackColor = true;
            this.buttonShowModel.Click += new System.EventHandler(this.buttonShowModel_Click);
            // 
            // textBoxShowCarByBrand
            // 
            this.textBoxShowCarByBrand.Location = new System.Drawing.Point(468, 482);
            this.textBoxShowCarByBrand.Name = "textBoxShowCarByBrand";
            this.textBoxShowCarByBrand.Size = new System.Drawing.Size(102, 20);
            this.textBoxShowCarByBrand.TabIndex = 29;
            // 
            // buttonShowCarByBrand
            // 
            this.buttonShowCarByBrand.Location = new System.Drawing.Point(468, 442);
            this.buttonShowCarByBrand.Name = "buttonShowCarByBrand";
            this.buttonShowCarByBrand.Size = new System.Drawing.Size(102, 23);
            this.buttonShowCarByBrand.TabIndex = 28;
            this.buttonShowCarByBrand.Text = "Pokaż Auta marki";
            this.buttonShowCarByBrand.UseVisualStyleBackColor = true;
            this.buttonShowCarByBrand.Click += new System.EventHandler(this.buttonShowCarByBrand_Click);
            // 
            // textBoxYearTo
            // 
            this.textBoxYearTo.Location = new System.Drawing.Point(348, 505);
            this.textBoxYearTo.Name = "textBoxYearTo";
            this.textBoxYearTo.Size = new System.Drawing.Size(57, 20);
            this.textBoxYearTo.TabIndex = 27;
            // 
            // textBoxYearFrom
            // 
            this.textBoxYearFrom.Location = new System.Drawing.Point(348, 479);
            this.textBoxYearFrom.Name = "textBoxYearFrom";
            this.textBoxYearFrom.Size = new System.Drawing.Size(57, 20);
            this.textBoxYearFrom.TabIndex = 26;
            // 
            // buttonGetByYear
            // 
            this.buttonGetByYear.Location = new System.Drawing.Point(326, 442);
            this.buttonGetByYear.Name = "buttonGetByYear";
            this.buttonGetByYear.Size = new System.Drawing.Size(121, 23);
            this.buttonGetByYear.TabIndex = 25;
            this.buttonGetByYear.Text = "Pokaż Auta z rocznika";
            this.buttonGetByYear.UseVisualStyleBackColor = true;
            this.buttonGetByYear.Click += new System.EventHandler(this.buttonGetByYear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "od";
            // 
            // buttonSelectAvaliableCars
            // 
            this.buttonSelectAvaliableCars.Location = new System.Drawing.Point(168, 474);
            this.buttonSelectAvaliableCars.Name = "buttonSelectAvaliableCars";
            this.buttonSelectAvaliableCars.Size = new System.Drawing.Size(121, 23);
            this.buttonSelectAvaliableCars.TabIndex = 22;
            this.buttonSelectAvaliableCars.Text = "Pokaż dostępne auta";
            this.buttonSelectAvaliableCars.UseVisualStyleBackColor = true;
            this.buttonSelectAvaliableCars.Click += new System.EventHandler(this.buttonSelectAvaliableCars_Click);
            // 
            // buttonShowAllCars
            // 
            this.buttonShowAllCars.Location = new System.Drawing.Point(168, 442);
            this.buttonShowAllCars.Name = "buttonShowAllCars";
            this.buttonShowAllCars.Size = new System.Drawing.Size(121, 23);
            this.buttonShowAllCars.TabIndex = 21;
            this.buttonShowAllCars.Text = "Pokaz wszystkie auta";
            this.buttonShowAllCars.UseVisualStyleBackColor = true;
            this.buttonShowAllCars.Click += new System.EventHandler(this.buttonShowAllCars_Click);
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
            this.comboBoxOrderBy.Location = new System.Drawing.Point(11, 474);
            this.comboBoxOrderBy.Name = "comboBoxOrderBy";
            this.comboBoxOrderBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrderBy.TabIndex = 20;
            this.comboBoxOrderBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sortuj według";
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Location = new System.Drawing.Point(-2, 46);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.Size = new System.Drawing.Size(782, 389);
            this.dataGridViewCar.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(735, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Edycja";
            // 
            // textBoxVin
            // 
            this.textBoxVin.Location = new System.Drawing.Point(814, 33);
            this.textBoxVin.Name = "textBoxVin";
            this.textBoxVin.Size = new System.Drawing.Size(100, 20);
            this.textBoxVin.TabIndex = 37;
            // 
            // labelVin
            // 
            this.labelVin.AutoSize = true;
            this.labelVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVin.Location = new System.Drawing.Point(835, 6);
            this.labelVin.Name = "labelVin";
            this.labelVin.Size = new System.Drawing.Size(38, 24);
            this.labelVin.TabIndex = 38;
            this.labelVin.Text = "Vin";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBrand.Location = new System.Drawing.Point(835, 56);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(60, 24);
            this.labelBrand.TabIndex = 40;
            this.labelBrand.Text = "Brand";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(814, 83);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 39;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(835, 106);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(63, 24);
            this.labelModel.TabIndex = 42;
            this.labelModel.Text = "Model";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(814, 133);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 41;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFuel.Location = new System.Drawing.Point(835, 156);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(48, 24);
            this.labelFuel.TabIndex = 44;
            this.labelFuel.Text = "Fuel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(835, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(814, 233);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(831, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 24);
            this.label10.TabIndex = 48;
            this.label10.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(791, 330);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(159, 85);
            this.textBoxDescription.TabIndex = 47;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Items.AddRange(new object[] {
            "Benzyna",
            "Diesel"});
            this.comboBoxFuel.Location = new System.Drawing.Point(814, 183);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFuel.TabIndex = 51;
            // 
            // buttonEditCar
            // 
            this.buttonEditCar.Location = new System.Drawing.Point(821, 472);
            this.buttonEditCar.Name = "buttonEditCar";
            this.buttonEditCar.Size = new System.Drawing.Size(98, 23);
            this.buttonEditCar.TabIndex = 52;
            this.buttonEditCar.Text = "Edytuj Auto";
            this.buttonEditCar.UseVisualStyleBackColor = true;
            this.buttonEditCar.Click += new System.EventHandler(this.buttonEditCar_Click);
            // 
            // comboBoxAvaliable
            // 
            this.comboBoxAvaliable.FormattingEnabled = true;
            this.comboBoxAvaliable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxAvaliable.Location = new System.Drawing.Point(817, 445);
            this.comboBoxAvaliable.Name = "comboBoxAvaliable";
            this.comboBoxAvaliable.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAvaliable.TabIndex = 54;
            // 
            // labelAvaliable
            // 
            this.labelAvaliable.AutoSize = true;
            this.labelAvaliable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAvaliable.Location = new System.Drawing.Point(820, 418);
            this.labelAvaliable.Name = "labelAvaliable";
            this.labelAvaliable.Size = new System.Drawing.Size(86, 24);
            this.labelAvaliable.TabIndex = 53;
            this.labelAvaliable.Text = "Avaliable";
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Location = new System.Drawing.Point(821, 504);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(114, 23);
            this.buttonDeleteCar.TabIndex = 55;
            this.buttonDeleteCar.Text = "Usuń Auto";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCost.Location = new System.Drawing.Point(835, 256);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(47, 24);
            this.labelCost.TabIndex = 57;
            this.labelCost.Text = "Cost";
            // 
            // textBoxCoast
            // 
            this.textBoxCoast.Location = new System.Drawing.Point(814, 283);
            this.textBoxCoast.Name = "textBoxCoast";
            this.textBoxCoast.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoast.TabIndex = 56;
            // 
            // CarPanelForAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 534);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.textBoxCoast);
            this.Controls.Add(this.buttonDeleteCar);
            this.Controls.Add(this.comboBoxAvaliable);
            this.Controls.Add(this.labelAvaliable);
            this.Controls.Add(this.buttonEditCar);
            this.Controls.Add(this.comboBoxFuel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelVin);
            this.Controls.Add(this.textBoxVin);
            this.Controls.Add(this.label4);
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
            this.Name = "CarPanelForAdministrator";
            this.Text = "CarPanelForAdministrator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFuelType;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.CheckBox checkBoxDiesel;
        private System.Windows.Forms.CheckBox checkBoxPb;
        private System.Windows.Forms.TextBox textBoxShowModel;
        private System.Windows.Forms.Button buttonShowModel;
        private System.Windows.Forms.TextBox textBoxShowCarByBrand;
        private System.Windows.Forms.Button buttonShowCarByBrand;
        private System.Windows.Forms.TextBox textBoxYearTo;
        private System.Windows.Forms.TextBox textBoxYearFrom;
        private System.Windows.Forms.Button buttonGetByYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectAvaliableCars;
        private System.Windows.Forms.Button buttonShowAllCars;
        private System.Windows.Forms.ComboBox comboBoxOrderBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVin;
        private System.Windows.Forms.Label labelVin;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Button buttonEditCar;
        private System.Windows.Forms.ComboBox comboBoxAvaliable;
        private System.Windows.Forms.Label labelAvaliable;
        private System.Windows.Forms.Button buttonDeleteCar;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCoast;
    }
}