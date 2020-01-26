namespace ArithmeticOperationsBreshears
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
            this.AdditionLabel = new System.Windows.Forms.Label();
            this.SubtractionLabel = new System.Windows.Forms.Label();
            this.MultiplyLabel = new System.Windows.Forms.Label();
            this.DivisionLabel = new System.Windows.Forms.Label();
            this.ModulusLabel = new System.Windows.Forms.Label();
            this.PositiveILabel = new System.Windows.Forms.Label();
            this.NegativeILabel = new System.Windows.Forms.Label();
            this.AdditionBox = new System.Windows.Forms.TextBox();
            this.SubtractionBox = new System.Windows.Forms.TextBox();
            this.MultiplyBox = new System.Windows.Forms.TextBox();
            this.DivisionBox = new System.Windows.Forms.TextBox();
            this.ModulusBox = new System.Windows.Forms.TextBox();
            this.PositiveIBox = new System.Windows.Forms.TextBox();
            this.NegativeIBox = new System.Windows.Forms.TextBox();
            this.ShowOperationsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdditionLabel
            // 
            this.AdditionLabel.AutoSize = true;
            this.AdditionLabel.Location = new System.Drawing.Point(97, 59);
            this.AdditionLabel.Name = "AdditionLabel";
            this.AdditionLabel.Size = new System.Drawing.Size(45, 13);
            this.AdditionLabel.TabIndex = 0;
            this.AdditionLabel.Text = "Addition";
            this.AdditionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubtractionLabel
            // 
            this.SubtractionLabel.AutoSize = true;
            this.SubtractionLabel.Location = new System.Drawing.Point(97, 93);
            this.SubtractionLabel.Name = "SubtractionLabel";
            this.SubtractionLabel.Size = new System.Drawing.Size(61, 13);
            this.SubtractionLabel.TabIndex = 1;
            this.SubtractionLabel.Text = "Subtraction";
            // 
            // MultiplyLabel
            // 
            this.MultiplyLabel.AutoSize = true;
            this.MultiplyLabel.Location = new System.Drawing.Point(97, 132);
            this.MultiplyLabel.Name = "MultiplyLabel";
            this.MultiplyLabel.Size = new System.Drawing.Size(68, 13);
            this.MultiplyLabel.TabIndex = 2;
            this.MultiplyLabel.Text = "Multiplication";
            // 
            // DivisionLabel
            // 
            this.DivisionLabel.AutoSize = true;
            this.DivisionLabel.Location = new System.Drawing.Point(97, 180);
            this.DivisionLabel.Name = "DivisionLabel";
            this.DivisionLabel.Size = new System.Drawing.Size(44, 13);
            this.DivisionLabel.TabIndex = 3;
            this.DivisionLabel.Text = "Division";
            // 
            // ModulusLabel
            // 
            this.ModulusLabel.AutoSize = true;
            this.ModulusLabel.Location = new System.Drawing.Point(97, 223);
            this.ModulusLabel.Name = "ModulusLabel";
            this.ModulusLabel.Size = new System.Drawing.Size(47, 13);
            this.ModulusLabel.TabIndex = 4;
            this.ModulusLabel.Text = "Modulus";
            this.ModulusLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // PositiveILabel
            // 
            this.PositiveILabel.AutoSize = true;
            this.PositiveILabel.Location = new System.Drawing.Point(97, 264);
            this.PositiveILabel.Name = "PositiveILabel";
            this.PositiveILabel.Size = new System.Drawing.Size(94, 13);
            this.PositiveILabel.TabIndex = 5;
            this.PositiveILabel.Text = "Positive Increment";
            // 
            // NegativeILabel
            // 
            this.NegativeILabel.AutoSize = true;
            this.NegativeILabel.Location = new System.Drawing.Point(97, 302);
            this.NegativeILabel.Name = "NegativeILabel";
            this.NegativeILabel.Size = new System.Drawing.Size(100, 13);
            this.NegativeILabel.TabIndex = 6;
            this.NegativeILabel.Text = "Negative Increment";
            // 
            // AdditionBox
            // 
            this.AdditionBox.Location = new System.Drawing.Point(224, 52);
            this.AdditionBox.Name = "AdditionBox";
            this.AdditionBox.Size = new System.Drawing.Size(100, 20);
            this.AdditionBox.TabIndex = 7;
            // 
            // SubtractionBox
            // 
            this.SubtractionBox.Location = new System.Drawing.Point(224, 86);
            this.SubtractionBox.Name = "SubtractionBox";
            this.SubtractionBox.Size = new System.Drawing.Size(100, 20);
            this.SubtractionBox.TabIndex = 8;
            // 
            // MultiplyBox
            // 
            this.MultiplyBox.Location = new System.Drawing.Point(224, 125);
            this.MultiplyBox.Name = "MultiplyBox";
            this.MultiplyBox.Size = new System.Drawing.Size(100, 20);
            this.MultiplyBox.TabIndex = 9;
            this.MultiplyBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // DivisionBox
            // 
            this.DivisionBox.Location = new System.Drawing.Point(224, 173);
            this.DivisionBox.Name = "DivisionBox";
            this.DivisionBox.Size = new System.Drawing.Size(100, 20);
            this.DivisionBox.TabIndex = 10;
            // 
            // ModulusBox
            // 
            this.ModulusBox.Location = new System.Drawing.Point(224, 216);
            this.ModulusBox.Name = "ModulusBox";
            this.ModulusBox.Size = new System.Drawing.Size(100, 20);
            this.ModulusBox.TabIndex = 11;
            // 
            // PositiveIBox
            // 
            this.PositiveIBox.Location = new System.Drawing.Point(224, 257);
            this.PositiveIBox.Name = "PositiveIBox";
            this.PositiveIBox.Size = new System.Drawing.Size(100, 20);
            this.PositiveIBox.TabIndex = 12;
            // 
            // NegativeIBox
            // 
            this.NegativeIBox.Location = new System.Drawing.Point(224, 295);
            this.NegativeIBox.Name = "NegativeIBox";
            this.NegativeIBox.Size = new System.Drawing.Size(100, 20);
            this.NegativeIBox.TabIndex = 13;
            // 
            // ShowOperationsButton
            // 
            this.ShowOperationsButton.Location = new System.Drawing.Point(394, 132);
            this.ShowOperationsButton.Name = "ShowOperationsButton";
            this.ShowOperationsButton.Size = new System.Drawing.Size(100, 23);
            this.ShowOperationsButton.TabIndex = 14;
            this.ShowOperationsButton.Text = "Show &Operations";
            this.ShowOperationsButton.UseVisualStyleBackColor = true;
            this.ShowOperationsButton.Click += new System.EventHandler(this.ShowOperationsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(394, 198);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 23);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 387);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowOperationsButton);
            this.Controls.Add(this.NegativeIBox);
            this.Controls.Add(this.PositiveIBox);
            this.Controls.Add(this.ModulusBox);
            this.Controls.Add(this.DivisionBox);
            this.Controls.Add(this.MultiplyBox);
            this.Controls.Add(this.SubtractionBox);
            this.Controls.Add(this.AdditionBox);
            this.Controls.Add(this.NegativeILabel);
            this.Controls.Add(this.PositiveILabel);
            this.Controls.Add(this.ModulusLabel);
            this.Controls.Add(this.DivisionLabel);
            this.Controls.Add(this.MultiplyLabel);
            this.Controls.Add(this.SubtractionLabel);
            this.Controls.Add(this.AdditionLabel);
            this.Name = "MainForm";
            this.Text = "Arithmetic Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdditionLabel;
        private System.Windows.Forms.Label SubtractionLabel;
        private System.Windows.Forms.Label MultiplyLabel;
        private System.Windows.Forms.Label DivisionLabel;
        private System.Windows.Forms.Label ModulusLabel;
        private System.Windows.Forms.Label PositiveILabel;
        private System.Windows.Forms.Label NegativeILabel;
        private System.Windows.Forms.TextBox AdditionBox;
        private System.Windows.Forms.TextBox SubtractionBox;
        private System.Windows.Forms.TextBox MultiplyBox;
        private System.Windows.Forms.TextBox DivisionBox;
        private System.Windows.Forms.TextBox ModulusBox;
        private System.Windows.Forms.TextBox PositiveIBox;
        private System.Windows.Forms.TextBox NegativeIBox;
        private System.Windows.Forms.Button ShowOperationsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

