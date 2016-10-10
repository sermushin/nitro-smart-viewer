namespace Nitro_Smart_Viewer
{
    /*class MainPageCS : ContentPage
    {
        NativeListView nativeListView;

        public MainPageCS()
        {
            nativeListView = new NativeListView
            {
                Items = ResourceFileData.GetList(),
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = new Grid
            {
                RowDefinitions = {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
                },
                Children = {
                    new Label { Text = App.Description, HorizontalTextAlignment = TextAlignment.Center },
                    nativeListView
                }
            };

            nativeListView.ItemSelected += OnItemSelected;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushModalAsync(new DetailPage(e.SelectedItem));
        }
    }*/
}