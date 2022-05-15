namespace GameClicker.UI
{
    partial class MainForm
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
            this.greatestGameLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greatestGameLabel
            // 
            this.greatestGameLabel.AutoSize = true;
            this.greatestGameLabel.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greatestGameLabel.Location = new System.Drawing.Point(90, 42);
            this.greatestGameLabel.Name = "greatestGameLabel";
            this.greatestGameLabel.Size = new System.Drawing.Size(595, 48);
            this.greatestGameLabel.TabIndex = 9;
            this.greatestGameLabel.Text = "The Greatest Clicker Game";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(292, 177);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(171, 46);
            this.playButton.TabIndex = 10;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(292, 242);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(171, 46);
            this.inventoryButton.TabIndex = 11;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(292, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 46);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.greatestGameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greatestGameLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button exitButton;
    }
}