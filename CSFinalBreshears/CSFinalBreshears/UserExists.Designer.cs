namespace CSFinalBreshears
{
    partial class UserExists
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
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.attendedRadioButton = new System.Windows.Forms.RadioButton();
            this.noAttendedRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(63, 104);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(121, 21);
            this.courseComboBox.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(63, 46);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(2, 18);
            this.welcomeLabel.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(24, 210);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // attendedRadioButton
            // 
            this.attendedRadioButton.AutoSize = true;
            this.attendedRadioButton.Checked = true;
            this.attendedRadioButton.Location = new System.Drawing.Point(77, 146);
            this.attendedRadioButton.Name = "attendedRadioButton";
            this.attendedRadioButton.Size = new System.Drawing.Size(96, 17);
            this.attendedRadioButton.TabIndex = 3;
            this.attendedRadioButton.TabStop = true;
            this.attendedRadioButton.Text = "Attended Class";
            this.attendedRadioButton.UseVisualStyleBackColor = true;
            // 
            // noAttendedRadioButton
            // 
            this.noAttendedRadioButton.AutoSize = true;
            this.noAttendedRadioButton.Location = new System.Drawing.Point(77, 178);
            this.noAttendedRadioButton.Name = "noAttendedRadioButton";
            this.noAttendedRadioButton.Size = new System.Drawing.Size(95, 17);
            this.noAttendedRadioButton.TabIndex = 4;
            this.noAttendedRadioButton.Text = "Did Not Attend";
            this.noAttendedRadioButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(150, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserExists
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(274, 255);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.attendedRadioButton);
            this.Controls.Add(this.noAttendedRadioButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "UserExists";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.UserExists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RadioButton attendedRadioButton;
        private System.Windows.Forms.RadioButton noAttendedRadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}