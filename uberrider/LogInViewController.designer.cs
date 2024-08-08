// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace uberrider
{
	[Register ("LogInViewController")]
	partial class LogInViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton btnLogin { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton btnRegister { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel clickToLogin { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel clickToRegister { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UITextField emailText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UITextField fullNameText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UITextField passwordText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UITextField phoneText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UITextField textEmail { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnLogin != null) {
				btnLogin.Dispose ();
				btnLogin = null;
			}

			if (btnRegister != null) {
				btnRegister.Dispose ();
				btnRegister = null;
			}

			if (clickToLogin != null) {
				clickToLogin.Dispose ();
				clickToLogin = null;
			}

			if (clickToRegister != null) {
				clickToRegister.Dispose ();
				clickToRegister = null;
			}

			if (emailText != null) {
				emailText.Dispose ();
				emailText = null;
			}

			if (fullNameText != null) {
				fullNameText.Dispose ();
				fullNameText = null;
			}

			if (passwordText != null) {
				passwordText.Dispose ();
				passwordText = null;
			}

			if (phoneText != null) {
				phoneText.Dispose ();
				phoneText = null;
			}

			if (textEmail != null) {
				textEmail.Dispose ();
				textEmail = null;
			}
		}
	}
}
