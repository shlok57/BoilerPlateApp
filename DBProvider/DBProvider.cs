using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shlok.DBProviders
{
    public class DBProvider
    {
        public static int Function(int param)
        {
            return param * param;
        }

		public static bool StoreParamName(string paramName)
		{
			bool result = false;
			ConnectionHelper connection = new ConnectionHelper();
			SqlCommand cmd = connection.GetSqlCommand();
			cmd.CommandText = DBResource.AddParam;
			cmd.Parameters.Add(@"paramName", System.Data.SqlDbType.VarChar).Value = paramName;
			
			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				result = !reader.RecordsAffected.Equals(0);
			}

			return result;
		}
    }
}
