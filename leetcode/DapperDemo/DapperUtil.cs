using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;

namespace DapperDemo
{
    static class DapperUtil
    {
        public static long Execute(this MySqlConnection db, string sql, object obj)
        {
            return db.Query<long>(sql + "SELECT @@Identity", obj).ToList().FirstOrDefault();
        }

        public static string If(this string str, bool conditon)
        {
            return conditon ? str : string.Empty;
        }
    }
}
