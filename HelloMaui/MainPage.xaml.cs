using CommunityToolkit.Maui.Markup;

namespace HelloMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		Content = new Label()
			.Text("This is a Label")  
			.Center()			// Center Horizontally and Vertically
			.TextCenter();		// Center text horizontally
	}
}