#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp6
{
    #region region

    using System;
    using System.Security.Cryptography;
    using System.Text;

    #endregion

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /*
         * md5
         */

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var value = "Hello World!";
            if (!string.IsNullOrEmpty(value))
            {
                var result = Encoding.Default.GetBytes(value);
                var md5 = new MD5CryptoServiceProvider();
                var output = md5.ComputeHash(result);
                var encryptResult = BitConverter.ToString(output).Replace("-", string.Empty);
                Console.WriteLine(encryptResult);
                Console.WriteLine(encryptResult.Length);
            }

            Console.ReadLine();
        }
    }
}
