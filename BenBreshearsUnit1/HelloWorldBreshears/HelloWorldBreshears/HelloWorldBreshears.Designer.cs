namespace HelloWorldBreshears
{
	partial class mainForm
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
            this.displayMessage = new System.Windows.Forms.Button();
            this.exitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayMessage
            // 
            this.displayMessage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.displayMessage.Location = new System.Drawing.Point(96, 64);
            this.displayMessage.Name = "displayMessage";
            this.displayMessage.Size = new System.Drawing.Size(147, 56);
            this.displayMessage.TabIndex = 0;
            this.displayMessage.Text = "&Display Message";
            this.displayMessage.UseVisualStyleBackColor = true;
            this.displayMessage.Click += new System.EventHandler(this.displayMessage_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitProgram.Location = new System.Drawing.Point(253, 160);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(85, 31);
            this.exitProgram.TabIndex = 1;
            this.exitProgram.Text = "&Exit";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.displayMessage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitProgram;
            this.ClientSize = new System.Drawing.Size(350, 203);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.displayMessage);
            this.Name = "mainForm";
            this.Text = "Hello World!";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button displayMessage;
		private System.Windows.Forms.Button exitProgram;
	}
}

