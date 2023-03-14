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
using System.Windows.Controls;

namespace warehouse_home_wpf_sql_05_03_2023
{
    internal class Connect_sql
    {
       const  string sqlcomm = "SELECT * FROM product";

        const string conn = @"Data Source = (localdb)\MSSQLLocalDB;
                Initial Catalog = warehouse; Integrated Security = True;";

        public static void con_sql()
        {
            try
            {
               
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
        public static void read_sql() 
        {
           
        using(SqlConnection conn2 = new SqlConnection(conn)) 
            {
                conn2.Open();
                SqlCommand cmd = new SqlCommand(sqlcomm ,conn2);
                
                
                //DataGrid dt = new DataGrid();
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                while (reader.Read()) 
                {
                    MessageBox.Show("читаем"+" "+ count);
                    count++;
                    object id_p = reader.GetValue(0);
                    object type_p = reader.GetValue(1);
                    object prod_supplier_p = reader.GetValue(2);
                   
                }
            }
        }
    }
}
