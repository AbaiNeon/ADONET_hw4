using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.Common;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;

namespace hw4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using(DbConnection connection = CreateConnection())
            {
                connection.Open();
                //
                //код
                //
            }
        }

        private DbConnection CreateConnection()
        {
            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["connectionStringsName"].ProviderName);
            DbConnection connection = dbProviderFactory.CreateConnection();

            SqlConnectionStringBuilder myBuilder = new SqlConnectionStringBuilder();

            myBuilder.UserID = "abai";
            myBuilder.Password = "123";
            myBuilder.InitialCatalog = "MyDB";
            myBuilder.DataSource = @"DESKTOP-QQA0OC9\SQLEXPRESS";
            myBuilder.ConnectTimeout = 30;
            connection.ConnectionString = myBuilder.ConnectionString;
            return connection;
        }
    }
}
