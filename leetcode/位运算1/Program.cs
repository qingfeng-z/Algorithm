using System;
using System.Collections.Generic;

namespace 位运算1
{
    using System.Collections.Generic;

    class Program
    {

        static void Main(string[] args)
        {
            var list = new List<Auth> { Auth.查看, Auth.编辑, Auth.下载 };

            if (!Enum.TryParse(string.Join(",", list), out Auth auth))
            {
                Console.WriteLine("枚举转换失败");
            }
            Console.WriteLine(auth); // 7
            Console.ReadLine();
        }

        public enum Auth
        {
            查看 = 1,
            编辑 = 2,
            下载 = 4,
        }


    }
}

namespace AuthType
{
    public static class test
    {
        public static void getAuth<T>(this List<T>  t)
        {
            
        }
    }

}