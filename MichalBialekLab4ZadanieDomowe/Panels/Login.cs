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
    public partial class Login : Form
    {
        private readonly MichalBialekDbContext _context;
        private readonly ReadRepositoryUser<User> _readRepositoryUser;
        private readonly ReadRepositoryAdministrator<Administrator> _readRepositoryAdministrator;
        StartWindow startWindow;
        CarView carView;
        AdministratorPanel administratorPanel;
        Boolean isUser;
        public Login(Boolean isUser)
        {
            InitializeComponent();
            this.isUser = isUser;
            _context = new MichalBialekDbContext();
            _readRepositoryUser = new ReadRepositoryUser<User>(_context);
            _readRepositoryAdministrator = new ReadRepositoryAdministrator<Administrator>(_context);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            startWindow = new StartWindow();
            startWindow.Show();
            this.Visible = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginHuman();
        }

        private void LoginHuman()
        {
            if (isUser == true)
            {
                if (_readRepositoryUser.GetByLoginAndPassword(textBoxLogin.Text, textBoxPassword.Text).Count == 1)
                {
                    MessageBox.Show("Zalogowano");
                    carView = new CarView();
                    carView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Niepoprawne Dane");
                }


            }
            else
            {
                if (_readRepositoryAdministrator.GetByLogin(textBoxLogin.Text, textBoxPassword.Text).Count == 1)
                {
                    MessageBox.Show("Zalogowano");
                    administratorPanel = new AdministratorPanel();
                    administratorPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Niepoprawne Dane");
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
