#region license
// <copyright company="ZAN LLC" file="ProductsController.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace WebApiDemo.Controllers
{
    #region region

    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using WebApiDemo.Models;

    #endregion

    /// <summary>
    /// The products controller.
    /// </summary>
    public class ProductsController : ApiController
    {
        /// <summary>
        /// The products.
        /// </summary>
        private readonly Product[] products = {
                                     new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
                                     new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                                     new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
                                 };

        /// <summary>
        /// The get all products.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return this.products;
        }

        /// <summary>
        /// The get product.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="IHttpActionResult"/>.
        /// </returns>
        public IHttpActionResult GetProduct(int id)
        {
            var product = this.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
