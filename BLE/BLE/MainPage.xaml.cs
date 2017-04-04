using System;
using Xamarin.Forms;

namespace BLE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var toolbarItem = new ToolbarItem
            {
                Text = "Toolbar",
                Icon = "icon"
            };
            ToolbarItems.Add(toolbarItem);
        }

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UrhoPage());
        }
    }
}
