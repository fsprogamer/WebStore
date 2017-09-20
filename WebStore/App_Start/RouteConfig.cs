using System.Web.Mvc;
using System.Web.Routing;

namespace WebStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Employees", action = "List", id = UrlParameter.Optional }
           );

            // ALL THE PROPERTIES:
            // rentalProperties/
            //routes.MapRoute(
            //    name: "Properties",
            //    url: "RentalProperties/{action}/{id}",
            //    defaults: new
            //    {
            //        controller = "RentalProperty",
            //        action = "All",
            //        id = UrlParameter.Optional
            //    }
            //);

           // routes.MapRoute(
           //     name: "Catalog",
           //     url: "catalog/{section}/{name}_{id}",//catalog/home/lamp_35
           //     defaults: new { controller = "Catalog", action = "Item" }
           //);
        }

    }
}

