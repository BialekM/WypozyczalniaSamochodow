namespace MichalBialekLab4ZadanieDomowe
{
    partial class CarAdd
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
            this.textBoxVin = new System.Windows.Forms.TextBox();
            this.labelVin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.labelCoast = new System.Windows.Forms.Label();
            this.textBoxCoast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxVin
            // 
            this.textBoxVin.Location = new System.Drawing.Point(98, 59);
            this.textBoxVin.Name = "textBoxVin";
            this.textBoxVin.Size = new System.Drawing.Size(100, 20);
            this.textBoxVin.TabIndex = 0;
            // 
            // labelVin
            // 
            this.labelVin.AutoSize = true;
            this.labelVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVin.Location = new System.Drawing.Point(12, 54);
            this.labelVin.Name = "labelVin";
            this.labelVin.Size = new System.Drawing.Size(43, 25);
            this.labelVin.TabIndex = 1;
            this.labelVin.Text = "Vin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marka";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(98, 101);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 2;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(12, 137);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(71, 25);
            this.labelModel.TabIndex = 5;
            this.labelModel.Text = "Model";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(98, 142);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 4;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFuel.Location = new System.Drawing.Point(233, 59);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(75, 25);
            this.labelFuel.TabIndex = 7;
            this.labelFuel.Text = "Paliwo";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYear.Location = new System.Drawing.Point(233, 95);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(89, 25);
            this.labelYear.TabIndex = 9;
            this.labelYear.Text = "Rocznik";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(329, 101);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 8;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(280, 137);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(56, 25);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Opis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(202, 165);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(233, 134);
            this.textBoxDescription.TabIndex = 10;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(12, 257);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(113, 42);
            this.buttonAddCar.TabIndex = 12;
            this.buttonAddCar.Text = "Dodaj Auto";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(-3, -2);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 39);
            this.buttonPrevious.TabIndex = 13;
            this.buttonPrevious.Text = "<-- Cofnij";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Items.AddRange(new object[] {
            "Benzyna",
            "Diesel"});
            this.comboBoxFuel.Location = new System.Drawing.Point(329, 58);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFuel.TabIndex = 14;
            // 
            // labelCoast
            // 
            this.labelCoast.AutoSize = true;
            this.labelCoast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCoast.Location = new System.Drawing.Point(13, 175);
            this.labelCoast.Name = "labelCoast";
            this.labelCoast.Size = new System.Drawing.Size(63, 25);
            this.labelCoast.TabIndex = 16;
            this.labelCoast.Text = "Cena";
            // 
            // textBoxCoast
            // 
            this.textBoxCoast.Location = new System.Drawing.Point(99, 180);
            this.textBoxCoast.Name = "textBoxCoast";
            this.textBoxCoast.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoast.TabIndex = 15;
            // 
            // CarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 311);
            this.Controls.Add(this.labelCoast);
            this.Controls.Add(this.textBoxCoast);
            this.Controls.Add(this.comboBoxFuel);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelVin);
            this.Controls.Add(this.textBoxVin);
            this.Name = "CarAdd";
            this.Text = "CarAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVin;
        private System.Windows.Forms.Label labelVin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Label labelCoast;
        private System.Windows.Forms.TextBox textBoxCoast;
    }
}