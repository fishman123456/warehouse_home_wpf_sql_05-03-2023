using Microsoft.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace warehouse_home_wpf_sql_05_03_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Conn_Click(object sender, RoutedEventArgs e)
        {
            Connect_sql.con_sql();
            
        }

        private void Data_Click(object sender, RoutedEventArgs e)
        {
            //Connect_sql.read_sql();
            const string sqlcomm = "SELECT * FROM product";

            const string conn = @"Data Source = (localdb)\MSSQLLocalDB;
            Initial Catalog = warehouse; Integrated Security = True;";

            SqlConnection con = null;
            //описываем соединение 
            con = new SqlConnection(conn);
            //создаем комманду на соединение
            SqlCommand cmd = new SqlCommand(sqlcomm, con);
            //открываем соединение
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dg.ItemsSource = dt.DefaultView;

            //выполнить запрос, занесенный
            //в объект command
            cmd.ExecuteNonQuery();

            con.Close();
        }

       
    }

        
    }

