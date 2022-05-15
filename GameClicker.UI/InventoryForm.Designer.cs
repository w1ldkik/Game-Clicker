namespace GameClicker.UI
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.selectWeaponLabel = new System.Windows.Forms.Label();
            this.weapon1PictureBox = new System.Windows.Forms.PictureBox();
            this.weapon2PictureBox = new System.Windows.Forms.PictureBox();
            this.weapon3PictureBox = new System.Windows.Forms.PictureBox();
            this.selectPetLabel = new System.Windows.Forms.Label();
            this.petPictureBox1 = new System.Windows.Forms.PictureBox();
            this.petPictureBox2 = new System.Windows.Forms.PictureBox();
            this.petPictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weapon1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Location = new System.Drawing.Point(5, 421);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(146, 37);
            this.backToMenuButton.TabIndex = 0;
            this.backToMenuButton.Text = "Return to menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // selectWeaponLabel
            // 
            this.selectWeaponLabel.AutoSize = true;
            this.selectWeaponLabel.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectWeaponLabel.Location = new System.Drawing.Point(262, 9);
            this.selectWeaponLabel.Name = "selectWeaponLabel";
            this.selectWeaponLabel.Size = new System.Drawing.Size(253, 27);
            this.selectWeaponLabel.TabIndex = 1;
            this.selectWeaponLabel.Text = "Select your weapon:";
            // 
            // weapon1PictureBox
            // 
            this.weapon1PictureBox.BackColor = System.Drawing.Color.SteelBlue;
            this.weapon1PictureBox.Image = global::GameClicker.UI.Properties.Resources.pan;
            this.weapon1PictureBox.Location = new System.Drawing.Point(44, 39);
            this.weapon1PictureBox.Name = "weapon1PictureBox";
            this.weapon1PictureBox.Size = new System.Drawing.Size(160, 160);
            this.weapon1PictureBox.TabIndex = 2;
            this.weapon1PictureBox.TabStop = false;
            this.weapon1PictureBox.MouseEnter += new System.EventHandler(this.weapon1PictureBox_MouseEnter);
            this.weapon1PictureBox.MouseLeave += new System.EventHandler(this.weapon1PictureBox_MouseLeave);
            this.weapon1PictureBox.MouseHover += new System.EventHandler(this.weapon1PictureBox_MouseHover);
            // 
            // weapon2PictureBox
            // 
            this.weapon2PictureBox.BackColor = System.Drawing.Color.DarkViolet;
            this.weapon2PictureBox.Image = global::GameClicker.UI.Properties.Resources.dubina;
            this.weapon2PictureBox.Location = new System.Drawing.Point(299, 39);
            this.weapon2PictureBox.Name = "weapon2PictureBox";
            this.weapon2PictureBox.Size = new System.Drawing.Size(160, 160);
            this.weapon2PictureBox.TabIndex = 3;
            this.weapon2PictureBox.TabStop = false;
            this.weapon2PictureBox.MouseEnter += new System.EventHandler(this.weapon2PictureBox_MouseEnter);
            this.weapon2PictureBox.MouseLeave += new System.EventHandler(this.weapon2PictureBox_MouseLeave);
            this.weapon2PictureBox.MouseHover += new System.EventHandler(this.weapon2PictureBox_MouseHover);
            // 
            // weapon3PictureBox
            // 
            this.weapon3PictureBox.BackColor = System.Drawing.Color.Orange;
            this.weapon3PictureBox.Image = global::GameClicker.UI.Properties.Resources.sword;
            this.weapon3PictureBox.Location = new System.Drawing.Point(566, 39);
            this.weapon3PictureBox.Name = "weapon3PictureBox";
            this.weapon3PictureBox.Size = new System.Drawing.Size(160, 160);
            this.weapon3PictureBox.TabIndex = 4;
            this.weapon3PictureBox.TabStop = false;
            this.weapon3PictureBox.MouseEnter += new System.EventHandler(this.weapon3PictureBox_MouseEnter);
            this.weapon3PictureBox.MouseLeave += new System.EventHandler(this.weapon3PictureBox_MouseLeave);
            this.weapon3PictureBox.MouseHover += new System.EventHandler(this.weapon3PictureBox_MouseHover);
            // 
            // selectPetLabel
            // 
            this.selectPetLabel.AutoSize = true;
            this.selectPetLabel.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectPetLabel.Location = new System.Drawing.Point(279, 216);
            this.selectPetLabel.Name = "selectPetLabel";
            this.selectPetLabel.Size = new System.Drawing.Size(206, 27);
            this.selectPetLabel.TabIndex = 5;
            this.selectPetLabel.Text = "Select your pet:";
            // 
            // petPictureBox1
            // 
            this.petPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.petPictureBox1.Image = global::GameClicker.UI.Properties.Resources.homka;
            this.petPictureBox1.Location = new System.Drawing.Point(44, 246);
            this.petPictureBox1.Name = "petPictureBox1";
            this.petPictureBox1.Size = new System.Drawing.Size(160, 160);
            this.petPictureBox1.TabIndex = 6;
            this.petPictureBox1.TabStop = false;
            this.petPictureBox1.MouseEnter += new System.EventHandler(this.petPictureBox1_MouseEnter);
            this.petPictureBox1.MouseLeave += new System.EventHandler(this.petPictureBox1_MouseLeave);
            this.petPictureBox1.MouseHover += new System.EventHandler(this.petPictureBox1_MouseHover);
            // 
            // petPictureBox2
            // 
            this.petPictureBox2.BackColor = System.Drawing.Color.DarkViolet;
            this.petPictureBox2.Image = global::GameClicker.UI.Properties.Resources.kitty;
            this.petPictureBox2.Location = new System.Drawing.Point(299, 246);
            this.petPictureBox2.Name = "petPictureBox2";
            this.petPictureBox2.Size = new System.Drawing.Size(160, 160);
            this.petPictureBox2.TabIndex = 7;
            this.petPictureBox2.TabStop = false;
            this.petPictureBox2.MouseEnter += new System.EventHandler(this.petPictureBox2_MouseEnter);
            this.petPictureBox2.MouseLeave += new System.EventHandler(this.petPictureBox2_MouseLeave);
            this.petPictureBox2.MouseHover += new System.EventHandler(this.petPictureBox2_MouseHover);
            // 
            // petPictureBox3
            // 
            this.petPictureBox3.BackColor = System.Drawing.Color.Orange;
            this.petPictureBox3.Image = global::GameClicker.UI.Properties.Resources.dogi;
            this.petPictureBox3.Location = new System.Drawing.Point(566, 246);
            this.petPictureBox3.Name = "petPictureBox3";
            this.petPictureBox3.Size = new System.Drawing.Size(160, 160);
            this.petPictureBox3.TabIndex = 8;
            this.petPictureBox3.TabStop = false;
            this.petPictureBox3.MouseEnter += new System.EventHandler(this.petPictureBox3_MouseEnter);
            this.petPictureBox3.MouseLeave += new System.EventHandler(this.petPictureBox3_MouseLeave);
            this.petPictureBox3.MouseHover += new System.EventHandler(this.petPictureBox3_MouseHover);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.petPictureBox3);
            this.Controls.Add(this.petPictureBox2);
            this.Controls.Add(this.petPictureBox1);
            this.Controls.Add(this.selectPetLabel);
            this.Controls.Add(this.weapon3PictureBox);
            this.Controls.Add(this.weapon2PictureBox);
            this.Controls.Add(this.weapon1PictureBox);
            this.Controls.Add(this.selectWeaponLabel);
            this.Controls.Add(this.backToMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.weapon1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Label selectWeaponLabel;
        private System.Windows.Forms.PictureBox weapon1PictureBox;
        private System.Windows.Forms.PictureBox weapon2PictureBox;
        private System.Windows.Forms.PictureBox weapon3PictureBox;
        private System.Windows.Forms.Label selectPetLabel;
        private System.Windows.Forms.PictureBox petPictureBox1;
        private System.Windows.Forms.PictureBox petPictureBox2;
        private System.Windows.Forms.PictureBox petPictureBox3;
    }
}