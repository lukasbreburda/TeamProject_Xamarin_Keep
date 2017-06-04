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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
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
