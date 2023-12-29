namespace MauiApp4;

public partial class InitialPage : ContentPage
{
    InitialPageViewModel viewModel;

    public InitialPage()
	{
		InitializeComponent();

        viewModel = (InitialPageViewModel)this.BindingContext;
    }


    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await viewModel.SetInitialPageAsync();
    }


}