using System.Web.Mvc;
using System.Web.Routing;

namespace Salomon_Porfolio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapRoute(
                name: "Mails",
                url: "{controller}/{action}/{id}",
                defaults: new { Controller = "Page", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}

