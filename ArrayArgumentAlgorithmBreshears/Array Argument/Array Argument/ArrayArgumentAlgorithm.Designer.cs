namespace Array_Argument
{
    partial class ArrayArgumentAlgorithm
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.findMaxButton = new System.Windows.Forms.Button();
            this.findMinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(43, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(188, 212);
            this.outputListBox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(55, 241);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "&Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(139, 278);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // findMaxButton
            // 
            this.findMaxButton.Location = new System.Drawing.Point(139, 241);
            this.findMaxButton.Name = "findMaxButton";
            this.findMaxButton.Size = new System.Drawing.Size(75, 23);
            this.findMaxButton.TabIndex = 3;
            this.findMaxButton.Text = "&Find Max";
            this.findMaxButton.UseVisualStyleBackColor = true;
            this.findMaxButton.Click += new System.EventHandler(this.findMaxButton_Click);
            // 
            // findMinButton
            // 
            this.findMinButton.Location = new System.Drawing.Point(55, 278);
            this.findMinButton.Name = "findMinButton";
            this.findMinButton.Size = new System.Drawing.Size(75, 23);
            this.findMinButton.TabIndex = 4;
            this.findMinButton.Text = "Find &Min";
            this.findMinButton.UseVisualStyleBackColor = true;
            this.findMinButton.Click += new System.EventHandler(this.findMinButton_Click);
            // 
            // ArrayArgumentAlgorithm
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(275, 343);
            this.Controls.Add(this.findMinButton);
            this.Controls.Add(this.findMaxButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "ArrayArgumentAlgorithm";
            this.Text = "Array Argument Algorithm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button findMaxButton;
        private System.Windows.Forms.Button findMinButton;
    }
}

