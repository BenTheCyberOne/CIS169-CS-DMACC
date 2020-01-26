namespace PictureFrameBreshears
{
    partial class PictureFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureFrame));
            this.photoList = new System.Windows.Forms.ImageList(this.components);
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.clickLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // photoList
            // 
            this.photoList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("photoList.ImageStream")));
            this.photoList.TransparentColor = System.Drawing.Color.Transparent;
            this.photoList.Images.SetKeyName(0, "download.gif.jpg");
            this.photoList.Images.SetKeyName(1, "R-435357-1250385857.png.jpg");
            this.photoList.Images.SetKeyName(2, "rush___moving_pictures_by_kennethac-d3aajs0.jpg");
            this.photoList.Images.SetKeyName(3, "the-beatles-abbey-road-album-cover-wallpaper-4.jpg");
            this.photoList.Images.SetKeyName(4, "1B3FBB12-894C-4DE3-B3EA-5925D772E01B.jpg");
            this.photoList.Images.SetKeyName(5, "images.jpg");
            // 
            // photoBox
            // 
            this.photoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoBox.Image = global::PictureFrameBreshears.Properties.Resources.images;
            this.photoBox.Location = new System.Drawing.Point(52, 51);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(256, 256);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoBox.TabIndex = 0;
            this.photoBox.TabStop = false;
            this.photoBox.Click += new System.EventHandler(this.photoBox_Click);
            // 
            // clickLabel
            // 
            this.clickLabel.AutoSize = true;
            this.clickLabel.Location = new System.Drawing.Point(103, 25);
            this.clickLabel.Name = "clickLabel";
            this.clickLabel.Size = new System.Drawing.Size(141, 13);
            this.clickLabel.TabIndex = 1;
            this.clickLabel.Text = "Click the image to change it.";
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(144, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PictureFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(374, 374);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clickLabel);
            this.Controls.Add(this.photoBox);
            this.Name = "PictureFrame";
            this.Text = "Picture Frame";
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList photoList;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Label clickLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

