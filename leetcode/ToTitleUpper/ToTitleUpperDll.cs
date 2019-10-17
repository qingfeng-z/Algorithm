#region license
// <copyright company="ZAN LLC" file="ToTitleUpperDll.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace ToTitleUpperDll
{
    using System.Text;

    /// <summary>
    /// The to title upper.
    /// </summary>
    public static class ToTitleUpperDll
    {
        /// <summary>
        /// 字符串首字母大写
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string ToTitleUpper(this string value)
        {
            var str = value.Split(" ");
            var sb = new StringBuilder();
            foreach (var s in str)
            {
                if (string.IsNullOrEmpty(s) || s.Length == 1)
                {
                    sb.Append($"{s?.ToUpper()} ");
                    continue;
                }

                var state = s.Substring(0, 1).ToUpper();
                var end = s.Substring(1).ToLower();
                sb.Append($"{state}{end} ");
            }

            return sb.ToString();
        }
    }
}
