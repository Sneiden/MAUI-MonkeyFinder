
namespace MonkeyFinder_App.View;

public partial class MainPage : ContentPage
{
	public MainPage( MonkeysViewModel viewModel)
	{
		InitializeComponent();
		BindingContext= viewModel;
    }
}