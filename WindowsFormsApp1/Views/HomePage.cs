using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shlok.DBProviders;

namespace Shlok.BoilerPlateApp
{
    public partial class HomePage : Form
    {
        #region private variables
        
        #endregion

        #region private functions

        private void LoadUserControl(IUserControl instance)
        {
            if (!panel4.Controls.Contains(instance))
            {
                panel4.Controls.Add(instance);
				instance.Dock = DockStyle.Fill;
			}
         
            instance.BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
			LoadHomePage();
        }

        private void btn_menu1_Click(object sender, EventArgs e)
        {
            IUserControl uc = new UC_MenuItem1();
            LoadUserControl(uc.Instance);
        }

        private void btn_menu2_Click(object sender, EventArgs e)
        {
			IUserControl uc = new UC_MenuItem2();
			LoadUserControl(uc.Instance);
		}

        private void btn_menu3_Click(object sender, EventArgs e)
        {
			IUserControl uc = new UC_MenuItem3();
			LoadUserControl(uc.Instance);
		}

		private void LoadHomePage()
		{
			IUserControl uc = new UC_HomePage();
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
