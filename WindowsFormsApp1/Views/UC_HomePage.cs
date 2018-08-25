using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shlok.BoilerPlateApp
{
    public partial class UC_HomePage : IUserControl
    {
        private static UC_HomePage _instance = new UC_HomePage();

        public override IUserControl Instance
        {
            get { return _instance; }
        }

        public UC_HomePage()
        {
            InitializeComponent();
        }
    }
}
