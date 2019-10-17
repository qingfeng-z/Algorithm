#region license
// <copyright company="ZAN LLC" file="Global.asax.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion

namespace WebFormDemo
{
    #region region

    using System;
    using System.Web;
    using System.Web.Http;
    using System.Web.Optimization;
    using System.Web.Routing;

    #endregion

    /// <summary>
    /// The global.
    /// </summary>
    public class Global : HttpApplication
    {
        /// <summary>
        /// The application_ start.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteTable.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}