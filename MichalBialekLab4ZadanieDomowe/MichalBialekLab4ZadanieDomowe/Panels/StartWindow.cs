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
    public partial class StartWindow : Form
    {
        Login login;
        SignIn signIn;
        public StartWindow()
        {
            InitializeComponent();
        }

        private void buttonAdministratorPanel_Click(object sender, EventArgs e)
        {
            login = new Login(false);
            this.Visible = false;
            login.Show();
        }

        private void buttonUserSingIn_Click(object sender, EventArgs e)
        {
            signIn = new SignIn(true,true);
            signIn.Show();
            this.Visible = false;
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            login = new Login(true);
            this.Visible = false;
            login.Show();
        }
    }
}
