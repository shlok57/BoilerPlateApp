using System.Collections.Generic;
using System.Windows.Forms;
using Shlok.Business;
using Shlok.Models;

namespace Shlok.BoilerPlateApp
{
	public partial class UC_MenuItem2 : CustomUserControl
	{
		private static UC_MenuItem2 _instance = new UC_MenuItem2();
		private ParamBL paramBL = null;

		public override CustomUserControl Instance
		{
			get { return _instance; }
		}

		public UC_MenuItem2()
		{
			InitializeComponent();
			paramBL = new ParamBL();
			LoadListView();
		}

		private void LoadListView()
		{
			paramsListView.View = View.Details;
			paramsListView.Columns.Add("ParamId", 40, HorizontalAlignment.Right);
			paramsListView.Columns.Add("ParamName", 80, HorizontalAlignment.Left);
		}

		public override void Load()
		{
			LoadData();
		}

		private void LoadData()
		{
			paramsListView.Items.Clear();
			List<ParamValue> paramValues = paramBL.GetActiveParamNames();
			foreach (ParamValue p in paramValues)
			{
				string[] row = new string[] { p.Id.ToString(), p.Name };
				ListViewItem lvi = new ListViewItem(row);
				lvi.Tag = p;
				paramsListView.Items.Add(lvi);
			}
		}
	}
}
