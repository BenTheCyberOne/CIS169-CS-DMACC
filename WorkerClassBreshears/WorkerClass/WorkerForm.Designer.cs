namespace WorkerClass
{
    partial class WorkerForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.workerGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.payLabel = new System.Windows.Forms.Label();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.nightRadioButton = new System.Windows.Forms.RadioButton();
            this.workerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 245);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(89, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "&Create Worker";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Worker Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(98, 31);
            this.nameTextBox.MaxLength = 25;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // workerGroupBox
            // 
            this.workerGroupBox.Controls.Add(this.nightRadioButton);
            this.workerGroupBox.Controls.Add(this.dayRadioButton);
            this.workerGroupBox.Controls.Add(this.payLabel);
            this.workerGroupBox.Controls.Add(this.payTextBox);
            this.workerGroupBox.Controls.Add(this.numLabel);
            this.workerGroupBox.Controls.Add(this.numTextBox);
            this.workerGroupBox.Controls.Add(this.nameLabel);
            this.workerGroupBox.Controls.Add(this.nameTextBox);
            this.workerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.workerGroupBox.Name = "workerGroupBox";
            this.workerGroupBox.Size = new System.Drawing.Size(224, 208);
            this.workerGroupBox.TabIndex = 3;
            this.workerGroupBox.TabStop = false;
            this.workerGroupBox.Text = "Worker Form:";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(147, 245);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(4, 60);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(85, 13);
            this.numLabel.TabIndex = 3;
            this.numLabel.Text = "Worker Number:";
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(97, 57);
            this.numTextBox.MaxLength = 8;
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 20);
            this.numTextBox.TabIndex = 4;
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Location = new System.Drawing.Point(13, 157);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(54, 13);
            this.payLabel.TabIndex = 5;
            this.payLabel.Text = "Pay Rate:";
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(97, 154);
            this.payTextBox.MaxLength = 5;
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.Size = new System.Drawing.Size(100, 20);
            this.payTextBox.TabIndex = 6;
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Checked = true;
            this.dayRadioButton.Location = new System.Drawing.Point(22, 107);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(68, 17);
            this.dayRadioButton.TabIndex = 7;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "Day Shift";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            // 
            // nightRadioButton
            // 
            this.nightRadioButton.AutoSize = true;
            this.nightRadioButton.Location = new System.Drawing.Point(124, 107);
            this.nightRadioButton.Name = "nightRadioButton";
            this.nightRadioButton.Size = new System.Drawing.Size(74, 17);
            this.nightRadioButton.TabIndex = 8;
            this.nightRadioButton.Text = "Night Shift";
            this.nightRadioButton.UseVisualStyleBackColor = true;
            // 
            // WorkerForm
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(251, 289);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.workerGroupBox);
            this.Controls.Add(this.createButton);
            this.Name = "WorkerForm";
            this.Text = "Employee Form";
            this.workerGroupBox.ResumeLayout(false);
            this.workerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox workerGroupBox;
        private System.Windows.Forms.RadioButton nightRadioButton;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.TextBox payTextBox;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}

