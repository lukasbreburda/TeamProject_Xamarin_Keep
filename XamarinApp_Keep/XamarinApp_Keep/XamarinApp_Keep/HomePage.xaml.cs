using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp_Keep
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private ObservableCollection<keep> itemsFromDb;

        public HomePage()
        {
            InitializeComponent();
            itemsFromDb = new ObservableCollection<keep>(App.Data.GetItemsNotDoneAsync().Result);
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");

            Debug.WriteLine(itemsFromDb.Count);
            foreach (keep todoItem in itemsFromDb)
            {
                Debug.WriteLine(todoItem);
            }

            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");

            listview.ItemsSource = itemsFromDb;
        }

        void Handle_Clicked (object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new XamarinApp_Keep.WritePage());
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new XamarinApp_Keep.Categories());
        }
    }
}
