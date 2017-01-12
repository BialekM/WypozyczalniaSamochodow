using MichalBialekLab4ZadanieDomowe.Models;
using MichalBialekLab4ZadanieDomowe.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalBialekLab4ZadanieDomowe.Panels
{
    public partial class CarPanelForAdministrator : Form
    {
        AdministratorPanel administratorPanel;
        private readonly MichalBialekDbContext _context;
        private readonly ReadRepositoryCar<Car> _readRepositoryCar;
        private readonly WriteRepositoryCar<Car> _writeRepositorycar;
        public CarPanelForAdministrator()
        {
            _context = new MichalBialekDbContext();
            _readRepositoryCar = new ReadRepositoryCar<Car>(_context);
            _writeRepositorycar = new WriteRepositoryCar<Car>(_context);
            InitializeComponent();
        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
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

        private void buttonSelectAvaliableCars_Click(object sender, EventArgs e)
        {
            ShowAvailableCars();
        }

        public void ShowAvailableCars()
        {
            dataGridViewCar.DataSource = _readRepositoryCar.GetByAvailable().Select(x => new
            {
                id = x.id,
                vin = x.Vin,
                Brand = x.Brand,
                Model = x.Model,
                Fuel = x.Fuel,
                Year = x.Year,
                Description = x.Description
            }).ToList();
        }

        private void buttonGetByYear_Click(object sender, EventArgs e)
        {
            GetByYear();  
        }

        private void GetByYear()
        {
            try
            {
                dataGridViewCar.DataSource = _readRepositoryCar.GetByYear(int.Parse(textBoxYearFrom.Text), int.Parse(textBoxYearTo.Text)).ToList();
                ClearTextBoxes();
            }
            catch
            {
                MessageBox.Show("Cos poszło nie tak - Pewnie puste pola");
            }
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

        private void buttonFuelType_Click(object sender, EventArgs e)
        {
            GetCarByFuelType();
        }

        private void GetCarByFuelType()
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

        private void buttonEditCar_Click(object sender, EventArgs e)
        {
            EditCar();
        }

        private void EditCar()
        {
            try
            {
                int id;
                id = int.Parse(dataGridViewCar.SelectedRows[0].Cells[1].Value.ToString());
                Car car;
                car = _readRepositoryCar.GetById(id).FirstOrDefault();
                Car newCar;
                newCar = car;
                if (textBoxVin.Text != "")
                {
                    newCar.Vin = textBoxVin.Text;
                }
                if (textBoxBrand.Text != "")
                {
                    newCar.Brand = textBoxBrand.Text;
                }
                if (textBoxModel.Text != "")
                {
                    newCar.Model = textBoxModel.Text;
                }
                if (comboBoxFuel.Text != "")
                {
                    newCar.Fuel = comboBoxFuel.Text;
                }
                if (textBoxYear.Text != "")
                {
                    newCar.Year = int.Parse(textBoxYear.Text);
                }
                if (textBoxDescription.Text != "")
                {
                    newCar.Description = textBoxDescription.Text;
                }
                if (comboBoxAvaliable.Text != "")
                {
                    if (comboBoxAvaliable.Text == "True")
                    {
                        newCar.available = true;
                    }
                    else
                    {
                        newCar.available = false;
                    }
                }
                if (textBoxCoast.Text != "")
                {
                    newCar.Cost = float.Parse(textBoxDescription.Text);
                }


            }
            catch
            {
                MessageBox.Show("Nie podales pewnie zadnych danych do zmiany,lub nie zaznaczyles nic w dataGridView");
            }
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            DeleteCar();
        }

        private void DeleteCar()
        {
            try
            {
                int id;
                id = int.Parse(dataGridViewCar.SelectedRows[0].Cells[1].Value.ToString());
                _writeRepositorycar.Delete(_readRepositoryCar.GetById(id).FirstOrDefault());
                dataGridViewCar.DataSource = _readRepositoryCar.GetAll();
            }
            catch
            {
                MessageBox.Show("Nie mozna usunac Auta");
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            administratorPanel = new AdministratorPanel();
            administratorPanel.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
