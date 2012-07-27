using Mason.Web.Models.N2.Pages;
using N2.Web;
using N2.Web.Mvc;

namespace Mason.Web.Controllers {
	[Controls(typeof(HomePage))]
	public class HomeController : ContentController<HomePage> {
	}
}
