using DEINT_ConvertidorUnidades.MVVM.ViewModels;

namespace DEINT_ConvertidorUnidades.MVVM.Views;

public partial class InitialPage : ContentPage
{
	public InitialPage()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		var element = (Grid)sender;

		var option = ((Label)element.Children.LastOrDefault()).Text;

		var converterView = new ConverterPage
		{
			BindingContext = new ConverterViewModel(option)
		};

		Navigation.PushAsync(converterView);
	}
}