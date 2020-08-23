using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Port_v2._0
{
    public class Query
    {

        //запросы для получения отдельных таблиц
        public static DataTable GetShip()
        {
            return dbConnection.GetDataTable("SELECT * FROM [Ship]");
        }
        public static DataTable GetLoad()
        {
            return dbConnection.GetDataTable("SELECT * FROM [Load]");
        }
        public static DataTable GetHistory_Ship()
        {
            return dbConnection.GetDataTable("SELECT * FROM [History_Ship]");
        }
        public static DataTable GetNameShip()
        {
            return dbConnection.GetDataTable("SELECT DISTINCT  Name_Ship FROM Ship");
        }
        public static DataTable GetTypeLoad()
        {
            return dbConnection.GetDataTable("SELECT DISTINCT [Type_Ship] FROM Ship");
        }
        public static DataTable GetRecipient()
        {
            return dbConnection.GetDataTable("SELECT DISTINCT [F.I.O._Recipient] FROM Load");
        }
        public static DataTable GetInfoLoad()
        {
            return dbConnection.GetDataTable("SELECT DISTINCT [Info_Load] FROM Load");
        }
        public static DataTable GetExistNameShip(string Name_Ship)
        {
            return dbConnection.GetDataTable("SELECT  Name_Ship FROM Ship WHERE Name_Ship = '" + Name_Ship + "'");
        }
        public static DataTable GetDISTINCTNameShip(string Name_Ship)
        {
            return dbConnection.GetDataTable("SELECT DISTINCT Type_Ship FROM Ship WHERE Name_Ship = '" + Name_Ship + "'");
        }
        public static DataTable GetMaxID_Ship()
        {
            return dbConnection.GetDataTable("SELECT max([ID_Ship])+1 FROM Ship");
        }

        //выполнение всех запросов
        // Запрос №1
        public static DataTable GetDataTableQuery1(string Type_Load, string Name_Ship) 
        {
            string query = "SELECT [Info_Load],[Type_Load],[Amount of cargo],[Units],[F.I.O._Recipient],[From] FROM Load WHERE Type_Load= @Type_Load AND ID_Ship=(SELECT ID_Ship FROM Ship WHERE Name_Ship= @Name_Ship)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Type_Load", SqlDbType.VarChar);
            sqlParameters[1] = new SqlParameter("@Name_Ship", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Type_Load);
            sqlParameters[1].Value = Convert.ToString(Name_Ship);
            return dbConnection.GetDataTablePar(query, sqlParameters);
        }

        // Запрос №2
        public static DataTable GetDataTableQuery2(string Type_Load)
        {
            string query = "SELECT [Info_Load],[Type_Load],[Amount of cargo],[Units],[F.I.O._Recipient],[From] FROM Load WHERE Type_Load= @Type_Load AND ID_Ship=(SELECT ID_Ship FROM History_Ship WHERE Data_Arrivels=(SELECT Data_Arrivers =(SELECT MIN(Data_Arrivels) FROM History_Ship)))";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Type_Load", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Type_Load);
            return dbConnection.GetDataTablePar(query, sqlParameters);
        }

        // Запрос №3
        public static DataTable GetDataTableQuery3(string Recipient)
        {
            string query = "SELECT Info_Load,[Amount of cargo],Units, [F.I.O._Recipient] FROM Load WHERE [F.I.O._Recipient]= @Recipient ORDER BY Info_Load ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Recipient", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Recipient);
            return dbConnection.GetDataTablePar(query, sqlParameters);
        }

        // Запрос №4
        public static DataTable GetDataTableQuery4(string Info_Load)
        {
            string query = "SELECT [Info_Load],[Type_Load],[Amount of cargo],[Units],[F.I.O._Recipient],[From] FROM Load WHERE Info_Load= @Info_Load";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Info_Load", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Info_Load);
            return dbConnection.GetDataTablePar(query, sqlParameters);
        }

        // Запрос №5
        public static DataTable GetDataTableQuery5(string Name_Ship)
        {
            string query = "SELECT Data_Arrivels, Data_Departure FROM History_Ship WHERE ID_Ship=(SELECT ID_Ship FROM Ship WHERE Name_Ship= @Name_Ship)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Name_Ship", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Name_Ship);
            return dbConnection.GetDataTablePar(query, sqlParameters);
        }

        // Транзакция №1
        public static DataTable T1_IN(string ID_Ship, string Info_Load, string Type_Load, string Amount_of_cargo, string Units, string FIO_Recipient, string Frome, string Type_Ship, string Name_Ship, string Capitan, string Country, string datePatt)
        {
            string query1 = "Insert into Load ([ID_Ship],[Info_Load],[Type_Load],[Amount of cargo],[Units],[F.I.O._Recipient],[From]) VALUES (@ID_Ship,@Info_Load,@Type_Load,@Amount_of_cargo,@Units,@FIO_Recipient,@From)";
            string query2 = "Insert into Ship ([ID_Ship],[Type_Ship],[Name_Ship],[Capitan],[Country]) VALUES (@ID_Ship,@Type_Ship,@Name_Ship,@Capitan,@Country)";
            string query3 = "Insert into History_Ship ([ID_Ship],[Data_Arrivels]) VALUES (@ID_Ship,@Data_Arrivels)";
            
            SqlParameter[] sqlParameters = new SqlParameter[12];
            
            sqlParameters[0] = new SqlParameter("@ID_Ship", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(ID_Ship);
            
            sqlParameters[1] = new SqlParameter("@Info_Load", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(Info_Load);
            
            sqlParameters[2] = new SqlParameter("@Type_Load", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(Type_Load);
            
            sqlParameters[3] = new SqlParameter("@Amount_of_cargo", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(Amount_of_cargo);
            
            sqlParameters[4] = new SqlParameter("@Units", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(Units);
            
            sqlParameters[5] = new SqlParameter("@FIO_Recipient", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(FIO_Recipient);
            
            sqlParameters[6] = new SqlParameter("@From", SqlDbType.VarChar);
            sqlParameters[6].Value = Convert.ToString(Frome);

            sqlParameters[7] = new SqlParameter("@Type_Ship", SqlDbType.VarChar);
            sqlParameters[7].Value = Convert.ToString(Type_Ship);

            sqlParameters[8] = new SqlParameter("@Name_Ship", SqlDbType.VarChar);
            sqlParameters[8].Value = Convert.ToString(Name_Ship);

            sqlParameters[9] = new SqlParameter("@Capitan", SqlDbType.VarChar);
            sqlParameters[9].Value = Convert.ToString(Capitan);

            sqlParameters[10] = new SqlParameter("@Country", SqlDbType.VarChar);
            sqlParameters[10].Value = Convert.ToString(Country);

            sqlParameters[11] = new SqlParameter("@Data_Arrivels", SqlDbType.VarChar);
            sqlParameters[11].Value = Convert.ToString(datePatt);

            return dbConnection.GetT1(query1, query2, query3, sqlParameters);
        }

        // Транзакция №2
        public static DataTable T2_IN(string Name_Ship, string datePatt)
        {
            string query = "UPDATE History_Ship SET [Data_Departure] = @datePatt WHERE [ID_Ship] = (SELECT ID_Ship FROM Ship WHERE Name_Ship= @Name_Ship)";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@Name_Ship", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(Name_Ship);

            sqlParameters[1] = new SqlParameter("@datePatt", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(datePatt);

            return dbConnection.GetT2(query, sqlParameters);
        }
       
    }
}
