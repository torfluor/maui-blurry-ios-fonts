using CoreAnimation;
using CoreGraphics;
using UIKit;

namespace maui_blurry_ios_fonts;

public class NativeiosLabel : UIView
{

	bool setupComplete;

	CATextLayer textLayer = new();
	UILabel textLabel = new();
	
	public NativeiosLabel(NativeLabel view)
	{
	}

	public override void LayoutSubviews()
	{
		base.LayoutSubviews();
		
		if(!setupComplete) {
			
			textLayer.TextAlignmentMode = CATextLayerAlignmentMode.Center;
			textLayer.String = "Hello CATextLayer";
			textLayer.FontSize = 18;
			textLayer.ForegroundColor = UIColor.Black.CGColor;
			Layer.AddSublayer(textLayer);

			textLabel.TextAlignment = UITextAlignment.Center;
			textLabel.Text = "Hello UILabel";
			textLabel.Font = UIFont.SystemFontOfSize(18);
			textLabel.TextColor = UIColor.Black;
			AddSubview(textLabel);

			setupComplete = true;
		}

		textLayer.Frame = new CGRect(0, 0, Bounds.Width, Bounds.Height / 2);
		textLabel.Frame = new CGRect(0, Bounds.Height / 2, Bounds.Width, Bounds.Height / 2);
	}

}
