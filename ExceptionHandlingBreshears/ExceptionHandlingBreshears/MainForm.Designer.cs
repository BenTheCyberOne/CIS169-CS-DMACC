namespace ExceptionHandlingBreshears
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
            this.OriginalLabel = new System.Windows.Forms.Label();
            this.OriginalBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.FinalLabel = new System.Windows.Forms.Label();
            this.DiscountBox = new System.Windows.Forms.TextBox();
            this.FinalBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginalLabel
            // 
            this.OriginalLabel.AutoSize = true;
            this.OriginalLabel.Location = new System.Drawing.Point(35, 28);
            this.OriginalLabel.Name = "OriginalLabel";
            this.OriginalLabel.Size = new System.Drawing.Size(144, 13);
            this.OriginalLabel.TabIndex = 0;
            this.OriginalLabel.Text = "Enter the item\'s original price:";
            // 
            // OriginalBox
            // 
            this.OriginalBox.Location = new System.Drawing.Point(196, 25);
            this.OriginalBox.Name = "OriginalBox";
            this.OriginalBox.Size = new System.Drawing.Size(100, 20);
            this.OriginalBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(50, 219);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(84, 40);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "&Calculate Sale Price";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(35, 97);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(153, 13);
            this.DiscountLabel.TabIndex = 3;
            this.DiscountLabel.Text = "Enter the discount percentage:";
            // 
            // FinalLabel
            // 
            this.FinalLabel.AutoSize = true;
            this.FinalLabel.Location = new System.Drawing.Point(35, 148);
            this.FinalLabel.Name = "FinalLabel";
            this.FinalLabel.Size = new System.Drawing.Size(57, 13);
            this.FinalLabel.TabIndex = 4;
            this.FinalLabel.Text = "Sale price:";
            // 
            // DiscountBox
            // 
            this.DiscountBox.Location = new System.Drawing.Point(196, 94);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountBox.TabIndex = 5;
            // 
            // FinalBox
            // 
            this.FinalBox.Location = new System.Drawing.Point(196, 145);
            this.FinalBox.Name = "FinalBox";
            this.FinalBox.Size = new System.Drawing.Size(100, 20);
            this.FinalBox.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(196, 219);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(79, 40);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 284);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FinalBox);
            this.Controls.Add(this.DiscountBox);
            this.Controls.Add(this.FinalLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.OriginalBox);
            this.Controls.Add(this.OriginalLabel);
            this.Name = "MainForm";
            this.Text = "Sale Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OriginalLabel;
        private System.Windows.Forms.TextBox OriginalBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label FinalLabel;
        private System.Windows.Forms.TextBox DiscountBox;
        private System.Windows.Forms.TextBox FinalBox;
        private System.Windows.Forms.Button ExitButton;
    }
}

