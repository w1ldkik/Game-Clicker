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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void inventoryButton_Click(object sender, EventArgs e)
        {
            Hide();
            var inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            var preparation = new PreparationForm();
            this.Hide();
            preparation.Show();
        }
    }
}
