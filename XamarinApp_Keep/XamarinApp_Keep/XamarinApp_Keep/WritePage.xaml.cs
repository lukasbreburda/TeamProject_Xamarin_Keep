using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp_Keep
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WritePage : ContentPage
    {
        ObservableCollection<category> id_kate;
        string kate_text;
        string keep_text;
        public WritePage()
        {
            InitializeComponent();
            var itemsFromDbs = App.Data.showKategory().Result;
            foreach (category todoItem in itemsFromDbs)
            {

                categories_picker.Items.Add(todoItem.name);

            }
        }

        void columnPicker_SelectedIndexChanged(object sensder, EventArgs e)
        {
           
            int selectedIndex = categories_picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                kate_text = categories_picker.Items[selectedIndex];
            }
        }

        private void new_keep(object sender, EventArgs e)
        {
            keep_text = keeps.Text;
            reg();
            Navigation.PushAsync(new XamarinApp_Keep.MasterPage());
        }

        private void reg()
        {

            id_kate = new ObservableCollection<category>(App.Data.GeTItemIDK(kate_text).Result);
            int kategorie_IDD = id_kate[0].ID;

            keep item = new keep();
            item.text = keep_text;
            item.time = 25684;
            item.kategory = kategorie_IDD;
             
           
            App.Data.SaveKeep(item);
        }
    }
}
