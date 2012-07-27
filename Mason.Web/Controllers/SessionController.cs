using System.Web.Mvc;
using System.Web.Security;
using Mason.Web.Models.ViewModels.Session;

namespace Mason.Web.Controllers {
	public class SessionController : Controller {
		public ActionResult New(string returnUrl) {
			if (Request.IsAuthenticated)
				return RedirectToRoute("Home");
			return View(new LoginModel { ReturnUrl = returnUrl });
		}

		public ActionResult Create(LoginModel loginModel) {
			if (!ModelState.IsValid)
				return View("New", loginModel);
			if (Membership.ValidateUser(loginModel.Username, loginModel.Password)) {
				FormsAuthentication.SetAuthCookie(loginModel.Username, loginModel.RememberMe);
				if (!string.IsNullOrWhiteSpace(loginModel.ReturnUrl))
					return Redirect(loginModel.ReturnUrl);
				return RedirectToRoute("Home");
			}
			ModelState.AddModelError("", "The username or password is incorrect.");
			return View("New", loginModel);
		}

		public ActionResult Destroy() {
			FormsAuthentication.SignOut();
			return RedirectToRoute("Home");
		}

		[Authorize]
		public ViewResult EditPassword() {
			return View(new PasswordModel());
		}

		[Authorize]
		public ActionResult UpdatePassword(PasswordModel passwordModel) {
			if (!ModelState.IsValid)
				return View("EditPassword", passwordModel);
			var currentUser = Membership.GetUser();
			if (currentUser == null) return RedirectToRoute("Home");
			if (currentUser.ChangePassword(passwordModel.CurrentPassword, passwordModel.NewPassword))
				return RedirectToRoute("Home");
			ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
			return View("EditPassword", passwordModel);
		}
	}
}
