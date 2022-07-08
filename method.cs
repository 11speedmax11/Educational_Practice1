using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Practice
{
  public class method
  {
    public static MySqlConnection connection()
    {
        string connStr = "server=localhost;user=root;database=edu;port=3306;password=Maks1234";
        MySqlConnection conn = new MySqlConnection(connStr);
        return conn;
    }

  }
}
