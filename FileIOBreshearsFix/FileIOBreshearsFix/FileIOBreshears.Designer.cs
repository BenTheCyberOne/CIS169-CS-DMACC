namespace FileIOBreshearsFix
{
    partial class FileIOBreshears
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
            this.exitButton = new System.Windows.Forms.Button();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.ReadNameButton = new System.Windows.Forms.Button();
            this.FriendListTextBox = new System.Windows.Forms.TextBox();
            this.FriendListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(258, 57);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(48, 57);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(75, 23);
            this.writeNameButton.TabIndex = 6;
            this.writeNameButton.Text = "&Write Name";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(129, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(153, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(14, 20);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(109, 13);
            this.promptLabel.TabIndex = 4;
            this.promptLabel.Text = "Enter a friend\'s name:";
            // 
            // ReadNameButton
            // 
            this.ReadNameButton.Location = new System.Drawing.Point(154, 57);
            this.ReadNameButton.Name = "ReadNameButton";
            this.ReadNameButton.Size = new System.Drawing.Size(75, 23);
            this.ReadNameButton.TabIndex = 8;
            this.ReadNameButton.Text = "&Read Name";
            this.ReadNameButton.UseVisualStyleBackColor = true;
            this.ReadNameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FriendListTextBox
            // 
            this.FriendListTextBox.Location = new System.Drawing.Point(117, 145);
            this.FriendListTextBox.Multiline = true;
            this.FriendListTextBox.Name = "FriendListTextBox";
            this.FriendListTextBox.Size = new System.Drawing.Size(153, 97);
            this.FriendListTextBox.TabIndex = 9;
            // 
            // FriendListLabel
            // 
            this.FriendListLabel.AutoSize = true;
            this.FriendListLabel.Location = new System.Drawing.Point(114, 129);
            this.FriendListLabel.Name = "FriendListLabel";
            this.FriendListLabel.Size = new System.Drawing.Size(96, 13);
            this.FriendListLabel.TabIndex = 10;
            this.FriendListLabel.Text = "Friend list from file: ";
            // 
            // FileIOBreshears
            // 
            this.AcceptButton = this.writeNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(385, 276);
            this.Controls.Add(this.FriendListLabel);
            this.Controls.Add(this.FriendListTextBox);
            this.Controls.Add(this.ReadNameButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "FileIOBreshears";
            this.Text = "File IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button ReadNameButton;
        private System.Windows.Forms.TextBox FriendListTextBox;
        private System.Windows.Forms.Label FriendListLabel;
    }
}

