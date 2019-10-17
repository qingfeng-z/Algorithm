#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp3
{
    #region region

    using System;
    using System.Linq;

    #endregion
    /*
     *给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
     */

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
            Console.WriteLine("Hello World!");
        }

        public static int Reverse(int x)
        {
            
            var xstr = x.ToString();
            var str = string.Empty;
            foreach (var s in str)
            {
                
            }


            for (int i = 0; i < xstr.Length; i++)
            {
                var fuhao = string.Empty;
                if (xstr[0] == '-')
                {
                    fuhao = "-";
                }

                if (xstr[xstr.Length] == '0')
                {
                    break; 
                }
                str = $"{fuhao}{str}{xstr[xstr.Length - i]}";
            }

            return int.Parse(str);
        }
    }
}
