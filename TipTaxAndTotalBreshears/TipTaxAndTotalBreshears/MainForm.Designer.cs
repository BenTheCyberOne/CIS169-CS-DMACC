namespace TipTaxAndTotalBreshears
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.StartPriceLabel = new System.Windows.Forms.Label();
            this.StartPriceBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TipLabel = new System.Windows.Forms.Label();
            this.TipCalculateLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxCalculateLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalCalculateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(47, 218);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // StartPriceLabel
            // 
            this.StartPriceLabel.AutoSize = true;
            this.StartPriceLabel.Location = new System.Drawing.Point(44, 58);
            this.StartPriceLabel.Name = "StartPriceLabel";
            this.StartPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.StartPriceLabel.TabIndex = 1;
            this.StartPriceLabel.Text = "Price of bill:";
            // 
            // StartPriceBox
            // 
            this.StartPriceBox.Location = new System.Drawing.Point(162, 51);
            this.StartPriceBox.Name = "StartPriceBox";
            this.StartPriceBox.Size = new System.Drawing.Size(100, 20);
            this.StartPriceBox.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(162, 218);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(44, 103);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(48, 13);
            this.TipLabel.TabIndex = 4;
            this.TipLabel.Text = "15% Tip:";
            // 
            // TipCalculateLabel
            // 
            this.TipCalculateLabel.AutoSize = true;
            this.TipCalculateLabel.Location = new System.Drawing.Point(159, 103);
            this.TipCalculateLabel.Name = "TipCalculateLabel";
            this.TipCalculateLabel.Size = new System.Drawing.Size(0, 13);
            this.TipCalculateLabel.TabIndex = 5;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(44, 150);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(45, 13);
            this.TaxLabel.TabIndex = 6;
            this.TaxLabel.Text = "7% Tax:";
            // 
            // TaxCalculateLabel
            // 
            this.TaxCalculateLabel.AutoSize = true;
            this.TaxCalculateLabel.Location = new System.Drawing.Point(159, 150);
            this.TaxCalculateLabel.Name = "TaxCalculateLabel";
            this.TaxCalculateLabel.Size = new System.Drawing.Size(0, 13);
            this.TaxCalculateLabel.TabIndex = 7;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(44, 187);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(61, 13);
            this.TotalLabel.TabIndex = 8;
            this.TotalLabel.Text = "Total Price:";
            // 
            // TotalCalculateLabel
            // 
            this.TotalCalculateLabel.AutoSize = true;
            this.TotalCalculateLabel.Location = new System.Drawing.Point(159, 187);
            this.TotalCalculateLabel.Name = "TotalCalculateLabel";
            this.TotalCalculateLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalCalculateLabel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(328, 289);
            this.Controls.Add(this.TotalCalculateLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxCalculateLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.TipCalculateLabel);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartPriceBox);
            this.Controls.Add(this.StartPriceLabel);
            this.Controls.Add(this.CalculateButton);
            this.Name = "MainForm";
            this.Text = "Tip, Tax, and Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label StartPriceLabel;
        private System.Windows.Forms.TextBox StartPriceBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label TipCalculateLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TaxCalculateLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalCalculateLabel;
    }
}

