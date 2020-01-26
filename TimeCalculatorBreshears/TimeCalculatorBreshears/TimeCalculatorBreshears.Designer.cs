namespace TimeCalculatorBreshears
{
    partial class TimeCalculatorBreshears
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
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.enterSecondsLabel = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.daysCalcLabel = new System.Windows.Forms.Label();
            this.hoursCalcLabel = new System.Windows.Forms.Label();
            this.minutesCalcLabel = new System.Windows.Forms.Label();
            this.secondsCalcLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resultsGroupBox.Controls.Add(this.secondsCalcLabel);
            this.resultsGroupBox.Controls.Add(this.minutesCalcLabel);
            this.resultsGroupBox.Controls.Add(this.hoursCalcLabel);
            this.resultsGroupBox.Controls.Add(this.daysCalcLabel);
            this.resultsGroupBox.Controls.Add(this.secondsLabel);
            this.resultsGroupBox.Controls.Add(this.minutesLabel);
            this.resultsGroupBox.Controls.Add(this.hoursLabel);
            this.resultsGroupBox.Controls.Add(this.daysLabel);
            this.resultsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultsGroupBox.Location = new System.Drawing.Point(59, 63);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(200, 223);
            this.resultsGroupBox.TabIndex = 0;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(43, 303);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "C&alculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // enterSecondsLabel
            // 
            this.enterSecondsLabel.AutoSize = true;
            this.enterSecondsLabel.Location = new System.Drawing.Point(56, 34);
            this.enterSecondsLabel.Name = "enterSecondsLabel";
            this.enterSecondsLabel.Size = new System.Drawing.Size(80, 13);
            this.enterSecondsLabel.TabIndex = 1;
            this.enterSecondsLabel.Text = "Enter Seconds:";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(159, 31);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondsTextBox.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(124, 303);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(205, 303);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(6, 35);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(34, 13);
            this.daysLabel.TabIndex = 5;
            this.daysLabel.Text = "Days:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(6, 79);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(38, 13);
            this.hoursLabel.TabIndex = 6;
            this.hoursLabel.Text = "Hours:";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(6, 131);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(47, 13);
            this.minutesLabel.TabIndex = 7;
            this.minutesLabel.Text = "Minutes:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(6, 180);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(52, 13);
            this.secondsLabel.TabIndex = 8;
            this.secondsLabel.Text = "Seconds:";
            // 
            // daysCalcLabel
            // 
            this.daysCalcLabel.AutoSize = true;
            this.daysCalcLabel.Location = new System.Drawing.Point(143, 35);
            this.daysCalcLabel.Name = "daysCalcLabel";
            this.daysCalcLabel.Size = new System.Drawing.Size(0, 13);
            this.daysCalcLabel.TabIndex = 9;
            // 
            // hoursCalcLabel
            // 
            this.hoursCalcLabel.AutoSize = true;
            this.hoursCalcLabel.Location = new System.Drawing.Point(143, 79);
            this.hoursCalcLabel.Name = "hoursCalcLabel";
            this.hoursCalcLabel.Size = new System.Drawing.Size(0, 13);
            this.hoursCalcLabel.TabIndex = 10;
            // 
            // minutesCalcLabel
            // 
            this.minutesCalcLabel.AutoSize = true;
            this.minutesCalcLabel.Location = new System.Drawing.Point(143, 131);
            this.minutesCalcLabel.Name = "minutesCalcLabel";
            this.minutesCalcLabel.Size = new System.Drawing.Size(0, 13);
            this.minutesCalcLabel.TabIndex = 11;
            // 
            // secondsCalcLabel
            // 
            this.secondsCalcLabel.AutoSize = true;
            this.secondsCalcLabel.Location = new System.Drawing.Point(143, 180);
            this.secondsCalcLabel.Name = "secondsCalcLabel";
            this.secondsCalcLabel.Size = new System.Drawing.Size(0, 13);
            this.secondsCalcLabel.TabIndex = 12;
            // 
            // TimeCalculatorBreshears
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(328, 336);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.enterSecondsLabel);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.resultsGroupBox);
            this.Name = "TimeCalculatorBreshears";
            this.Text = "Time Calculator";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Label secondsCalcLabel;
        private System.Windows.Forms.Label minutesCalcLabel;
        private System.Windows.Forms.Label hoursCalcLabel;
        private System.Windows.Forms.Label daysCalcLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label enterSecondsLabel;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

