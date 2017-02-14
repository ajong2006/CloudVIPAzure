using Xamarin.Forms;
using Prism.Navigation;
using CloudVIP.ViewModels;
using CloudVIP.Models;

namespace CloudVIP.Views
{
    public partial class MasterDetail : MasterDetailPage
    {
        public object viewModelSel;
        public MasterDetail()
        {
            InitializeComponent();

            listView.ItemsSource = Data.DrawerList;
            Title = "Master/Detail";
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            /* if(e.SelectedItem != null) lets us know that the item has been selected.
             *  The itemselected event is triggered not only when an item is selected, 
             *  but also when it is deselected. When an item is deselected, the SelectedItem 
             *  property of the event args is null.
             */


            if (e.SelectedItem != null)
            {
                var selection = e.SelectedItem as MenuModel;
                //await DisplayAlert("You selected", selection.Title+ "\n" +selection.NavName, "OK");

                #region DisableSelectionHighlighting
                //((ListView)sender).SelectedItem = null;
                #endregion
            }

            /*
            void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
            => ((ListView)sender).SelectedItem = null;

            void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                var menuItem = ((ListView)sender).SelectedItem as MenuModel;
                if (menuItem == null)
                    return;
            }
            */
        }
    }
}