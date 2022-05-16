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
            // PreparationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.fightButton);
            this.Name = "PreparationForm";
            this.Text = "PreparationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button backMenuButton;
    }
}