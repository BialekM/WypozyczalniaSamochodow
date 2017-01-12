using MichalBialekLab4ZadanieDomowe.Models;
using MichalBialekLab4ZadanieDomowe.Repository;
using MichalBialekLab4ZadanieDomowe.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalBialekLab4ZadanieDomowe
{
    public partial class CarView : Form
    {
        StartWindow startWindow;
        private readonly MichalBialekDbContext _context;
        private readonly ReadRepositoryCar<Car> _readRepositoryCar;
        public CarView()
        {
            _context = new MichalBialekDbContext();
            _readRepositoryCar = new ReadRepositoryCar<Car>(_context);
            InitializeComponent();

        }

        private void buttonShowAllCars_Click(object sender, EventArgs e)
        {
            ShowCars();

        }

        public void ShowCars()
        {
            dataGridViewCar.DataSource = null;
            dataGridViewCar.DataSource = _readRepositoryCar
                .GetAll()
                .Select(x => new
                {
                    id = x.id,
                    Vin = x.Vin,
                    Brand = x.Brand,
                    Model = x.Model,
                    Fuel = x.Fuel,
                    Year = x.Year,
                    Description = x.Description,
                    Avaliable = x.available
                })
                .ToList();
        }

        public void ShowAvailableCars()
        {
            dataGridViewCar.DataSource = _readRepositoryCar.GetByAvailable().Select(x => new {
                id = x.id,
                vin = x.Vin,
                Brand =x.Brand,
                Model = x.Model,
                Fuel = x.Fuel,
                Year = x.Year,
                Description = x.Description
            }).ToList();
        }

        private void buttonSelectAvaliableCars_Click(object sender, EventArgs e)
        {
            ShowAvailableCars();
        }

        private void buttonShowCarByBrand_Click(object sender, EventArgs e)
        {
            ShowCarByBrand();
        }

        private void ShowCarByBrand()
        {
            dataGridViewCar.DataSource = _readRepositoryCar.GetByBrand(textBoxShowCarByBrand.Text).Select(x => new
            {
                id = x.id,
                vin = x.Vin,
                Brand = x.Brand,
                Model = x.Model,
                Fuel = x.Fuel,
                Year = x.Year,
                Description = x.Description,
                Avaliable = x.available
            }).ToList();
            ClearTextBoxes();
        }

        private void buttonShowModel_Click(object sender, EventArgs e)
        {
            ShowCarByModel();
        }

        private void ShowCarByModel()
        {
            dataGridViewCar.DataSource = _readRepositoryCar.GetByModel(textBoxShowModel.Text).Select(x => new
            {
                id = x.id,
                vin = x.Vin,
                Brand = x.Brand,
                Model = x.Model,
                Fuel = x.Fuel,
                Year = x.Year,
                Description = x.Description,
                Avaliable = x.available
            }).ToList();
            ClearTextBoxes();
        }

        private void buttonGetByYear_Click(object sender, EventArgs e)
        {
            ShowCarByYear();
        }

        private void ShowCarByYear()
        {
            dataGridViewCar.DataSource = _readRepositoryCar.GetByYear(int.Parse(textBoxYearFrom.Text), int.Parse(textBoxYearTo.Text)).ToList();
            ClearTextBoxes();
        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderBy();
        }

        private void OrderBy()
        {
            if (comboBoxOrderBy.Text == "Id")
            {

                dataGridViewCar.DataSource = null;
                dataGridViewCar.DataSource = _readRepositoryCar.GetAll().OrderBy(x => x.id).ToList();
            }
            else if (comboBoxOrderBy.Text == "Brand")
            {
                dataGridViewCar.DataSource = null;
                dataGridViewCar.DataSource = _readRepositoryCar.GetAll().OrderBy(x => x.Brand).ToList();
            }
            else if (comboBoxOrderBy.Text == "Vin")
            {
                dataGridViewCar.DataSource = null;
                dataGridViewCar.DataSource = _readRepositoryCar.GetAll().OrderBy(x => x.Vin).ToList();
            }
            else if (comboBoxOrderBy.Text == "Year")
            {
                dataGridViewCar.DataSource = null;
                dataGridViewCar.DataSource = _readRepositoryCar.GetAll().OrderBy(x => x.Year).ToList();
            }
            else if (comboBoxOrderBy.Text == "Model")
            {
                dataGridViewCar.DataSource = null;
                dataGridViewCar.DataSource = _readRepositoryCar.GetAll().OrderBy(x => x.Model).ToList();
            }
        }

        private void buttonFuelType_Click(object sender, EventArgs e)
        {
            FuelType();
        }

        private void FuelType()
        {
            if (checkBoxDiesel.Checked && checkBoxPb.Checked)
            {
                dataGridViewCar.DataSource = _readRepositoryCar.GetByFuel(true, true).ToList();
            }
            else if (checkBoxPb.Checked)
            {
                dataGridViewCar.DataSource = _readRepositoryCar.GetByFuel(true, false).ToList();
            }
            else if (checkBoxDiesel.Checked)
            {
                dataGridViewCar.DataSource = _readRepositoryCar.GetByFuel(false, true).ToList();
            }
        }

        private void ClearTextBoxes()
        {
            textBoxShowCarByBrand.Clear();
            textBoxShowModel.Clear();
            textBoxYearFrom.Clear();            
            textBoxYearTo.Clear();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            startWindow = new StartWindow();
            startWindow.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
