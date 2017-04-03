using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Page), typeof(BLE.iOS.CustomPageRenderer))]
namespace BLE.iOS
{
    class CustomPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(false);

            var page = Element as ContentPage;

            if (page != null && !page.GetType().Equals(typeof(MainPage)))
            {
                var root = this.NavigationController.TopViewController;
                // NOTE: this doesn't look exactly right, you need to create an image to replicate the back arrow properly
                root.NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem("< Back", UIBarButtonItemStyle.Plain, (sender, args) =>
                    {
                        if (page.GetType().Equals(typeof(UrhoPage)))
                        {
                            (page as UrhoPage).BackButtonPressed();
                        }
                    }), false);
            }
        }
    }
}