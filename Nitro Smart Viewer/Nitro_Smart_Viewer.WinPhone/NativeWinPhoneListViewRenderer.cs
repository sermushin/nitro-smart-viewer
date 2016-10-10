using System.ComponentModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Nitro_Smart_Viewer;
using Nitro_Smart_Viewer.WinPhone;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;
using ListView = Windows.UI.Xaml.Controls.ListView;

[assembly: ExportRenderer(typeof(NativeListView), typeof(NativeWinPhoneListViewRenderer))]

namespace Nitro_Smart_Viewer.WinPhone
{
    public class NativeWinPhoneListViewRenderer : ListViewRenderer
    {        
        private ListView _listView;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            _listView = Control as ListView;

            if (e.OldElement != null)
            {
                // Unsubscribe
                _listView.SelectionChanged -= OnSelectedItemChanged;
            }

            if (e.NewElement != null)
            {
                _listView.SelectionMode = ListViewSelectionMode.Single;
                _listView.IsItemClickEnabled = false;
                _listView.ItemsSource = ((NativeListView)e.NewElement).Items;
                _listView.ItemTemplate = App.Current.Resources["ListViewItemTemplate"] as Windows.UI.Xaml.DataTemplate;
                // Subscribe
                _listView.SelectionChanged += OnSelectedItemChanged;
            }
        }
        
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == NativeListView.ItemsProperty.PropertyName)
                _listView.ItemsSource = ((NativeListView) Element).Items;
        }

        private void OnSelectedItemChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 1)
            {
                ((NativeListView) Element).NotifyItemSelected(e.AddedItems[0]);
                _listView.SelectedItem = null;
            }
        }
    }
}