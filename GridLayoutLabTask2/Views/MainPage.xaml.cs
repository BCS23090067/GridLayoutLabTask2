using GridLayoutLabTask2.ViewModels;

namespace GridLayoutLabTask2.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}