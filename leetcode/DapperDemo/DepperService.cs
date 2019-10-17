using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperDemo
{
    class DepperService
    {
        public static MySqlConnection MySqlConnection()
        {
            var connection = new MySqlConnection("server=bj-cdb-qmo3j546.sql.tencentcdb.com;port=61912;database=ace-dev;user=qingfeng_dev;password=zqf9610051212");
            connection.Open();
            return connection;
        }
    }
}
