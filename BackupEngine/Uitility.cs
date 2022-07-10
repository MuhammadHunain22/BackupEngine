using BackupEngine.Data;
using System.Data;

namespace BackupEngine
{
    internal class Uitility
    {
        private readonly DBContext _context;
        public Uitility()
        {
            _context = new DBContext();
        }
        internal bool CheckUnique(string tableName, string colName, string value)
        {
            try
            {
                DataTable table = _context.GetWhere(tableName, $"{colName}='{value}'", colName);
                if (table.Rows.Count > 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return false;
            }
        }
    }
}
