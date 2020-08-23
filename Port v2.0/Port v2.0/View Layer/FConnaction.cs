using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Port_v2._0
{
    public partial class FConnaction : Form
    {
        private static string ConnString;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private Port Port;
        MyConnectionClass MyConnectionString = new MyConnectionClass();
        
        public FConnaction()
        {
            InitializeComponent();
            // Retrieve the ConnectionString from App.config 
            string connectString = ConfigurationManager.ConnectionStrings["PortConnectionString"].ToString();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);
            // Retrieve the DataSource property.    
            string Data_Source = builder.DataSource;
            // Retrieve the DataBaseName (Catalog) property. 
            string DataBase = builder.InitialCatalog;
            ServerName.Text = Data_Source;
            DataBaseName.Text = DataBase;
        }
        public class MyConnectionClass
        {
            public MyConnectionClass()
            {
            }

            public string MyConnectionString()
            {
                return ConnString;
            }
        }

        private void BCon_Click(object sender, EventArgs e)
        {
            string @row1 = ServerName.Text;
            string @row2 = DataBaseName.Text;

            {

                ConnString = @"Data Source=" + @row1 + ";" + "initial catalog=" + @row2 + ";" + "Integrated Security=true;";

            }

            sqlConnection = new SqlConnection(ConnString);

            try
            {
                sqlConnection.Open();
                MessageBox.Show("Connection succsessfull");
                
                try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.ConnectionStrings.ConnectionStrings["PortConnectionString"].ConnectionString = ConnString;
                    config.Save(ConfigurationSaveMode.Modified);
                }

                catch
                {
                    MessageBox.Show("Run application as Administrator");
                    this.Close();
                }
                sqlConnection.Close();
                
                Port = new Port(); Port.Show();
                this.Hide();
            }
            catch 
            {
                MessageBox.Show("Ошибка в подсоединении (проверьте наличие БД на компьютере или правильность написания имени сервера и названия БД)");
            }
            finally
            {

            }
        }
    }
}
