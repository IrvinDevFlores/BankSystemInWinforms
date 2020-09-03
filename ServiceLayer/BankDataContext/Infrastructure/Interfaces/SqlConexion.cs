using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BankDataContext.Infrastructure.Interfaces
{
    public class SqlConexion
    {
        private static string stringConnection = "Data Source=localhost;uid=sa;pwd=7Keylogger7;Initial Catalog=bankdb;Integrated Security=True";

        private static SqlConnection _conexion = new SqlConnection(stringConnection);

        public static SqlConnection GetConnection() => _conexion;
        public static  void OpenConexion() =>  _conexion.Open();
        public static  void CloseConexion() =>  _conexion.Close();
    }
}
