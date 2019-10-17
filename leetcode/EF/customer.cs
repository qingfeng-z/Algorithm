#region license
// <copyright company="ZAN LLC" file="Customer.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace EF
{
    /// <summary>
    /// The customer.
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
