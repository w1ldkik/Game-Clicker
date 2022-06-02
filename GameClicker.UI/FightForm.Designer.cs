namespace GameClicker.UI
{
    partial class FightForm
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
            this.components = new System.ComponentModel.Container();
            this.bossPictureBox = new System.Windows.Forms.PictureBox();
            this.hpLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hpRegenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bossPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bossPictureBox
            // 
            this.bossPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bossPictureBox.Location = new System.Drawing.Point(209, 54);
            this.bossPictureBox.Name = "bossPictureBox";
            this.bossPictureBox.Size = new System.Drawing.Size(350, 350);
            this.bossPictureBox.TabIndex = 0;
            this.bossPictureBox.TabStop = false;
            this.bossPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.BackColor = System.Drawing.Color.Transparent;
            this.hpLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hpLabel.ForeColor = System.Drawing.Color.Crimson;
            this.hpLabel.Location = new System.Drawing.Point(307, 9);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(161, 40);
            this.hpLabel.TabIndex = 1;
            this.hpLabel.Text = "000000000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hpRegenLabel
            // 
            this.hpRegenLabel.AutoSize = true;
            this.hpRegenLabel.BackColor = System.Drawing.Color.Transparent;
            this.hpRegenLabel.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hpRegenLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.hpRegenLabel.Location = new System.Drawing.Point(43, 374);
            this.hpRegenLabel.Name = "hpRegenLabel";
            this.hpRegenLabel.Size = new System.Drawing.Size(72, 30);
            this.hpRegenLabel.TabIndex = 2;
            this.hpRegenLabel.Text = "label1";
            // 
            // FightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameClicker.UI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.hpRegenLabel);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.bossPictureBox);
            this.Name = "FightForm";
            this.Text = "FightForm";
            this.Load += new System.EventHandler(this.FightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bossPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bossPictureBox;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hpRegenLabel;
    }
}