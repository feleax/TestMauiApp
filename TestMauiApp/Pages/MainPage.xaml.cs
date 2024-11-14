using TestMauiApp.Models;
using TestMauiApp.PageModels;

namespace TestMauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}