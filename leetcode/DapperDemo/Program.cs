using Dapper;
using System;
using System.Linq;

namespace DapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            DapperQueryTest();
            DapperInsertTest();
        }

        private static void DapperQueryTest()
        {
            using (var conn = DepperService.MySqlConnection())
            {
                string sqlCommandStr = @"SELECT * FROM address";
                var userList = conn.Query<Address>(sqlCommandStr).ToList();
                Console.ReadLine();
            }
        }

        private static void DapperInsertTest()
        {
            using (var conn = DepperService.MySqlConnection())
            {
                string sqlCommandStr = @"INSERT INTO address(CreateBy, Created, LastUpdate, LastUpdateBy, ModifiedNum, AddressDescription, ContactId, GeographyId) VALUE(@CreateBy,@Created,@LastUpdate,@LastUpdateBy,@ModifiedNum,@AddressDescription,@ContactId,@GeographyId);";
                
                //返回自增主键
                //sqlCommandStr += "SELECT @@Identity";
                var address = new Address
                {
                    CreateBy = 1,
                    Created = DateTime.Now,
                    LastUpdate = DateTime.Now,
                    LastUpdateBy = 1,
                    ModifiedNum = 1,
                    AddressDescription = "",
                    ContactId = 11,
                    GeographyId = null
                };

                //var categoryId1 = conn.Execute(sqlCommandStr, category);
                //var categoryId = conn.Query<long>(sqlCommandStr, category).ToList().FirstOrDefault();
                var ee = conn.Execute(sqlCommandStr, address);
                Console.WriteLine(ee);
            }
        }
    }
}
