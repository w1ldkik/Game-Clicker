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
    public partial class PreparationForm : Form
    {
        public PreparationForm()
        {
            InitializeComponent();
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainform = Application.OpenForms[1];
            mainform.Show();

        }
    }
}
