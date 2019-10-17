#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ConsoleApp7
{
    #region region

    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    #endregion

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {

        //给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写
      
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IsPalindrome(string.Empty);

        }

        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }

            var str = s.Replace(" ", string.Empty).ToLower();
            StringBuilder strE = new StringBuilder();
            foreach (var e in str)
            {
                if ((e >= 'a' && e <= 'z') || (e >= '0' && e <= '9'))
                {
                    strE.Append(e);
                }
            }

            var index = strE.Length % 2 == 0 ? strE.Length / 2 : (strE.Length - 1) / 2;


            for (int i = 0; i < index; i++)
            {
                if (strE[i] != strE[strE.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
