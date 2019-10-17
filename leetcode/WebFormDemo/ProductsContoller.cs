#region license
// <copyright company="ZAN LLC" file="ProductsContoller.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace WebFormDemo
{
    #region region

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
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
            return products;
        }

        /// <summary>
        /// The get product by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Product"/>.
        /// </returns>
        /// <exception cref="HttpResponseException">
        /// </exception>
        public Product GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return product;
        }

        /// <summary>
        /// The get products by category.
        /// </summary>
        /// <param name="category">
        /// The category.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return products.Where(
                p => string.Equals(p.Category, category,
                    StringComparison.OrdinalIgnoreCase));
        }
    }
}