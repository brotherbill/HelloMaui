using CommunityToolkit.Maui.Markup;

namespace HelloMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		Content = new Label()
			.Text("This is a Label")
			.Center()
			.TextCenter();
	}
}