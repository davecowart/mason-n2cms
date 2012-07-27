using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mason.Web.Models.ViewModels.Session {
	public class LoginModel {
		[Required]
		public string Username { get; set; }
		[Required, DataType(DataType.Password)]
		public string Password { get; set; }
		[DisplayName("Remember Me")]
		public bool RememberMe { get; set; }
		public string ReturnUrl { get; set; }
	}
}