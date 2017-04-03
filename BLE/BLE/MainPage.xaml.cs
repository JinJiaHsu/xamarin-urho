using System;
using Xamarin.Forms;

namespace BLE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UrhoPage());
        }
    }
}
