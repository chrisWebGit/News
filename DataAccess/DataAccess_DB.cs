using System.Collections.Generic;

//include MySql.Data.dll

namespace DataAccess.DB.MySQL
{
    public class MySQL
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = null;
        private static MySql.Data.MySqlClient.MySqlCommand transaction = null;

        public static string OpenConnection(string server, string port, string uid, string pwd, string database) 
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string cs = string.Format("server={0};port={1};uid={2};pwd={3};database={4}", server, port, uid, pwd, database);

            try
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection(cs);
                connection.OpenAsync();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) 
            {
                return ex.Message;
            }

            return connection.ConnectionString;
        }
        public static void OpenTransaction() { transaction = new MySql.Data.MySqlClient.MySqlCommand(); }
        public static void CloseConnection() { connection.CloseAsync(); }
        public virtual void Insert(string table, List<string> columnList, List<string> valueList)
        {
            string stm = @"INSERT INTO " + table + "(";
            foreach(string column in columnList) { stm += column + ", "; }
            stm = stm.Substring(0, stm.Length - 2);
            stm += ") VALUES(";
            foreach (string value in valueList) { stm += "'" + value + "', "; }
            stm = stm.Substring(0, stm.Length - 2);
            stm += ")";
            transaction.Connection = connection;
            transaction.CommandText = stm;
            transaction.ExecuteNonQuery();
        }
        public virtual void Update() { }
        public virtual void Delete() { }
    }
}
