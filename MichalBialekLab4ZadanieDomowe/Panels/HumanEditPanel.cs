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
    public partial class HumanEditPanel : Form
    {
        AdministratorPanel administratorPanel;
        Boolean isUser;
        private readonly MichalBialekDbContext _context;
        private readonly WriteRepositoryUser<User> _writeRepositoryUser;
        private readonly WriteRepositoryAdministrator<Administrator> _writeRepositoryAdministrator;
        private readonly ReadRepositoryAdministrator<Administrator> _readRepositoryAdministration;
        private readonly ReadRepositoryUser<User> _readRepositoryUser;
        public HumanEditPanel(Boolean isUser)
        {
            InitializeComponent();
            _context = new MichalBialekDbContext();
            _writeRepositoryUser = new WriteRepositoryUser<User>(_context);
            _readRepositoryUser = new ReadRepositoryUser<User>(_context);
            _writeRepositoryAdministrator = new WriteRepositoryAdministrator<Administrator>(_context);
            _readRepositoryAdministration = new ReadRepositoryAdministrator<Administrator>(_context);
            this.isUser = isUser;
            if (isUser == false)
            {
                labelShowAllHuman.Text = "Pokaz Wszystkich adminiow";
                buttonShowAllHuman.Text = "Pokaz Wszystkich adminiow";
                labelDeleteHuman.Text = "Usun Administratora";
                buttonDeleteHuman.Text = "usun Administratora";
                buttonEditHuman.Text = "Edytuj Administratora";
            }
        }

        private void buttonShowAllUsers_Click(object sender, EventArgs e)
        {
            ShowAllUsers();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();                
        }
                    
        private void buttonEditHuman_Click(object sender, EventArgs e)
        {
            EditHuman();       
        }

        private void buttonSelectById_Click(object sender, EventArgs e)
        {
            SelectById();    
        }

        private void buttonSelectByPesel_Click(object sender, EventArgs e)
        {
            SelectByPesel();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            administratorPanel = new AdministratorPanel();
            administratorPanel.Show();
            this.Hide();
        }

        private void buttonSearchBySurname_Click(object sender, EventArgs e)
        {
            SearchBySurname();
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            SearchByName();
        }

        private void EditHuman()
        {
            try
            {
                int pesel;
                pesel = int.Parse(dataGridViewHuman.SelectedRows[0].Cells[1].Value.ToString());
                if (isUser == true)
                {
                    User user;
                    user = _readRepositoryUser.GetByPesel(pesel).FirstOrDefault();
                    User newUser;
                    newUser = user;
                    if (textBoxName.Text != "")
                    {
                        newUser.Name = textBoxName.Text;
                    };
                    if (textBoxPassword.Text != "")
                    {
                        newUser.Password = textBoxPassword.Text;
                    };
                    if (textBoxSurname.Text != "")
                    {
                        newUser.Surname = textBoxSurname.Text;
                    };
                    if (textBoxLogin.Text != "")
                    {
                        newUser.Login = textBoxLogin.Text;
                    };
                    if (textBoxAdress.Text != "")
                    {
                        newUser.Adress = textBoxAdress.Text;
                    };
                    if (textBoxEmail.Text != "")
                    {
                        newUser.Email = textBoxEmail.Text;
                    };
                    if (textBoxPhoneNumber.Text != "")
                    {
                        newUser.PhoneNumber = int.Parse(textBoxPhoneNumber.Text);
                    };
                    if (textBoxDrivingLicense.Text != "")
                    {
                        newUser.DrivingLicense = int.Parse(textBoxDrivingLicense.Text);
                    }
                    _writeRepositoryUser.Edit(user, newUser);
                }
                else
                {
                    Administrator admin;
                    admin = _readRepositoryAdministration.GetByPesel(pesel).FirstOrDefault();
                    Administrator newAdmin;
                    newAdmin = admin;
                    if (textBoxName.Text != "")
                    {
                        newAdmin.Name = textBoxName.Text;
                    };
                    if (textBoxPassword.Text != "")
                    {
                        newAdmin.Password = textBoxPassword.Text;
                    };
                    if (textBoxSurname.Text != "")
                    {
                        newAdmin.Surname = textBoxSurname.Text;
                    };
                    if (textBoxLogin.Text != "")
                    {
                        newAdmin.Login = textBoxLogin.Text;
                    };
                    if (textBoxAdress.Text != "")
                    {
                        newAdmin.Adress = textBoxAdress.Text;
                    };
                    if (textBoxEmail.Text != "")
                    {
                        newAdmin.Email = textBoxEmail.Text;
                    };
                    if (textBoxPhoneNumber.Text != "")
                    {
                        newAdmin.PhoneNumber = int.Parse(textBoxPhoneNumber.Text);
                    };
                    if (textBoxDrivingLicense.Text != "")
                    {
                        newAdmin.DrivingLicense = int.Parse(textBoxDrivingLicense.Text);
                    }
                    _writeRepositoryAdministrator.Edit(admin, newAdmin);
                }
            }
            catch
            {
                MessageBox.Show("Nie wypelniles zadnego pola do edycji");
            }
        }

        private void SelectById()
        {
            try
            {
                if (isUser == false)
                {
                    dataGridViewHuman.DataSource = _readRepositoryAdministration.GetById(int.Parse(textBoxSelectById.Text));
                }
                else
                {
                    dataGridViewHuman.DataSource = _readRepositoryUser.GetById(int.Parse(textBoxSelectById.Text));
                }

            }
            catch
            {
                MessageBox.Show("Nie wpisałeś poprawnie Id");
            }
        }

        private void SelectByPesel()
        {
            try
            {
                if (isUser == false)
                {
                    dataGridViewHuman.DataSource = _readRepositoryAdministration.GetByPesel(int.Parse(textBoxSelectByPesel.Text));
                }
                else
                {
                    dataGridViewHuman.DataSource = _readRepositoryUser.GetByPesel(int.Parse(textBoxSelectByPesel.Text));
                }
            }
            catch
            {
                MessageBox.Show("Nie wpisales poprawnie Peselu");
            }
        }

        private void ShowAllUsers()
        {
            if (isUser == true)
            {
                dataGridViewHuman.DataSource = _readRepositoryUser.GetAll();
            }
            else
            {
                dataGridViewHuman.DataSource = _readRepositoryAdministration.GetAll();
            }
        }

        private void DeleteUser()
        {
            try
            {
                int pesel;
                pesel = int.Parse(dataGridViewHuman.SelectedRows[0].Cells[1].Value.ToString());
                if (isUser == true)
                {
                    User user;
                    user = _readRepositoryUser.GetByPesel(pesel).FirstOrDefault();
                    _writeRepositoryUser.Delete(user);
                }
                else
                {
                    Administrator admin;
                    admin = _readRepositoryAdministration.GetByPesel(pesel).FirstOrDefault();
                    _writeRepositoryAdministrator.Delete(admin);
                }
            }
            catch
            {
                MessageBox.Show("Pewnie nic nie zaznaczyłeś");
            }
        }

        private void SearchBySurname()
        {
            try
            {
                if (isUser == false)
                {
                    dataGridViewHuman.DataSource = _readRepositoryAdministration.GetBySurname(textBoxSearchBySurname.Text);
                }
                else
                {
                    dataGridViewHuman.DataSource = _readRepositoryUser.GetBySurname(textBoxSearchBySurname.Text);
                }

            }
            catch
            {
                MessageBox.Show("Nie wpisałeś poprawnie nazwiska");
            }
        }

        private void SearchByName()
        {
            try
            {
                if (isUser == false)
                {
                    dataGridViewHuman.DataSource = _readRepositoryAdministration.GetByName(textBoxSearchByName.Text);
                }
                else
                {
                    dataGridViewHuman.DataSource = _readRepositoryUser.GetByName(textBoxSearchByName.Text);
                }

            }
            catch
            {
                MessageBox.Show("Nie wpisałeś poprawnie nazwiska");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
