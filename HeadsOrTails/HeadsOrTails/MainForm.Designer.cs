namespace HeadsOrTails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShowHeadsButton = new System.Windows.Forms.Button();
            this.ShowTailsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TailsPictureBox = new System.Windows.Forms.PictureBox();
            this.HeadsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowHeadsButton
            // 
            this.ShowHeadsButton.Location = new System.Drawing.Point(76, 251);
            this.ShowHeadsButton.Name = "ShowHeadsButton";
            this.ShowHeadsButton.Size = new System.Drawing.Size(79, 23);
            this.ShowHeadsButton.TabIndex = 0;
            this.ShowHeadsButton.Text = "Show &Heads";
            this.ShowHeadsButton.UseVisualStyleBackColor = true;
            this.ShowHeadsButton.Click += new System.EventHandler(this.ShowHeadsButton_Click);
            // 
            // ShowTailsButton
            // 
            this.ShowTailsButton.Location = new System.Drawing.Point(299, 251);
            this.ShowTailsButton.Name = "ShowTailsButton";
            this.ShowTailsButton.Size = new System.Drawing.Size(75, 23);
            this.ShowTailsButton.TabIndex = 1;
            this.ShowTailsButton.Text = "Show &Tails";
            this.ShowTailsButton.UseVisualStyleBackColor = true;
            this.ShowTailsButton.Click += new System.EventHandler(this.ShowTailsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(384, 308);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TailsPictureBox
            // 
            this.TailsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TailsPictureBox.Image")));
            this.TailsPictureBox.Location = new System.Drawing.Point(247, 63);
            this.TailsPictureBox.Name = "TailsPictureBox";
            this.TailsPictureBox.Size = new System.Drawing.Size(179, 158);
            this.TailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TailsPictureBox.TabIndex = 3;
            this.TailsPictureBox.TabStop = false;
            this.TailsPictureBox.Visible = false;
            // 
            // HeadsPictureBox
            // 
            this.HeadsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("HeadsPictureBox.Image")));
            this.HeadsPictureBox.Location = new System.Drawing.Point(28, 63);
            this.HeadsPictureBox.Name = "HeadsPictureBox";
            this.HeadsPictureBox.Size = new System.Drawing.Size(179, 158);
            this.HeadsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeadsPictureBox.TabIndex = 4;
            this.HeadsPictureBox.TabStop = false;
            this.HeadsPictureBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 343);
            this.Controls.Add(this.HeadsPictureBox);
            this.Controls.Add(this.TailsPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowTailsButton);
            this.Controls.Add(this.ShowHeadsButton);
            this.Name = "MainForm";
            this.Text = "Heads Or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.TailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowHeadsButton;
        private System.Windows.Forms.Button ShowTailsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox TailsPictureBox;
        private System.Windows.Forms.PictureBox HeadsPictureBox;
    }
}

