using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp_Keep
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categories : ContentPage
    {
        string text_cat;
        public Categories()
        {
            InitializeComponent();

        }

        private void new_cat(object sender, EventArgs e)
        {
            text_cat = categoriesEntry.Text;
            register();
            Navigation.PushAsync(new XamarinApp_Keep.MasterPage());
            categoriesEntry.Text = "";
        }
        private void register()
        {
            category item = new category();
            item.name = text_cat;         
            App.Data.NewCat(item);
        }
    }
}
