#region license
// <copyright company="ZAN LLC" file="LeetCodeBase.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace ConsoleApp10
{
    #region region

    using System;

    #endregion

    /// <summary>
    /// The leet code base.
    /// </summary>
    public class LeetCodeBase
    {
        /// <summary>
        /// id
        /// </summary>
        public long RowId { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the create by.
        /// </summary>
        public long CreateBy { get; set; }

        /// <summary>
        /// Gets or sets the up date time.
        /// </summary>
        public DateTime UpDateTime { get; set; }
    }
}
