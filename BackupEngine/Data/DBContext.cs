using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace BackupEngine.Data
{
    public class DBContext
    {
        private readonly string _ConnecctionString;

        public DBContext()
        {
            _ConnecctionString = ConfigurationManager.ConnectionStrings["InMemoryDatabase"].ConnectionString;
        }

        public DataTable GetAll(string tableName)
        {
            using (SQLiteConnection con = new SQLiteConnection(_ConnecctionString))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = string.Format($"SELECT * FROM {tableName}");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                con.Close();
                return table;
            }
        }

        public DataTable Get(string tableName, params string[] colsNames)
        {
            using (SQLiteConnection con = new SQLiteConnection(_ConnecctionString))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                StringBuilder query = new StringBuilder();
                query.Append("SELECT ");
                foreach (string colName in colsNames)
                {
                    query.Append(colName);
                    if (colName != colsNames.Last())
                    {
                        query.Append(",");
                    }
                }
                query.Append($" From {tableName}");
                cmd.CommandText = string.Format(query.ToString());
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                con.Close();
                return table;
            }
        }

        public void Query(string query)
        {
            using (SQLiteConnection con = new SQLiteConnection(_ConnecctionString))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                cmd.CommandText = string.Format(query);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable GetWhere(string tableName, string where, params string[] colsNames)
        {
            using (SQLiteConnection con = new SQLiteConnection(_ConnecctionString))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(con);
                StringBuilder query = new StringBuilder();
                query.Append("SELECT ");
                foreach (string colName in colsNames)
                {
                    query.Append(colName);
                    if (colName != colsNames.Last())
                    {
                        query.Append(",");
                    }
                }
                query.Append($" From {tableName}");
                query.Append($" Where {where}");
                cmd.CommandText = string.Format(query.ToString());
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                con.Close();
                return table;
            }
        }
    }
}
