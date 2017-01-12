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
    public partial class SignIn : Form
    {
        Boolean isUser;
        Boolean returnToStartWindow;
        StartWindow startWindow;
        AdministratorPanel administratorPanel;
        private readonly MichalBialekDbContext _context;
        private readonly WriteRepositoryAdministrator<Administrator> _writeRepositoryAdministrator;
        private readonly WriteRepositoryUser<User> _writeRepositoryUser;


        public SignIn(Boolean isUser,Boolean returnToStartWindow)
        {
            InitializeComponent();
            _context = new MichalBialekDbContext();
            _writeRepositoryAdministrator = new WriteRepositoryAdministrator<Administrator>(_context);
            _writeRepositoryUser = new WriteRepositoryUser<User>(_context);
            this.isUser = isUser;
            this.returnToStartWindow = returnToStartWindow;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (returnToStartWindow == true)
            {
                startWindow = new StartWindow();
                startWindow.Show();
            }else
            {
                administratorPanel = new AdministratorPanel();
                administratorPanel.Show();
            }
            
            this.Visible = false;
        }

        private void SingIn_Click(object sender, EventArgs e)
        {
            SignInHuman();
        }

        private void SignInHuman()
        {
            if (isUser == false)
            {

                try
                {
                    Administrator administrator = new Administrator()
                    {
                        Pesel = int.Parse(textBoxPesel.Text),
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        DrivingLicense = int.Parse(textBoxDrivingLicense.Text),
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Adress = textBoxAdress.Text,
                        Email = textBoxEmail.Text,
                        PhoneNumber = int.Parse(textBoxPhoneNumber.Text)

                    };
                    _writeRepositoryAdministrator.Create(administrator);
                    MessageBox.Show("Dodano");
                    startWindow = new StartWindow();
                    startWindow.Show();
                    this.Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Nieprawidłowo wpisane dane");
                }
                ClearTextBoxes();
            }
            else
            {

                try
                {
                    User user = new User()
                    {
                        Pesel = int.Parse(textBoxPesel.Text),
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        DrivingLicense = int.Parse(textBoxDrivingLicense.Text),
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Adress = textBoxAdress.Text,
                        Email = textBoxEmail.Text,
                        PhoneNumber = int.Parse(textBoxPhoneNumber.Text)

                    };
                    _writeRepositoryUser.Create(user);
                    MessageBox.Show("Dodano");
                    startWindow = new StartWindow();
                    startWindow.Show();
                    this.Hide();

                }
                catch (Exception)
                {
                    MessageBox.Show("Nieprawidłowo wpisane Dane");
                }
                ClearTextBoxes();
            }
        }
            

        public void ClearTextBoxes()
        {
            textBoxPesel.Clear();
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            textBoxDrivingLicense.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAdress.Clear();
            textBoxEmail.Clear();
            textBoxPhoneNumber.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

    }
}


