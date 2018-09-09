using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Shlok.Models;

namespace Shlok.DBProviders
{
	public class DBProvider
	{
		public static int Function(int param)
		{
			return param * param;
		}

		public static int StoreParamName(string paramName)
		{
			int newParamId = -1;
			ConnectionHelper connection = new ConnectionHelper();
			SqlCommand cmd = connection.GetSqlCommand();
			cmd.CommandText = DBResource.AddParam;
			cmd.Parameters.Add(@"paramName", System.Data.SqlDbType.VarChar).Value = paramName;

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					DataTable dataTable = new DataTable();
					dataTable.Load(reader);
					foreach (DataRow row in dataTable.Rows)
					{
						newParamId = (int)row[@"paramId"];
					}
				}
			}
			catch
			{
				newParamId = -1;
			}
			finally
			{
				connection.Close();
			}

			return newParamId;
		}

		public static List<ParamValue> GetParamValuesById(int id, bool showHistory = false)
		{
			List<ParamValue> values = new List<ParamValue>();
			ConnectionHelper connection = new ConnectionHelper();
			SqlCommand cmd = connection.GetSqlCommand();
			cmd.CommandText = DBResource.GetParamValueById;
			cmd.Parameters.Add(@"paramId", System.Data.SqlDbType.Int).Value = id;
			cmd.Parameters.Add(@"showHistory", System.Data.SqlDbType.Bit).Value = showHistory;

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					DataTable dataTable = new DataTable();
					dataTable.Load(reader);
					foreach (DataRow row in dataTable.Rows)
					{
						ParamValue paramValue = new ParamValue()
						{
							Id = (int)row[@"paramId"],
							Name = (string)row[@"paramName"],
							Value = (int)row[@"ParamValue"],
							IsActive = (bool)row[@"IsActive"],
						};
						values.Add(paramValue);
					}
				}
			}
			catch { }
			finally
			{
				connection.Close();
			}

			return values;
		}

		public static List<ParamValue> GetAllParamNames()
		{
			List<ParamValue> values = new List<ParamValue>();
			ConnectionHelper connection = new ConnectionHelper();
			SqlCommand cmd = connection.GetSqlCommand();
			cmd.CommandText = DBResource.GetAllParamNames;

			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					DataTable dataTable = new DataTable();
					dataTable.Load(reader);
					foreach (DataRow row in dataTable.Rows)
					{
						ParamValue paramValue = new ParamValue()
						{
							Id = (int)row[@"Id"],
							Name = (string)row[@"paramName"],
							IsActive = (bool)row[@"IsActive"],
						};
						values.Add(paramValue);
					}
				}
			}
			catch (Exception ex)
			{
				throw (ex);
			}
			finally
			{
				connection.Close();
			}

			return values;
		}
	}
}
