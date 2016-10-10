using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Nitro_Smart_Viewer
{
    public class NativeListView : ListView
    {
        public static readonly BindableProperty ItemsProperty =
            BindableProperty.Create("Items", typeof(IEnumerable<ResourceFileData>), typeof(NativeListView), new List<ResourceFileData>());

        public IEnumerable<ResourceFileData> Items
        {
            get { return (IEnumerable<ResourceFileData>) GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {
            if (ItemSelected != null)
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
        }
    }
}