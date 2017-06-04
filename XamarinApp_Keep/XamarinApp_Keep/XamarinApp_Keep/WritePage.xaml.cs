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
    public partial class WritePage : ContentPage
    {
        string keep_text;
        public WritePage()
        {
            InitializeComponent();
        }

        void columnPicker_SelectedIndexChanged(object sensder, EventArgs e)
        {

        }

        private void new_keep(object sender, EventArgs e)
        {
            keep_text = keeps.Text;
            reg();
            Navigation.PushAsync(new XamarinApp_Keep.MasterPage());
        }
        private void reg()
        {
            keep item = new keep();
            item.text = keep_text;
            item.time = 25684;
            item.kategory = 1;
           
            App.Data.SaveKeep(item);
        }
    }
}
