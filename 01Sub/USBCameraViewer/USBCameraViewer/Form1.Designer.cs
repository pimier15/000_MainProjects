﻿namespace USBCameraViewer
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnconnet = new System.Windows.Forms.Button();
			this.btnlose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(44, 51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(480, 500);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnconnet
			// 
			this.btnconnet.Location = new System.Drawing.Point(663, 12);
			this.btnconnet.Name = "btnconnet";
			this.btnconnet.Size = new System.Drawing.Size(75, 23);
			this.btnconnet.TabIndex = 1;
			this.btnconnet.Text = "connect";
			this.btnconnet.UseVisualStyleBackColor = true;
			this.btnconnet.Click += new System.EventHandler(this.btnconnet_Click);
			// 
			// btnlose
			// 
			this.btnlose.Location = new System.Drawing.Point(663, 51);
			this.btnlose.Name = "btnlose";
			this.btnlose.Size = new System.Drawing.Size(75, 23);
			this.btnlose.TabIndex = 2;
			this.btnlose.Text = "close";
			this.btnlose.UseVisualStyleBackColor = true;
			this.btnlose.Click += new System.EventHandler(this.btnlose_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(793, 669);
			this.Controls.Add(this.btnlose);
			this.Controls.Add(this.btnconnet);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnconnet;
		private System.Windows.Forms.Button btnlose;
	}
}

