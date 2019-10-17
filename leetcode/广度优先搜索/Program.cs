#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace 广度优先搜索
{
    using System.Collections.Generic;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// <returns>
        /// The <see cref="void"/>.
        /// </returns>
        public static void Main(string[] args)
        {

            Sc();
            /*
             * 计算关系网中谁是销售商
             */
            var dict = new Dictionary<string, string[]>();
            dict.Add("me", new[] { "zhang", "wang", "li" });
            dict.Add("zhang", new[] { "han", "sun" });
            dict.Add("wang", new[] { "wu", "pen" });
            dict.Add("li", new[] { "wu", "xiao" });
            dict.Add("han", new[] { "sun", "chen" });
            // GetChen(dict);
            IsChen("");
        }

        private static bool IsChen(string v)
        {
            return v == "xiao";
        }


        private static void Sc()
        {
            var s = new List<string> { "a", "b" , "c" , "d" , "e" , "f" , "g" };
            s.Clear();
            foreach (var i in s)
            {
                //s.Remove(i);
            }
           var ess = 1;
        }

        ///// <summary>
        ///// The get chen.
        ///// </summary>
        ///// <param name="dict">
        ///// The dict.
        ///// </param>
        ///// <returns>
        ///// The <see cref="bool"/>.
        ///// </returns>
        //public static bool GetChen(Dictionary<string, string[]> dict)
        //{
        //    var que = new Queue<string>();
        //    foreach (var i in dict["me"])
        //    {
        //        que.Enqueue(i);
        //    }

        //    switch (true)
        //    {
        //            if (IsChen(que.Dequeue()))
        //            {
        //                return true;
        //            }
        //    }
        //    return false;
        //}
    }
}
