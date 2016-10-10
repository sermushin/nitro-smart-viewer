using System;
using Xamarin.Forms;

namespace Nitro_Smart_Viewer
{
    public class ImagePage : ContentPage
    {
        public ImagePage(object detail)
        {
            string fileName = "";
            string displayName = "";
            var resourceFileData = detail as ResourceFileData;
            if (resourceFileData != null)
            {
                fileName = resourceFileData.FileName;
                displayName = resourceFileData.DisplayName;
            }

            Label header = new Label
            {
                Text = displayName,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Image image = new Image
            {
                // Some differences with loading images in initial release.
                Source = Device.OnPlatform(ImageSource.FromResource(fileName), ImageSource.FromResource(fileName), ImageSource.FromResource(fileName)),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 300
            };

            Button dismissButton = new Button { Text = "Close", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.End};
            dismissButton.Clicked += OnButtonClicked;
            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    image,
                    dismissButton
                }
            };
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}