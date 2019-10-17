// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResponseTestController.cs" company="">
//   
// </copyright>
// <summary>
//   The response test controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#region license
// <copyright company="ZAN LLC" file="ResponseTestController.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace WebApiDemo.Controllers
{
    #region region

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Web.Http;

    using WebApiDemo.Models;

    #endregion

    /// <summary>
    /// The response test controller.
    /// </summary>
    public class ResponseTestController : ApiController
    {
        /// <summary>
        /// The products.
        /// </summary>
        private readonly Product[] products = {
                                                      new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
                                                      new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                                                      new Product { Id = 3, Name = "Tom", Category = "Hardware", Price = 16.99M }
                                                  };

        /// <summary>
        /// 无返回值
        /// </summary>
        public void NotResponse()
        {
            // 返回值状态码为204 无响应结果返回
        }

        /// <summary>
        /// HttpResponseMessage
        /// </summary>
        /// <returns>
        /// The <see cref="HttpResponseMessage"/>.
        /// </returns>
        public HttpResponseMessage GetHttpResponseMessage()
        {
            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK, "value");

            response.StatusCode = HttpStatusCode.OK;

            response.Content = new StringContent("hello", Encoding.Unicode);
            response.Headers.CacheControl = new CacheControlHeaderValue
                                                {
                                                    MaxAge = TimeSpan.FromMinutes(20)
                                                };
            return response;
        }

        /// <summary>
        /// The get http response message.
        /// </summary>
        /// <param name="str">
        /// The str.
        /// </param>
        /// <returns>
        /// The <see cref="ResponseObject"/>.
        /// </returns>
        public ResponseObject<string> GetHttpResponseMessage(string str)
        {
            return new ResponseObject<string> { Content = "Hi" };
        }

        /// <summary>
        /// IHttpActionResult.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="IHttpActionResult"/>.
        /// </returns>
        public IHttpActionResult Get(int id)
        {
            Product product = this.products.FirstOrDefault(s=>s.Id == id);
            if (product == null)
            {
                return NotFound(); // Returns a NotFoundResult
            }

            return Ok(product);  // Returns an OkNegotiatedContentResult
        }

        /// <summary>
        /// 自定义.
        /// </summary>
        /// <param name="s">
        /// The s.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<Product> Get(string s)
        {
            return this.products;
        }
    }
}
