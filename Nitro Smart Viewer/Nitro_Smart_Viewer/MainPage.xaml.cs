using System;
using Xamarin.Forms;

namespace Nitro_Smart_Viewer
{
    public partial class MainPage : ContentPage
    {
        private readonly ITextFileReader _textFileReader;
        public MainPage(ITextFileReader textFileReader)
        {
            _textFileReader = textFileReader;
            InitializeComponent();
            nativeListView.Items = ResourceFileData.GetList();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ResourceFileData resourceFileData = e.SelectedItem as ResourceFileData;

            if (resourceFileData == null)
                return;

            switch (resourceFileData.Type)
            {
                case ResourceType.Txt:
                    await Navigation.PushModalAsync(new DetailPage(e.SelectedItem, _textFileReader));
                    break;
                case ResourceType.Image:
                    await Navigation.PushModalAsync(new ImagePage(e.SelectedItem));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}