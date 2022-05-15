using GameClicker.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClicker.UI
{
    public partial class LoginForm : Form
    {
        public RegistrationService registrationService;

        public LoginService loginService;

        public LoginForm(RegistrationService registrationService, LoginService loginService)
        {
            InitializeComponent();
            this.registrationService = registrationService;
            this.loginService = loginService;

        }

        private void aplyButton_Click(object sender, EventArgs e)
        {
            
            if (loginRadioButton.Checked)
            {
                var login = loginTextBox.Text;
                var password = passwordTextBox.Text;
                var user = loginService.Login(login, password);
                if (user is not null)
                {
                    MessageBox.Show("Succsesful loginnig");
                    Hide();
                    var mainForm = new MainForm();
                    mainForm.Show();
                }
                else 
                {
                    MessageBox.Show("Wrong login or password!  ");
                }
            }
            else 
            {   
                var login = loginTextBox.Text;
                var password = passwordTextBox.Text;
                registrationService.RegistrateUser(login, password);
                MessageBox.Show("User has been registrated,please login!");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
