using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace maui_blurry_ios_fonts;

public partial class NativeLabelHandler : ViewHandler<NativeLabel, NativeiosLabel>
{
	protected override NativeiosLabel CreatePlatformView() => new NativeiosLabel(VirtualView);

	protected override void ConnectHandler(NativeiosLabel platformView)
	{
		base.ConnectHandler(platformView);

		// Perform any control setup here
	}

	protected override void DisconnectHandler(NativeiosLabel platformView)
	{
		//platformView.Dispose();
		base.DisconnectHandler(platformView);
	}

}
