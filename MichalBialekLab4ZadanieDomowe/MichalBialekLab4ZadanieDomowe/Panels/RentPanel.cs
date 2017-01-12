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
    public partial class RentPanel : Form
    {
        readonly MichalBialekDbContext _context;
        readonly WriteRepositoryRent<Rent> _writeRepositoryRent;
        readonly ReadRepositoryCar<Car> _readRepositoryCar;
        readonly ReadRepositoryUser<User> _readRepositoryUser;
        readonly WriteRepositoryCar<Car> _writeRepositoryCar;
        readonly ReadRepositoryRent<Rent> _readRepositoryRent;
        AdministratorPanel administratorPanel;
        public RentPanel()
        {
            InitializeComponent();
            _context = new MichalBialekDbContext();
            _writeRepositoryRent = new WriteRepositoryRent<Rent>(_context);
            _readRepositoryCar = new ReadRepositoryCar<Car>(_context);
            _readRepositoryUser = new ReadRepositoryUser<User>(_context);
            _writeRepositoryCar = new WriteRepositoryCar<Car>(_context);
            _readRepositoryRent = new ReadRepositoryRent<Rent>(_context);

        }

        private void buttonAddRent_Click(object sender, EventArgs e)
        {
            AddRent();
        }

        private void AddRent()
        {
            try
            {
                Rent rent;
                rent = new Rent();
                Car car;
                car = _readRepositoryCar.GetById(int.Parse(textBoxCarId.Text)).FirstOrDefault();
                if (car.available == false)
                {
                    MessageBox.Show("samochod jest niedostepny");
                }
                else
                {
                    Car newCar;
                    newCar = car;
                    newCar.available = false;
                    _writeRepositoryCar.Edit(car, newCar);

                    User user;
                    user = _readRepositoryUser.GetById(int.Parse(textBoxUserId.Text)).FirstOrDefault();
                    rent.User = user;
                    rent.Car = car;
                    rent.Expense = 0;
                    rent.DateOfHire = DateTime.Today;
                    rent.DateOfEnd = null;
                    _writeRepositoryRent.Create(rent);
                }
            }
            catch
            {
                MessageBox.Show("Niepoprawne Dane");
            }
        }

        private void buttonShowAllRents_Click(object sender, EventArgs e)
        {
            ShowAllRents();
        }

        private void ShowAllRents()
        {
            dataGridViewRents.DataSource = _readRepositoryRent.GetAll().Select(x => new
            {
                x.RentId,
                x.DateOfHire,
                x.Expense,
                x.DateOfEnd,
                x.Car.id,
                x.Car.Brand,
                x.Car.Model,
                x.User.Id,
                x.User.Name,
                x.User.Surname
            }
               ).ToList();
        }

        private void buttonDeleteRent_Click(object sender, EventArgs e)
        {
            DeleteRent();
        }

        private void DeleteRent()
        {
            try
            {
                int idRent;
                idRent = int.Parse(dataGridViewRents.SelectedRows[0].Cells[0].Value.ToString());
                Rent rent;
                rent = _readRepositoryRent.GetById(idRent).FirstOrDefault();
                int carId;
                carId = _readRepositoryRent.GetById(idRent).FirstOrDefault().Car.id;
                Car car;
                Car newCar;
                car=_readRepositoryCar.GetById(carId).FirstOrDefault();
                newCar = car;
                newCar.available = true;
                _writeRepositoryCar.Edit(car, newCar);
                _writeRepositoryRent.Delete(rent);
                dataGridViewRents.DataSource = _readRepositoryRent.GetAll().Select(x => new
                {
                    x.RentId,
                    x.DateOfHire,
                    x.Expense,
                    x.DateOfEnd,
                    x.Car.id,
                    x.Car.Brand,
                    x.Car.Model,
                    x.User.Id,
                    x.User.Name,
                    x.User.Surname
                }
                    ).ToList(); ;
            }
            catch
            {
                MessageBox.Show("Nie można usunąc obiektu");
            }
        }

        private void buttonShowRentWhereId_Click(object sender, EventArgs e)
        {
            ShowRentWhereId();
        }

        private void ShowRentWhereId()
        {
            try
            {
                dataGridViewRents.DataSource = _readRepositoryRent.GetById(int.Parse(textBoxShowRentWhereId.Text)).Select(x => new
                {
                    x.RentId,
                    x.DateOfHire,
                    x.Expense,
                    x.DateOfEnd,
                    x.Car.id,
                    x.Car.Brand,
                    x.Car.Model,
                    x.User.Id,
                    x.User.Name,
                    x.User.Surname
                }
                             ).ToList(); ;
            }
            catch
            {
                MessageBox.Show("Nie podałeś Id bądź wpisałeś tam coś innego niż cyfre");
            }
        }

        private void buttonEditRent_Click(object sender, EventArgs e)
        {
            EditRent();
        }

        private void EditRent()
        {
            try
            {
                int idRent;
                idRent = int.Parse(dataGridViewRents.SelectedRows[0].Cells[0].Value.ToString());
                Rent rent;
                rent = _readRepositoryRent.GetById(idRent).FirstOrDefault();
                rent = _readRepositoryRent.GetById(idRent).FirstOrDefault();
                Rent newRent;
                newRent = rent;
                if (textBoxRentExpense.Text != "")
                {
                    newRent.Expense = float.Parse(textBoxRentExpense.Text);
                }
                if (maskedTextBoxRentDateOfHire.Text != "")
                {

                    if (CheckData(maskedTextBoxRentDateOfHire) == false)
                    {
                        MessageBox.Show("Zły format Daty");
                    }
                    else
                    {
                        newRent.DateOfHire = DateTime.Parse(maskedTextBoxRentDateOfHire.Text);
                    }

                }
                if (maskedTextBoxDateOfEnd.Text != "")
                {
                    if (CheckData(maskedTextBoxDateOfEnd) == false)
                    {
                        MessageBox.Show("Zły format Daty");
                    }
                    else
                    {
                        newRent.DateOfEnd = DateTime.Parse(maskedTextBoxDateOfEnd.Text);
                    }
                }
                if (textBoxRentUserId.Text != "")
                {
                    newRent.User.Id = int.Parse(textBoxRentUserId.Text);
                }
                if (textBoxRentUserId.Text != "")
                {
                    newRent.Car.id = int.Parse(textBoxRentCarId.Text);
                }
                _writeRepositoryRent.Edit(rent, newRent);
                dataGridViewRents.DataSource = _readRepositoryRent.GetById(newRent.RentId).Select(x => new
                {
                    x.RentId,
                    x.DateOfHire,
                    x.Expense,
                    x.DateOfEnd,
                    x.Car.id,
                    x.Car.Brand,
                    x.Car.Model,
                    x.User.Id,
                    x.User.Name,
                    x.User.Surname
                }
                    ).ToList();
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak , pewnie nie wypełniles żadnego pola do edycji");
            }
        }

        private void buttonPickURent_Click(object sender, EventArgs e)
        {
            PickUpRent();
        }

        private void PickUpRent()
        {
            try
            {
                int idRent;
                idRent = int.Parse(dataGridViewRents.SelectedRows[0].Cells[0].Value.ToString());
                Rent rent;
                rent = _readRepositoryRent.GetById(idRent).FirstOrDefault();
                rent = _readRepositoryRent.GetById(idRent).FirstOrDefault();
                Rent newRent;
                newRent = rent;
                newRent.Car.available = true;
                newRent.DateOfEnd = DateTime.Today;
                int NumberOfDays = newRent.DateOfEnd.Value.Day - newRent.DateOfHire.Day;
                newRent.Expense = NumberOfDays * newRent.Car.Cost;
                _writeRepositoryRent.Edit(rent, newRent);
                dataGridViewRents.DataSource = _readRepositoryRent.GetById(newRent.RentId);
            }
            catch
            {
                MessageBox.Show("Pewnie nie zaznaczyles nic");
            }
        }

        private Boolean CheckData(MaskedTextBox mTextBox)
        {
            if (mTextBox.Text.Count() != 10)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < mTextBox.Text.Count(); i++)
                {
                    if (i == 2 || i == 5)
                    {
                        if (mTextBox.Text[i] != '.')
                        {
                            return false;
                        }
                    }
                    if (i < 2 || (i > 2 && i < 5) || i > 5)
                    {
                        if (mTextBox.Text[i] < '0' && mTextBox.Text[i] > '9')
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        private void buttonShowRentsWhereData_Click(object sender, EventArgs e)
        {
            ShowRentsWheredata();
        }

        private void ShowRentsWheredata()
        {
            if (CheckData(maskedTextBoxRentFrom) == true && CheckData(maskedTextBoxRentTo) == true)
            {
                dataGridViewRents.DataSource = _readRepositoryRent.GetByBetweenDateOfHireAndDateOEnd(DateTime.Parse(maskedTextBoxRentFrom.Text), DateTime.Parse(maskedTextBoxRentTo.Text)).Select(x => new
                {
                    x.RentId,
                    x.DateOfHire,
                    x.Expense,
                    x.DateOfEnd,
                    x.Car.id,
                    x.Car.Brand,
                    x.Car.Model,
                    x.User.Id,
                    x.User.Name,
                    x.User.Surname
                }
                ).ToList(); ;
            }
            else if (CheckData(maskedTextBoxRentFrom) == true && CheckData(maskedTextBoxRentTo) == false)
            {
                dataGridViewRents.DataSource = _readRepositoryRent.GetByBiggerDateOfHire(DateTime.Parse(maskedTextBoxRentFrom.Text)).Select(x => new
                {
                    x.RentId,
                    x.DateOfHire,
                    x.Expense,
                    x.DateOfEnd,
                    x.Car.id,
                    x.Car.Brand,
                    x.Car.Model,
                    x.User.Id,
                    x.User.Name,
                    x.User.Surname
                }
                ).ToList(); ;
            }
            else if (CheckData(maskedTextBoxRentFrom) == false && CheckData(maskedTextBoxRentTo) == true)
            {
                dataGridViewRents.DataSource = _readRepositoryRent.GetBySmallerDateOEnd(DateTime.Parse(maskedTextBoxRentTo.Text)).Select(x => new
                {
                    x.RentId,
                    x.DateOfHire,
                    x.Expense,
                    x.DateOfEnd,
                    x.Car.id,
                    x.Car.Brand,
                    x.Car.Model,
                    x.User.Id,
                    x.User.Name,
                    x.User.Surname
                }
                ).ToList(); ;
            }
            else
            {
                MessageBox.Show("Źle wpisane Daty");
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
