using Mason.Web.Models.N2.Base;
using N2;
using N2.Definitions;
using N2.Installation;
using N2.Integrity;

namespace Mason.Web.Models.N2.Pages {
	[PageDefinition("Home Page", InstallerVisibility = InstallerHint.PreferredStartPage)]
	[RestrictParents(typeof(IRootPage))]
	public class HomePage : AbstractPage, IStartPage {
	}
}