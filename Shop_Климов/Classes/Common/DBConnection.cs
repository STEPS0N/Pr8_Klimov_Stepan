using System; 
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Климов.Classes.Common
{
    public class DBConnection
    {
        public static readonly string Path = @"E:\3 курс\Ощепков\Практические работы\Практическая работа №6\Shop_Климов\Shop_Климов\Shop.accdb";

        public static OleDbConnection Connection()
        {
            OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Path);

            oleDbConnection.Open();

            return oleDbConnection;
        }

        public static OleDbDataReader Query(string Query, OleDbConnection Connection)
        {
            return new OleDbCommand(Query, Connection).ExecuteReader();
        }

        public static void CloseConnection(OleDbConnection Connection)
        {
            Connection.Close();
        }
    }
}
