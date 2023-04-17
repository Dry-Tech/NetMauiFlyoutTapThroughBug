namespace NetMauiFlyoutTapThroughBug;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MyFlyoutPage();
	}
}
