#region license
// <copyright company="ZAN LLC" file="DiviceContext.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace EF
{
    #region region

    using System.Data.Entity;

    #endregion

    /// <summary>
    /// The divice context.
    /// </summary>
    public class DiviceContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiviceContext"/> class.
        /// </summary>
        /// <param name="connectionName">
        /// The connection name.
        /// </param>
        public DiviceContext(string connectionName)
            : base(connectionName)
        {
        }

        /// <summary>
        /// Gets or sets the orders.
        /// </summary>
        public DbSet<User> Users
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the order details.
        /// </summary>
        public DbSet<Customer> cus
        {
            get;
            set;
        }
    }
}
