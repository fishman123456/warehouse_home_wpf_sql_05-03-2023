using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;
using System.Windows;

namespace warehouse_home_wpf_sql_05_03_2023
{
    internal class Connect_sql
    {

        public static void con_sql()
        {
            try
            {
                const string conn = @"Data Source = (localdb)\MSSQLLocalDB;
                Initial Catalog = warehouse; Integrated Security = True;";
                SqlConnection conn2 = new SqlConnection(conn);

                conn2.Open();
                MessageBox.Show("Соединение установлено");
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

    }
}
