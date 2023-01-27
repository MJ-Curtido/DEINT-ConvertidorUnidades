using DEINT_ConvertidorUnidades.MVVM.Views;

namespace DEINT_ConvertidorUnidades;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new InitialPage());
    }
}
