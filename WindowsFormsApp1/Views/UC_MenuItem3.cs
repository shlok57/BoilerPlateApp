﻿using System;
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
    public partial class UC_MenuItem3 : CustomUserControl
    {
        private static UC_MenuItem3 _instance = new UC_MenuItem3();

        public override CustomUserControl Instance
        {
            get { return _instance; }
        }

        public UC_MenuItem3()
        {
            InitializeComponent();
        }
    }
}
