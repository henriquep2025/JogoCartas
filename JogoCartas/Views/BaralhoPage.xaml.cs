using JogoCartas.ViewModels;

namespace JogoCartas.Views;

public partial class BaralhoPage : ContentPage
{
	public BaralhoPage(BaralhoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}