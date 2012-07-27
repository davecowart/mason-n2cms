using N2.Web.Mvc;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Mason.Web.App_Start.WindsorPackage), "PreStart")]
namespace Mason.Web.App_Start {
	public class WindsorPackage {
		public static void PreStart() {
			var engine = MvcEngine.Create();
			engine.RegisterAllControllers();
			//TODO: add components here
		}
	}
}