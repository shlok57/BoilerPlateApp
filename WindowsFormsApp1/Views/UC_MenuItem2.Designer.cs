﻿namespace Shlok.BoilerPlateApp
{
	partial class UC_MenuItem2
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.label1.Location = new System.Drawing.Point(187, 171);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(359, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "MenuItem2 Selected";
			// 
			// UC_MenuItem2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Name = "UC_MenuItem2";
			this.Size = new System.Drawing.Size(807, 453);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
	}
}