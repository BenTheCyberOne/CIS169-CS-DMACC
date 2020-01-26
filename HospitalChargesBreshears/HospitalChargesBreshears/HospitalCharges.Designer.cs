namespace HospitalChargesBreshears
{
    partial class HospitalCharges
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
            this.rehabLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.rehabTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.labTextBox = new System.Windows.Forms.TextBox();
            this.surgTextBox = new System.Windows.Forms.TextBox();
            this.medTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.labLabel = new System.Windows.Forms.Label();
            this.surgicalLabel = new System.Windows.Forms.Label();
            this.medicationLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rehabLabel
            // 
            this.rehabLabel.AutoSize = true;
            this.rehabLabel.Location = new System.Drawing.Point(16, 160);
            this.rehabLabel.Name = "rehabLabel";
            this.rehabLabel.Size = new System.Drawing.Size(84, 13);
            this.rehabLabel.TabIndex = 0;
            this.rehabLabel.Text = "Physical Rehab:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(55, 266);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // rehabTextBox
            // 
            this.rehabTextBox.Location = new System.Drawing.Point(125, 157);
            this.rehabTextBox.Name = "rehabTextBox";
            this.rehabTextBox.Size = new System.Drawing.Size(100, 20);
            this.rehabTextBox.TabIndex = 2;
            this.rehabTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(this.totalLabel);
            this.groupBox1.Controls.Add(this.labTextBox);
            this.groupBox1.Controls.Add(this.rehabTextBox);
            this.groupBox1.Controls.Add(this.rehabLabel);
            this.groupBox1.Controls.Add(this.surgTextBox);
            this.groupBox1.Controls.Add(this.medTextBox);
            this.groupBox1.Controls.Add(this.daysTextBox);
            this.groupBox1.Controls.Add(this.labLabel);
            this.groupBox1.Controls.Add(this.surgicalLabel);
            this.groupBox1.Controls.Add(this.medicationLabel);
            this.groupBox1.Controls.Add(this.daysLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 229);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hospital Charges:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(125, 203);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 10;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(46, 206);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(50, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total Bill:";
            // 
            // labTextBox
            // 
            this.labTextBox.Location = new System.Drawing.Point(125, 131);
            this.labTextBox.Name = "labTextBox";
            this.labTextBox.Size = new System.Drawing.Size(100, 20);
            this.labTextBox.TabIndex = 8;
            // 
            // surgTextBox
            // 
            this.surgTextBox.Location = new System.Drawing.Point(125, 105);
            this.surgTextBox.Name = "surgTextBox";
            this.surgTextBox.Size = new System.Drawing.Size(100, 20);
            this.surgTextBox.TabIndex = 7;
            // 
            // medTextBox
            // 
            this.medTextBox.Location = new System.Drawing.Point(125, 79);
            this.medTextBox.Name = "medTextBox";
            this.medTextBox.Size = new System.Drawing.Size(100, 20);
            this.medTextBox.TabIndex = 6;
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(125, 53);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 5;
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(46, 134);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(54, 13);
            this.labLabel.TabIndex = 4;
            this.labLabel.Text = "Lab Fees:";
            // 
            // surgicalLabel
            // 
            this.surgicalLabel.AutoSize = true;
            this.surgicalLabel.Location = new System.Drawing.Point(52, 108);
            this.surgicalLabel.Name = "surgicalLabel";
            this.surgicalLabel.Size = new System.Drawing.Size(48, 13);
            this.surgicalLabel.TabIndex = 3;
            this.surgicalLabel.Text = "Surgical:";
            // 
            // medicationLabel
            // 
            this.medicationLabel.AutoSize = true;
            this.medicationLabel.Location = new System.Drawing.Point(38, 86);
            this.medicationLabel.Name = "medicationLabel";
            this.medicationLabel.Size = new System.Drawing.Size(62, 13);
            this.medicationLabel.TabIndex = 2;
            this.medicationLabel.Text = "Medication:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(41, 60);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(61, 13);
            this.daysLabel.TabIndex = 1;
            this.daysLabel.Text = "Total Days:";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(162, 266);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // HospitalCharges
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(287, 327);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculateButton);
            this.Name = "HospitalCharges";
            this.Text = "Hospital Charges Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label rehabLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox rehabTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox labTextBox;
        private System.Windows.Forms.TextBox surgTextBox;
        private System.Windows.Forms.TextBox medTextBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Label labLabel;
        private System.Windows.Forms.Label surgicalLabel;
        private System.Windows.Forms.Label medicationLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

