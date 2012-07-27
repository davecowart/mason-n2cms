using System.Web.Mvc;
using System.Web.Routing;
using N2.Engine;
using N2.Web.Mvc;

namespace Mason.Web {
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication {
		public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes, IEngine engine) {
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.Add(new ContentRoute(engine));
			routes.MapRoute("Home", "", new { controller = "Home", action = "Index" });
			routes.MapRoute(
					"Default", // Route name
					"{controller}/{action}/{id}", // URL with parameters
					new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);
		}

		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();
			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes, MvcEngine.Create());
		}
	}
}