namespace Mason.Web.Helpers.Extensions {
	using System.Web.Mvc;

	public static class HtmlHelperExtensions {
		public static MvcHtmlString CurrentBodyClass(this HtmlHelper helper) {
			var controller = helper.ViewContext.RouteData.GetRequiredString("controller");
			var action = helper.ViewContext.RouteData.GetRequiredString("action");
			return new MvcHtmlString(controller + "_" + action);
		}
	}
}