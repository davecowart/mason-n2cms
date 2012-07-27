using N2.Details;
using N2.Web.UI;

namespace Mason.Web.Models.N2.Base {
	[WithEditableTitle(ContainerName = Containers.MainContent, SortOrder = 1)]
	[WithEditableName(ContainerName = Containers.Advanced, SortOrder = 2)]
	[TabContainer(Containers.MainContent, "Content", 1)]
	[TabContainer(Containers.Advanced, "Advanced", 100)]
	public class AbstractPage : AbstractItem {
		public string PreviewUrl {
			get { return Url; }
		}
	}
}