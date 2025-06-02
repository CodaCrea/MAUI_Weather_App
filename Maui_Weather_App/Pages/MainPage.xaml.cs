using Maui_Weather.Models;
using Maui_Weather.PageModels;

namespace Maui_Weather.Pages
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