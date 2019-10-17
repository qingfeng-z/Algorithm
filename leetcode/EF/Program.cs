#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace EF
{
    #region region

    using System;
    using System.Data.Entity;
    using System.Linq;

    #endregion

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            using (var db = new DiviceContext("Data Source=(localdb)\\MSSQLLocalDB;Database=CodeFirstDb;UID=sa;PWD=sql"))
            {
                var u = new User { Id = 1, Name = "qingfeng", Customer = "one" };
                db.Users.Add(u);
                db.SaveChanges();
                var query = from user in db.Users
                            select user;
                foreach (var q in query)
                {
                    Console.WriteLine("id:{0},Name:{1}", q.Id, q.Name);
                }

                Console.ReadLine();
            }
        }

    }
}
