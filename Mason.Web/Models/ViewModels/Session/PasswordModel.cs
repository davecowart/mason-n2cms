using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mason.Web.Models.ViewModels.Session {
	public class PasswordModel {
		[Required, DisplayName("Current Password"), DataType(DataType.Password)]
		public string CurrentPassword { get; set; }
		[Required, DisplayName("New Password"), DataType(DataType.Password)]
		public string NewPassword { get; set; }
		[Required, DisplayName("Confirm New Password"), DataType(DataType.Password), Compare("NewPassword", ErrorMessage = "The confirmation password does not match the new password.")]
		public string ConfirmNewPassword { get; set; }
	}
}