[assembly: WebActivator.PostApplicationStartMethod(typeof(Mason.Web.App_Start.AutoMapperPackage), "PostStart")]
namespace Mason.Web.App_Start {
	public class AutoMapperPackage {
		public static void PostStart() {
			CreateMappings();
		}

		internal static void CreateMappings() {
			//TODO: put your mappings here
		}
	}
}