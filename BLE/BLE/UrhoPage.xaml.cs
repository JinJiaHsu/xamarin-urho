using Xamarin.Forms;
using Urho;
using Urho.Forms;

namespace BLE
{
    public partial class UrhoPage : ContentPage
    {
        UrhoChart urhoApp;

        public UrhoPage()
        {
            InitializeComponent();
        }

        async void StartUrhoApp()
        {
            urhoApp = await urhoSurface.Show<UrhoChart>(new ApplicationOptions() { Orientation = ApplicationOptions.OrientationType.Portrait });
        }

        protected override void OnAppearing()
        {
            StartUrhoApp();
            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            BackButtonPressed();

            return base.OnBackButtonPressed();
        }

        async public void BackButtonPressed()
        {
            ExitUrhoApp();

            if (Device.RuntimePlatform == Device.iOS)
                await Navigation.PopAsync(false);
        }

        public void ExitUrhoApp()
        {
            urhoApp.Exit();
            UrhoSurface.OnDestroy();
        }
    }
}
