
using Microsoft.Maui.Handlers;

namespace maui_blurry_ios_fonts;

public partial class NativeLabelHandler
{

	public static IPropertyMapper<NativeLabel, NativeLabelHandler> PropertyMapper = new PropertyMapper<NativeLabel, NativeLabelHandler>(ViewHandler.ViewMapper)
	{

	};


	public NativeLabelHandler() : base(PropertyMapper)
	{
	}



}
