using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Port_v2._0
{
    public class dbConnection
    {
        // Строка подключения
        private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PortConnectionString"].ConnectionString);

        // открытие подключения к базе данных, если оно было закрыто или разорвано
         private static SqlConnection openConnection()
         {
             if (conn.State == ConnectionState.Closed)
             {
                 conn.Open();
             }
             else
             {
                 MessageBox.Show("Ошибка подключения!");
             }
             return conn;
         }

        // получить таблицу из запроса
        public static DataTable GetDataTable(string Q)
        {
            DataTable DT = new DataTable();
            SqlCommand myCommand = new SqlCommand();
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            myCommand.Connection = openConnection();
            myCommand.CommandText = Q;
            myCommand.ExecuteNonQuery();
            myAdapter.SelectCommand = myCommand;
            myAdapter.Fill(DT);
            myCommand.Connection.Close();
            return DT;
        }

        // получить таблицу из запроса c параметрами
        public static DataTable GetDataTablePar(string Q, SqlParameter[] sqlParameter)
        {
            DataTable dataTable = new DataTable();
            SqlCommand myCommand = new SqlCommand();
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            dataTable = null;
            DataSet ds = new DataSet();

            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = Q;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show("Хм..., что-то пошло не так =)", "Упс...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                myCommand.Connection.Close();
            }
            return dataTable;
        }

        // Выполнение транцакций 1 c параметрами
        public static DataTable GetT1(string query1, string query2, string query3, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = openConnection();
            SqlTransaction transaction = conn.BeginTransaction();
            myCommand.Transaction = transaction;

            try
            {
                myCommand.CommandText = query2;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery(); //выполняем запрос
                myCommand.CommandText = query1;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = query3;
                myCommand.ExecuteNonQuery(); //выполняем запрос
                transaction.Commit(); //подтверждаем транзакцию
                MessageBox.Show("Все данные были успешно добавлены");

            }
            catch //если возникла ошибка, выходим из транзакции с откатом
            {
                MessageBox.Show("Ошибка транзакции!");

                try
                {
                    transaction.Rollback();
                }

                catch
                {
                    MessageBox.Show("Ошибка отката транзакции!");
                }
            }

            finally
            {
                myCommand.Connection.Close();

            }
            return null;
        }
        
        // Выполнение транцакций 2 c параметрами
        public static DataTable GetT2(string query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = openConnection();
            SqlTransaction transaction = conn.BeginTransaction();
            myCommand.Transaction = transaction;

            try
            {
                myCommand.CommandText = query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery(); //выполняем запрос
                transaction.Commit(); //подтверждаем транзакцию
                MessageBox.Show("Транзакция выполнена успешно");

            }
            catch //если возникла ошибка, выходим из транзакции с откатом
            {
                MessageBox.Show("Ошибка транзакции!");

                try
                {
                    transaction.Rollback();
                }

                catch
                {
                    MessageBox.Show("Ошибка отката транзакции!");
                }
            }

            finally
            {
                myCommand.Connection.Close();

            }
            return null;
        }
    }
}
