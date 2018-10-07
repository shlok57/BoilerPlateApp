using System;
using System.Windows.Forms;

namespace Shlok.BoilerPlateApp
{
	public partial class HomePage : Form
	{
		#region private variables

		#endregion

		#region private functions

		private void LoadUserControl(CustomUserControl instance)
		{
			if (!panel4.Controls.Contains(instance))
			{
				panel4.Controls.Add(instance);
				instance.Dock = DockStyle.Fill;
			}
			instance.Load();
			instance.BringToFront();
		}

		private void btn_home_Click(object sender, EventArgs e)
		{
			LoadHomePage();
			sidePanel.Height = btn_home.Height;
			sidePanel.Top = btn_home.Top;
		}

		private void btn_menu1_Click(object sender, EventArgs e)
		{
			sidePanel.Height = btn_menu1.Height;
			sidePanel.Top = btn_menu1.Top;
			CustomUserControl uc = new UC_MenuItem1();
			LoadUserControl(uc.Instance);
		}

		private void btn_menu2_Click(object sender, EventArgs e)
		{
			sidePanel.Height = btn_menu2.Height;
			sidePanel.Top = btn_menu2.Top;
			CustomUserControl uc = new UC_MenuItem2();
			LoadUserControl(uc.Instance);
		}

		private void btn_menu3_Click(object sender, EventArgs e)
		{
			sidePanel.Height = btn_menu3.Height;
			sidePanel.Top = btn_menu3.Top;
			CustomUserControl uc = new UC_MenuItem3();
			LoadUserControl(uc.Instance);
		}

		private void LoadHomePage()
		{
			sidePanel.Height = btn_home.Height;
			CustomUserControl uc = new UC_HomePage();
			LoadUserControl(uc.Instance);
		}
		#endregion

		#region public functions

		public HomePage()
		{
			InitializeComponent();
			LoadHomePage();
		}

		#endregion
	}
}
