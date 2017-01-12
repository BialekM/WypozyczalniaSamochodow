using MichalBialekLab4ZadanieDomowe.Panels;
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
    public partial class AdministratorPanel : Form
    {
        StartWindow startWindow;
        SignIn signIn;
        CarAdd carAdd;
        HumanEditPanel userEditPanel;
        RentPanel rentPanel;
        CarPanelForAdministrator carPanelAdministrator;
        public AdministratorPanel()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            signIn = new SignIn(true,false);
            signIn.Show();
            this.Hide();
        }

        private void buttonAddAdministrator_Click(object sender, EventArgs e)
        {
            signIn = new SignIn(false,false);
            signIn.Show();
            this.Hide();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            carAdd = new CarAdd();
            carAdd.Show();
            this.Hide();
        }

        private void buttonUserEdit_Click(object sender, EventArgs e)
        {
            userEditPanel = new HumanEditPanel(true);
            userEditPanel.Show();
            this.Hide();
        }

        private void buttonEditAdministrator_Click(object sender, EventArgs e)
        {
            userEditPanel = new HumanEditPanel(false);
            userEditPanel.Show();
            this.Hide();
        }

        private void buttonAddRent_Click(object sender, EventArgs e)
        {
            rentPanel = new RentPanel();
            rentPanel.Show();
            this.Hide();
        }

        private void buttonCarPanel_Click(object sender, EventArgs e)
        {
            carPanelAdministrator = new CarPanelForAdministrator();
            carPanelAdministrator.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            startWindow = new StartWindow();
            startWindow.Show();
            this.Hide();
        }
    }
}
