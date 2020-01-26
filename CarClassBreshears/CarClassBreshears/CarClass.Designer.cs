namespace CarClassBreshears
{
    partial class CarClass
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
            this.breakButton = new System.Windows.Forms.Button();
            this.setMakeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.setMakeAndYearButton = new System.Windows.Forms.Button();
            this.mkLabel = new System.Windows.Forms.Label();
            this.yrLabel = new System.Windows.Forms.Label();
            this.spdLabel = new System.Windows.Forms.Label();
            this.setYearLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.currentSpeedLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // breakButton
            // 
            this.breakButton.Location = new System.Drawing.Point(20, 237);
            this.breakButton.Name = "breakButton";
            this.breakButton.Size = new System.Drawing.Size(75, 23);
            this.breakButton.TabIndex = 0;
            this.breakButton.Text = "&Break";
            this.breakButton.UseVisualStyleBackColor = true;
            this.breakButton.Click += new System.EventHandler(this.breakButton_Click);
            // 
            // setMakeLabel
            // 
            this.setMakeLabel.AutoSize = true;
            this.setMakeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setMakeLabel.Location = new System.Drawing.Point(265, 60);
            this.setMakeLabel.Name = "setMakeLabel";
            this.setMakeLabel.Size = new System.Drawing.Size(39, 15);
            this.setMakeLabel.TabIndex = 1;
            this.setMakeLabel.Text = "Make:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentSpeedLabel);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.makeLabel);
            this.groupBox1.Controls.Add(this.spdLabel);
            this.groupBox1.Controls.Add(this.yrLabel);
            this.groupBox1.Controls.Add(this.mkLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Car Details:";
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(143, 237);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(75, 23);
            this.accelerateButton.TabIndex = 3;
            this.accelerateButton.Text = "&Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // setMakeAndYearButton
            // 
            this.setMakeAndYearButton.Location = new System.Drawing.Point(265, 237);
            this.setMakeAndYearButton.Name = "setMakeAndYearButton";
            this.setMakeAndYearButton.Size = new System.Drawing.Size(132, 23);
            this.setMakeAndYearButton.TabIndex = 4;
            this.setMakeAndYearButton.Text = "&Set Make and Year";
            this.setMakeAndYearButton.UseVisualStyleBackColor = true;
            this.setMakeAndYearButton.Click += new System.EventHandler(this.setMakeAndYearButton_Click);
            // 
            // mkLabel
            // 
            this.mkLabel.AutoSize = true;
            this.mkLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkLabel.Location = new System.Drawing.Point(12, 31);
            this.mkLabel.Name = "mkLabel";
            this.mkLabel.Size = new System.Drawing.Size(39, 15);
            this.mkLabel.TabIndex = 5;
            this.mkLabel.Text = "Make:";
            // 
            // yrLabel
            // 
            this.yrLabel.AutoSize = true;
            this.yrLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yrLabel.Location = new System.Drawing.Point(12, 84);
            this.yrLabel.Name = "yrLabel";
            this.yrLabel.Size = new System.Drawing.Size(34, 15);
            this.yrLabel.TabIndex = 6;
            this.yrLabel.Text = "Year:";
            // 
            // spdLabel
            // 
            this.spdLabel.AutoSize = true;
            this.spdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spdLabel.Location = new System.Drawing.Point(12, 150);
            this.spdLabel.Name = "spdLabel";
            this.spdLabel.Size = new System.Drawing.Size(109, 15);
            this.spdLabel.TabIndex = 7;
            this.spdLabel.Text = "Current Speed (mph):";
            // 
            // setYearLabel
            // 
            this.setYearLabel.AutoSize = true;
            this.setYearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setYearLabel.Location = new System.Drawing.Point(265, 129);
            this.setYearLabel.Name = "setYearLabel";
            this.setYearLabel.Size = new System.Drawing.Size(34, 15);
            this.setYearLabel.TabIndex = 5;
            this.setYearLabel.Text = "Year:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(265, 78);
            this.makeTextBox.MaxLength = 20;
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(265, 147);
            this.yearTextBox.MaxLength = 4;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(143, 288);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeLabel.Location = new System.Drawing.Point(87, 31);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(41, 15);
            this.makeLabel.TabIndex = 8;
            this.makeLabel.Text = "Corolla";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearLabel.Location = new System.Drawing.Point(87, 84);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(33, 15);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "2013";
            // 
            // currentSpeedLabel
            // 
            this.currentSpeedLabel.AutoSize = true;
            this.currentSpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSpeedLabel.Location = new System.Drawing.Point(142, 150);
            this.currentSpeedLabel.Name = "currentSpeedLabel";
            this.currentSpeedLabel.Size = new System.Drawing.Size(15, 15);
            this.currentSpeedLabel.TabIndex = 10;
            this.currentSpeedLabel.Text = "0";
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(278, 12);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(61, 18);
            this.settingsLabel.TabIndex = 9;
            this.settingsLabel.Text = "Settings:";
            // 
            // CarClass
            // 
            this.AcceptButton = this.accelerateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(411, 337);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.setYearLabel);
            this.Controls.Add(this.setMakeAndYearButton);
            this.Controls.Add(this.accelerateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.setMakeLabel);
            this.Controls.Add(this.breakButton);
            this.Name = "CarClass";
            this.Text = "Car Class Challenge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button breakButton;
        private System.Windows.Forms.Label setMakeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentSpeedLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label spdLabel;
        private System.Windows.Forms.Label yrLabel;
        private System.Windows.Forms.Label mkLabel;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button setMakeAndYearButton;
        private System.Windows.Forms.Label setYearLabel;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label settingsLabel;
    }
}

