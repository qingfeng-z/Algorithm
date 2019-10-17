#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 正则
{
    #region region

    using System;
    using System.Text.RegularExpressions;

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
            while (true)
            {
                var regular = @"-\d{4}";

                // var regular = @"\s+";
                // var regular = @"\s+";
                var str = Console.ReadLine();
                str = Regex.Replace(str, regular, string.Empty);
                Console.WriteLine(str);
            }
        }
    }
}
