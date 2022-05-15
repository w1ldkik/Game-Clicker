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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void weapon1PictureBox_MouseEnter(object sender, EventArgs e)
        {
            weapon1PictureBox.Size = new Size { Width = 170, Height = 170 };
            weapon1PictureBox.Image = GameClicker.UI.Properties.Resources.panBig;
        }

        private void weapon1PictureBox_MouseLeave(object sender, EventArgs e)
        {
            weapon1PictureBox.Size = new Size { Width = 160, Height = 160 };
            weapon1PictureBox.Image = GameClicker.UI.Properties.Resources.pan;
        }

        private void weapon1PictureBox_MouseHover(object sender, EventArgs e)
        {
            weapon1PictureBox.Size = new Size { Width = 170, Height = 170 };
            weapon1PictureBox.Image = GameClicker.UI.Properties.Resources.panBigDiscr;
        }



       
        /// 

        private void weapon2PictureBox_MouseEnter(object sender, EventArgs e)
        {
            weapon2PictureBox.Size = new Size { Width = 170, Height = 170 };
            weapon2PictureBox.Image = GameClicker.UI.Properties.Resources.dubinaBig;
        }

        private void weapon2PictureBox_MouseHover(object sender, EventArgs e)
        {
            weapon2PictureBox.Size = new Size { Width = 170, Height = 170 };
            weapon2PictureBox.Image = GameClicker.UI.Properties.Resources.dubinaBigDiscr;
        }

        private void weapon2PictureBox_MouseLeave(object sender, EventArgs e)
        {
            weapon2PictureBox.Size = new Size { Width = 160, Height = 160 };
            weapon2PictureBox.Image = GameClicker.UI.Properties.Resources.dubina;
        }



        /// 


      
        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form mainform = Application.OpenForms[1];
            mainform.Show();
        }


        
        /// 
        


        private void weapon3PictureBox_MouseEnter(object sender, EventArgs e)
        {
            weapon3PictureBox.Size = new Size { Width = 170, Height = 170 };
            weapon3PictureBox.Image = GameClicker.UI.Properties.Resources.swordBig;
        }

        private void weapon3PictureBox_MouseHover(object sender, EventArgs e)
        {
            weapon3PictureBox.Size = new Size { Width = 170, Height = 170 };
            weapon3PictureBox.Image = GameClicker.UI.Properties.Resources.swordBigDescr;
        }

        private void weapon3PictureBox_MouseLeave(object sender, EventArgs e)
        {
            weapon3PictureBox.Size = new Size { Width = 160, Height = 160 };
            weapon3PictureBox.Image = GameClicker.UI.Properties.Resources.sword;
        }
        
        ///
        
        private void petPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            petPictureBox1.Size = new Size { Width = 170, Height = 170 };
            petPictureBox1.Image = GameClicker.UI.Properties.Resources.homkaBig;
        }

        private void petPictureBox1_MouseHover(object sender, EventArgs e)
        {
            petPictureBox1.Size = new Size { Width = 170, Height = 170 };
            petPictureBox1.Image = GameClicker.UI.Properties.Resources.homkaBigDescription;
        }

        private void petPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            petPictureBox1.Size = new Size { Width = 160, Height = 160 };
            petPictureBox1.Image = GameClicker.UI.Properties.Resources.homka;
        }
        
        /// 
        
        private void petPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            petPictureBox2.Size = new Size { Width = 170, Height = 170 };
            petPictureBox2.Image = GameClicker.UI.Properties.Resources.kittyBig;
        }

        private void petPictureBox2_MouseHover(object sender, EventArgs e)
        {
            petPictureBox2.Size = new Size { Width = 170, Height = 170 };
            petPictureBox2.Image = GameClicker.UI.Properties.Resources.kittyBigDescr;
        }

        private void petPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            petPictureBox2.Size = new Size { Width = 160, Height = 160 };
            petPictureBox2.Image = GameClicker.UI.Properties.Resources.kitty;
        }

       /// 

        private void petPictureBox3_MouseEnter(object sender, EventArgs e)
        {
            petPictureBox3.Size = new Size { Width = 170, Height = 170 };
            petPictureBox3.Image = GameClicker.UI.Properties.Resources.dogiBig;
        }

        private void petPictureBox3_MouseHover(object sender, EventArgs e)
        {
            petPictureBox3.Size = new Size { Width = 170, Height = 170 };
            petPictureBox3.Image = GameClicker.UI.Properties.Resources.dogiBigDescr;
        }

        private void petPictureBox3_MouseLeave(object sender, EventArgs e)
        {
            petPictureBox3.Size = new Size { Width = 160, Height = 160 };
            petPictureBox3.Image = GameClicker.UI.Properties.Resources.dogi;
        }
    }
}
