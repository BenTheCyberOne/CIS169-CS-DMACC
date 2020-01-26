namespace TextBoxDemo
{
    partial class TextBoxDemoForm
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
            this.AskUserLabel = new System.Windows.Forms.Label();
            this.ReadNameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ReadInputButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AskUserLabel
            // 
            this.AskUserLabel.AutoSize = true;
            this.AskUserLabel.Location = new System.Drawing.Point(103, 93);
            this.AskUserLabel.Name = "AskUserLabel";
            this.AskUserLabel.Size = new System.Drawing.Size(87, 13);
            this.AskUserLabel.TabIndex = 0;
            this.AskUserLabel.Text = "Enter your name:";
            // 
            // ReadNameLabel
            // 
            this.ReadNameLabel.AutoSize = true;
            this.ReadNameLabel.Location = new System.Drawing.Point(103, 144);
            this.ReadNameLabel.Name = "ReadNameLabel";
            this.ReadNameLabel.Size = new System.Drawing.Size(71, 13);
            this.ReadNameLabel.TabIndex = 1;
            this.ReadNameLabel.Text = "Your name is:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(201, 144);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(0, 13);
            this.UserNameLabel.TabIndex = 2;
            // 
            // ReadInputButton
            // 
            this.ReadInputButton.Location = new System.Drawing.Point(106, 233);
            this.ReadInputButton.Name = "ReadInputButton";
            this.ReadInputButton.Size = new System.Drawing.Size(75, 23);
            this.ReadInputButton.TabIndex = 3;
            this.ReadInputButton.Text = "Read I&nput";
            this.ReadInputButton.UseVisualStyleBackColor = true;
            this.ReadInputButton.Click += new System.EventHandler(this.ReadInputButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(204, 233);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "&Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(204, 90);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(100, 20);
            this.UserNameBox.TabIndex = 5;
            // 
            // TextBoxDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 289);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ReadInputButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ReadNameLabel);
            this.Controls.Add(this.AskUserLabel);
            this.Name = "TextBoxDemoForm";
            this.Text = "TextBox Demo";
            this.Load += new System.EventHandler(this.TextBoxDemoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AskUserLabel;
        private System.Windows.Forms.Label ReadNameLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button ReadInputButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox UserNameBox;
    }
}

