namespace Mason.Web.Models.N2.Base {
	public abstract class AbstractPart : AbstractItem {
		public override bool IsPage {
			get { return false; }
		}
	}
}