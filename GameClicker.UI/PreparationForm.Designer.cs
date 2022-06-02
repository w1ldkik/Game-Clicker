namespace GameClicker.UI
{
    partial class PreparationForm
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
            this.fightButton = new System.Windows.Forms.Button();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.lvlLabel = new System.Windows.Forms.Label();
            this.bossNameLabel = new System.Windows.Forms.Label();
            this.bossHpLabel = new System.Windows.Forms.Label();
            this.BossHpRegenLabel = new System.Windows.Forms.Label();
            this.bossPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bossPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fightButton
            // 
            this.fightButton.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fightButton.Location = new System.Drawing.Point(429, 251);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(322, 124);
            this.fightButton.TabIndex = 0;
            this.fightButton.Text = "Fight!";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // backMenuButton
            // 
            this.backMenuButton.Location = new System.Drawing.Point(429, 381);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(322, 45);
            this.backMenuButton.TabIndex = 1;
            this.backMenuButton.Text = "Back to menu";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.lvlLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvlLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lvlLabel.Location = new System.Drawing.Point(429, 38);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(63, 25);
            this.lvlLabel.TabIndex = 2;
            this.lvlLabel.Text = "label1";
            // 
            // bossNameLabel
            // 
            this.bossNameLabel.AutoSize = true;
            this.bossNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bossNameLabel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bossNameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.bossNameLabel.Location = new System.Drawing.Point(154, 393);
            this.bossNameLabel.Name = "bossNameLabel";
            this.bossNameLabel.Size = new System.Drawing.Size(105, 33);
            this.bossNameLabel.TabIndex = 3;
            this.bossNameLabel.Text = "label2";
            // 
            // bossHpLabel
            // 
            this.bossHpLabel.AutoSize = true;
            this.bossHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.bossHpLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bossHpLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bossHpLabel.Location = new System.Drawing.Point(429, 87);
            this.bossHpLabel.Name = "bossHpLabel";
            this.bossHpLabel.Size = new System.Drawing.Size(63, 25);
            this.bossHpLabel.TabIndex = 4;
            this.bossHpLabel.Text = "label3";
            // 
            // BossHpRegenLabel
            // 
            this.BossHpRegenLabel.AutoSize = true;
            this.BossHpRegenLabel.BackColor = System.Drawing.Color.Transparent;
            this.BossHpRegenLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BossHpRegenLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BossHpRegenLabel.Location = new System.Drawing.Point(429, 139);
            this.BossHpRegenLabel.Name = "BossHpRegenLabel";
            this.BossHpRegenLabel.Size = new System.Drawing.Size(63, 25);
            this.BossHpRegenLabel.TabIndex = 5;
            this.BossHpRegenLabel.Text = "label4";
            // 
            // bossPictureBox
            // 
            this.bossPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.bossPictureBox.Location = new System.Drawing.Point(31, 38);
            this.bossPictureBox.Name = "bossPictureBox";
            this.bossPictureBox.Size = new System.Drawing.Size(350, 350);
            this.bossPictureBox.TabIndex = 6;
            this.bossPictureBox.TabStop = false;
            // 
            // PreparationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameClicker.UI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.bossPictureBox);
            this.Controls.Add(this.BossHpRegenLabel);
            this.Controls.Add(this.bossHpLabel);
            this.Controls.Add(this.bossNameLabel);
            this.Controls.Add(this.lvlLabel);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.fightButton);
            this.Name = "PreparationForm";
            this.Text = "PreparationForm";
            this.Load += new System.EventHandler(this.PreparationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bossPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.Label lvlLabel;
        private System.Windows.Forms.Label bossNameLabel;
        private System.Windows.Forms.Label bossHpLabel;
        private System.Windows.Forms.Label BossHpRegenLabel;
        private System.Windows.Forms.PictureBox bossPictureBox;
    }
}