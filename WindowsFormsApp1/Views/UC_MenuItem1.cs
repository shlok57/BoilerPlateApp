using System;
using Shlok.Business;

namespace Shlok.BoilerPlateApp
{
	public partial class UC_MenuItem1 : CustomUserControl
	{
		#region private variables

		private static UC_MenuItem1 _instance = new UC_MenuItem1();
		private ParamBL paramBL = null;

		#endregion

		#region public functions

		public override CustomUserControl Instance
		{
			get { return _instance; }
		}

		public UC_MenuItem1()
		{
			InitializeComponent();
			paramBL = new ParamBL();
		}

		#endregion

		#region private functions

		private void Btn_AddParamName_Click(object sender, EventArgs e)
		{
			txt_conf.Visible = true;
			string paramName = txt_paramName.Text;
			if (string.IsNullOrEmpty(paramName))
			{
				txt_conf.Text = "Enter Name";
			}
			else
			{
				txt_conf.Text = paramBL.StoreParamName(paramName) != -1 ? "Parameter Name Saved" : "Some Error Happened";
			}

			return;
		}

		private void Txt_paramName_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txt_paramName.Text))
			{
				btn_AddParamName.Enabled = false;
			}
			else
			{
				btn_AddParamName.Enabled = true;
			}

			txt_conf.Visible = false;
		}

		#endregion
	}
}
