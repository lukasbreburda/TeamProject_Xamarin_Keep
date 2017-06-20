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
    public partial class MasterPage : MasterDetailPage
    {
        private ObservableCollection<category> itemsFromDb;
        public MasterPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;

            itemsFromDb = new ObservableCollection<category>(App.Data.showKategory().Result);
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");

            Debug.WriteLine(itemsFromDb.Count);
            foreach (category todoItem in itemsFromDb)
            {
                Debug.WriteLine(todoItem);
            }

            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");
            Debug.WriteLine("                             ");

            listview.ItemsSource = itemsFromDb;

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Categories());
            IsPresented = false;
        }
        /*  public void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
          {
              if (listview.SelectedItems.Count > 0)
              {

                  category todoItem = (category)ListView.SelectedItems[0];
                  // MainWindow.todo = todoItem;
                  id_cole = itemsFromDb.IndexOf(todoItem);
                  prechod = 1;
                  MainWindow.framePublic.Navigate(new nove(todoItem));

                  //  MainWindow.framePublic.Source = new Uri("pages/news.xaml", UriKind.Relative); //změna source Page


              }

          }*/
    }
}
