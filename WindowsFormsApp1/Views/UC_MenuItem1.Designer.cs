namespace Shlok.BoilerPlateApp
{
    partial class UC_MenuItem1
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_paramName = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_AddParamName = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(352, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "MenuItem1 Selected";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(241, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Parameter Name Here:";
			// 
			// txt_paramName
			// 
			this.txt_paramName.BackColor = System.Drawing.Color.White;
			this.txt_paramName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_paramName.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_paramName.Location = new System.Drawing.Point(299, 88);
			this.txt_paramName.Name = "txt_paramName";
			this.txt_paramName.Size = new System.Drawing.Size(251, 25);
			this.txt_paramName.TabIndex = 2;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// btn_AddParamName
			// 
			this.btn_AddParamName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.btn_AddParamName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_AddParamName.Location = new System.Drawing.Point(299, 135);
			this.btn_AddParamName.Name = "btn_AddParamName";
			this.btn_AddParamName.Size = new System.Drawing.Size(251, 23);
			this.btn_AddParamName.TabIndex = 4;
			this.btn_AddParamName.Text = "Add Parameter";
			this.btn_AddParamName.UseVisualStyleBackColor = false;
			this.btn_AddParamName.Click += new System.EventHandler(this.btn_AddParamName_Click);
			// 
			// UC_MenuItem1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.Controls.Add(this.btn_AddParamName);
			this.Controls.Add(this.txt_paramName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UC_MenuItem1";
			this.Size = new System.Drawing.Size(807, 453);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_paramName;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btn_AddParamName;
	}
}
