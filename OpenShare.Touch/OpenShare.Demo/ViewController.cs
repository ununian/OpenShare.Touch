using System;
using CoreGraphics;
using UIKit;

namespace OpenShare.Demo
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			var btn = new UIButton(UIButtonType.InfoDark);
			btn.Frame = new CGRect(100, 100, 100, 44);
			btn.TouchUpInside += Btn_TouchUpInside;
			View.AddSubview(btn);
		}

		void Btn_TouchUpInside(object sender, EventArgs e)
		{
			OpenShareTouch.OpenShare_QQ.ChatWithQQNumber(null, "418874472");
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
