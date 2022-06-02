namespace GameClicker.UI
{
    partial class LoginForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationRadioButton = new System.Windows.Forms.RadioButton();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.aplyButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.greatestGameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginLabel.Location = new System.Drawing.Point(348, 146);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(60, 19);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(334, 216);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(96, 19);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // loginRadioButton
            // 
            this.loginRadioButton.AutoSize = true;
            this.loginRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.loginRadioButton.Checked = true;
            this.loginRadioButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginRadioButton.Location = new System.Drawing.Point(334, 312);
            this.loginRadioButton.Name = "loginRadioButton";
            this.loginRadioButton.Size = new System.Drawing.Size(59, 19);
            this.loginRadioButton.TabIndex = 2;
            this.loginRadioButton.TabStop = true;
            this.loginRadioButton.Text = "Login";
            this.loginRadioButton.UseVisualStyleBackColor = false;
            // 
            // registrationRadioButton
            // 
            this.registrationRadioButton.AutoSize = true;
            this.registrationRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.registrationRadioButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registrationRadioButton.Location = new System.Drawing.Point(336, 287);
            this.registrationRadioButton.Name = "registrationRadioButton";
            this.registrationRadioButton.Size = new System.Drawing.Size(100, 19);
            this.registrationRadioButton.TabIndex = 3;
            this.registrationRadioButton.Text = "Registration";
            this.registrationRadioButton.UseVisualStyleBackColor = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(292, 177);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(171, 23);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(292, 247);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(171, 23);
            this.passwordTextBox.TabIndex = 5;
            // 
            // aplyButton
            // 
            this.aplyButton.Location = new System.Drawing.Point(348, 337);
            this.aplyButton.Name = "aplyButton";
            this.aplyButton.Size = new System.Drawing.Size(115, 48);
            this.aplyButton.TabIndex = 6;
            this.aplyButton.Text = "Aply";
            this.aplyButton.UseVisualStyleBackColor = true;
            this.aplyButton.Click += new System.EventHandler(this.aplyButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(292, 337);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 48);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // greatestGameLabel
            // 
            this.greatestGameLabel.AutoSize = true;
            this.greatestGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.greatestGameLabel.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greatestGameLabel.ForeColor = System.Drawing.Color.Crimson;
            this.greatestGameLabel.Location = new System.Drawing.Point(90, 42);
            this.greatestGameLabel.Name = "greatestGameLabel";
            this.greatestGameLabel.Size = new System.Drawing.Size(595, 48);
            this.greatestGameLabel.TabIndex = 8;
            this.greatestGameLabel.Text = "The Greatest Clicker Game";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameClicker.UI.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.greatestGameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.aplyButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.registrationRadioButton);
            this.Controls.Add(this.loginRadioButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.RadioButton loginRadioButton;
        private System.Windows.Forms.RadioButton registrationRadioButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button aplyButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label greatestGameLabel;
    }
}