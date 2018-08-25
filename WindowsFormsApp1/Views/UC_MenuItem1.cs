using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shlok.DBProviders;

namespace Shlok.BoilerPlateApp
{
    public partial class UC_MenuItem1 : IUserControl
    {
        private static UC_MenuItem1 _instance = new UC_MenuItem1();

        public override IUserControl Instance
        {
            get { return _instance; }
        }

        public UC_MenuItem1()
        {
            InitializeComponent();
        }

		private void btn_AddParamName_Click(object sender, EventArgs e)
		{
			DBProvider.Function(2);
		}
	}
}
