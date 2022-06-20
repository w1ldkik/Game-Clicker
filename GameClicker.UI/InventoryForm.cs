using GameClicker.BLL;
using GameClicker.DAL;
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
        public DataConteiner dataConteiner;
        public UserService userService;
        
        public InventoryForm(DataConteiner dataConteiner, UserService userService)
        {
            InitializeComponent();
            this.dataConteiner = dataConteiner;
            this.userService = userService;
            if (dataConteiner == null)
            {
                dataConteiner.User.Pet.Name = "Cat";
                    }

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

        private void weapon1PictureBox_Click(object sender, EventArgs e)
        {
            if (dataConteiner.User.Weapon.Name != "Pan") 
            {
                dataConteiner.User.WeaponId = 3;
                dataConteiner.User.Weapon = null;
                userService.UpdateUser();
                dataConteiner.User = userService.GetUserById(dataConteiner.User.Id);
                ApplySelectedItems();
            }
            
        }

        private void weapon2PictureBox_Click(object sender, EventArgs e)
        {
            if (dataConteiner.User.Weapon.Name != "Club")
            {
                dataConteiner.User.WeaponId = 2;
                dataConteiner.User.Weapon = null;
                userService.UpdateUser();
                dataConteiner.User = userService.GetUserById(dataConteiner.User.Id);
                ApplySelectedItems();
            }

        }

        public void ApplySelectedItems() 
        {
            switch (dataConteiner.User.Pet.Id)
            {
                case 3:
                    petSelectedPictureBox.Location = new Point(210, 365);
                    break;
                case 2:
                    petSelectedPictureBox.Location = new Point(465, 365);
                    break;
                case 1:
                    petSelectedPictureBox.Location = new Point(732, 365);
                    break;
                default:
                    break;
            }

            switch (dataConteiner.User.Weapon.Id)
            {
                case 3:
                    weaponSelectedPictureBox.Location = new Point(210, 158);
                    break;
                case 2:
                    weaponSelectedPictureBox.Location = new Point(465, 158);
                    break;
                case 1:
                    weaponSelectedPictureBox.Location = new Point(732, 158);
                    break;
                default:
                    break;
            }
        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            ApplySelectedItems();

        }

        private void weapon3PictureBox_Click(object sender, EventArgs e)
        {
            if (dataConteiner.User.Weapon.Name != "Sword")
            {
                dataConteiner.User.WeaponId = 1;
                dataConteiner.User.Weapon = null;
                userService.UpdateUser();
                dataConteiner.User = userService.GetUserById(dataConteiner.User.Id);
                ApplySelectedItems();
            }
        }

        private void petPictureBox1_Click(object sender, EventArgs e)
        {
            if (dataConteiner.User.Pet.Name != "Hamster")
            {
                dataConteiner.User.PetId = 3;
                dataConteiner.User.Pet = null;
                userService.UpdateUser();
                dataConteiner.User = userService.GetUserById(dataConteiner.User.Id);
                ApplySelectedItems();
            }
        }

        private void petPictureBox2_Click(object sender, EventArgs e)
        {
            if (dataConteiner.User.Pet.Name != "Cat")
            {
                dataConteiner.User.PetId = 2;
                dataConteiner.User.Pet = null;
                userService.UpdateUser();
                dataConteiner.User = userService.GetUserById(dataConteiner.User.Id);
                ApplySelectedItems();
            }
        }

        private void petPictureBox3_Click(object sender, EventArgs e)
        {
            if (dataConteiner.User.Pet.Name != "Dog")
            {
                dataConteiner.User.PetId = 1;
                dataConteiner.User.Pet = null;
                userService.UpdateUser();
                dataConteiner.User = userService.GetUserById(dataConteiner.User.Id);
                ApplySelectedItems();
            }
        }
    }
}
