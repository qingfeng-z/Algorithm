
#region license
// <copyright company="ZAN LLC" file="ResponseObject.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace WebApiDemo.Models
{
    /// <summary>
    /// The response object.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class ResponseObject<T>
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public int Code { get; set; } = -1;

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public T Content { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is ok.
        /// </summary>
        public bool IsOk { get; set; } = true;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }
    }
}