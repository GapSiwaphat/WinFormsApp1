using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    internal class ConnectDB
    {
        public static SqlConnection ConnectNorthwind()
        {
            string server = @"ADM403-33\SQLEXPRESS";
            string db = "Northwind";
            string strCon = string.Format(@"Data Source={0}; Initial Catalog={1};"
                      + "Integrated Security=True;Encrypt=False", server, db);
            //string strCon = @"Data Source = LAPTOP - 5N08LR59\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True; Encrypt = False";
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            return conn;


        }
    }
}
