namespace Shlok.BoilerPlateApp
{
    partial class HomePage
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
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_menu2 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_menu3 = new System.Windows.Forms.Button();
			this.btn_menu1 = new System.Windows.Forms.Button();
			this.btn_home = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.btn_menu2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.btn_menu3);
			this.panel1.Controls.Add(this.btn_menu1);
			this.panel1.Controls.Add(this.btn_home);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(269, 594);
			this.panel1.TabIndex = 0;
			// 
			// btn_menu2
			// 
			this.btn_menu2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_menu2.FlatAppearance.BorderSize = 0;
			this.btn_menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_menu2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_menu2.ForeColor = System.Drawing.Color.White;
			this.btn_menu2.Image = global::Shlok.BoilerPlateApp.Properties.Resources.if_poo_56056;
			this.btn_menu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_menu2.Location = new System.Drawing.Point(12, 222);
			this.btn_menu2.Margin = new System.Windows.Forms.Padding(0);
			this.btn_menu2.Name = "btn_menu2";
			this.btn_menu2.Size = new System.Drawing.Size(257, 43);
			this.btn_menu2.TabIndex = 4;
			this.btn_menu2.Text = "MenuItem2";
			this.btn_menu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_menu2.UseVisualStyleBackColor = true;
			this.btn_menu2.Click += new System.EventHandler(this.btn_menu2_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel3.Location = new System.Drawing.Point(0, 104);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(12, 43);
			this.panel3.TabIndex = 2;
			// 
			// btn_menu3
			// 
			this.btn_menu3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_menu3.FlatAppearance.BorderSize = 0;
			this.btn_menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_menu3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_menu3.ForeColor = System.Drawing.Color.White;
			this.btn_menu3.Image = global::Shlok.BoilerPlateApp.Properties.Resources.if_poo_56056;
			this.btn_menu3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_menu3.Location = new System.Drawing.Point(9, 281);
			this.btn_menu3.Margin = new System.Windows.Forms.Padding(0);
			this.btn_menu3.Name = "btn_menu3";
			this.btn_menu3.Size = new System.Drawing.Size(257, 43);
			this.btn_menu3.TabIndex = 2;
			this.btn_menu3.Text = "MenuItem3";
			this.btn_menu3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_menu3.UseVisualStyleBackColor = true;
			this.btn_menu3.Click += new System.EventHandler(this.btn_menu3_Click);
			// 
			// btn_menu1
			// 
			this.btn_menu1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_menu1.FlatAppearance.BorderSize = 0;
			this.btn_menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_menu1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_menu1.ForeColor = System.Drawing.Color.White;
			this.btn_menu1.Image = global::Shlok.BoilerPlateApp.Properties.Resources.if_poo_56056;
			this.btn_menu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_menu1.Location = new System.Drawing.Point(12, 163);
			this.btn_menu1.Margin = new System.Windows.Forms.Padding(0);
			this.btn_menu1.Name = "btn_menu1";
			this.btn_menu1.Size = new System.Drawing.Size(257, 43);
			this.btn_menu1.TabIndex = 1;
			this.btn_menu1.Text = "MenuItem1";
			this.btn_menu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_menu1.UseVisualStyleBackColor = true;
			this.btn_menu1.Click += new System.EventHandler(this.btn_menu1_Click);
			// 
			// btn_home
			// 
			this.btn_home.FlatAppearance.BorderSize = 0;
			this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_home.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_home.ForeColor = System.Drawing.Color.White;
			this.btn_home.Image = global::Shlok.BoilerPlateApp.Properties.Resources.if_poo_56056;
			this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_home.Location = new System.Drawing.Point(12, 104);
			this.btn_home.Name = "btn_home";
			this.btn_home.Size = new System.Drawing.Size(257, 43);
			this.btn_home.TabIndex = 0;
			this.btn_home.Text = "Home";
			this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_home.UseVisualStyleBackColor = true;
			this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(269, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1057, 25);
			this.panel2.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(269, 23);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1057, 571);
			this.panel4.TabIndex = 2;
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1326, 594);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "HomePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_menu1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_menu2;
        private System.Windows.Forms.Button btn_menu3;
        private System.Windows.Forms.Panel panel4;
    }
}

