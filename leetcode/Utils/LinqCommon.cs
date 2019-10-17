#region license
// <copyright company="ZAN LLC" file="ArrayCommon.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace Utils
{

    /// <summary>
    /// The class 1.
    /// </summary>
    public static class LinqCommon
    {
        /// <summary>
        /// The is null.
        /// </summary>
        /// <param name="o">
        /// The o.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsNull(this object o)
        {
            return o != null;
        }
    }
}
