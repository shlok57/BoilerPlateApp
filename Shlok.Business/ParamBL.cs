using System.Collections.Generic;
using Shlok.DBProviders;
using Shlok.Models;

namespace Shlok.Business
{
	public class ParamBL
	{
		public int Function(int param)
		{
			int result = -1;
			try
			{
				result = DBProvider.Function(param);
			}
			catch { }

			return result;
		}

		public int StoreParamName(string paramName)
		{
			int result = -1;
			try
			{
				result = DBProvider.StoreParamName(paramName);
			}
			catch { }

			return result;
		}

		public List<ParamValue> GetLatestParamValuesById(int id)
		{
			List<ParamValue> result = new List<ParamValue>();
			try
			{
				result = DBProvider.GetParamValuesById(id);
			}
			catch { }

			return result;
		}

		public List<ParamValue> GetParamValuesHistoryById(int id)
		{
			List<ParamValue> result = new List<ParamValue>();
			try
			{
				result = DBProvider.GetParamValuesById(id, true);
			}
			catch { }

			return result;
		}

		public List<ParamValue> GetAllParamNames()
		{
			List<ParamValue> result = new List<ParamValue>();
			try
			{
				result = DBProvider.GetAllParamNames();
			}
			catch { }

			return result;
		}

		public List<ParamValue> GetActiveParamNames()
		{
			List<ParamValue> result = new List<ParamValue>();
			try
			{
				result = DBProvider.GetAllParamNames();
				if (result != null)
				{
					result = result.FindAll(x => x.IsActive == true);
				}
			}
			catch { }

			return result;
		}

	}
}
