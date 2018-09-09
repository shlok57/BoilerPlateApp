using System.Data;
using System.Data.SqlClient;

namespace Shlok.DBProviders
{
	public class ConnectionHelper
	{
		private static string _connectionString;
		private static SqlConnection _conn;
		private static SqlCommand _cmd;

		public ConnectionHelper()
		{
			_connectionString = Properties.Settings.Default.BoilerPlateAppDBConnectionString;
			_conn = new SqlConnection(_connectionString);
			_conn.Open();
			_cmd = new SqlCommand();
			_cmd.Connection = _conn;
			_cmd.CommandType = CommandType.StoredProcedure;
		}

		public SqlCommand GetSqlCommand()
		{
			return _cmd;
		}

		public void Close()
		{
			_conn.Close();
		}
	}
}
