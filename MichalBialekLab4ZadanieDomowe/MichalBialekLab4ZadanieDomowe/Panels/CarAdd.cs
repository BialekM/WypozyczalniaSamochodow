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

namespace MichalBialekLab4ZadanieDomowe
{
    public partial class CarAdd : Form
    {
        private readonly MichalBialekDbContext _context;
        private readonly WriteRepositoryCar<Car> _writeRepositoryCar;
        AdministratorPanel administratorPanel;
        public CarAdd()
        {
            _context = new MichalBialekDbContext();
            _writeRepositoryCar = new WriteRepositoryCar<Car>(_context);
            InitializeComponent();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            administratorPanel = new AdministratorPanel();
            administratorPanel.Show();
            this.Hide();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            AddCar();
        }

        private void ClearTextBoxes()
        {
            textBoxVin.Clear();
            textBoxBrand.Clear();
            textBoxModel.Clear();
            comboBoxFuel.Text = "";
            textBoxYear.Clear();
            textBoxDescription.Clear();
        }

        private void AddCar()
        {
            try
            {
                Car car = new Car()
                {
                    id = 1,
                    Vin = textBoxVin.Text,
                    Brand = textBoxBrand.Text,
                    Model = textBoxModel.Text,
                    Fuel = comboBoxFuel.Text,
                    Year = int.Parse(textBoxYear.Text),
                    Description = textBoxDescription.Text,
                    available = true,
                    Cost = float.Parse(textBoxCoast.Text)
                };
                _writeRepositoryCar.Create(car);

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);

            }
            ClearTextBoxes();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
