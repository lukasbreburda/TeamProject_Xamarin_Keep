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
    public partial class FirstPage : ContentPage
    {
        string email = ""; //Smety doplníš vstup
        int type_pass = 0; //smety doplníš vstup
        public FirstPage()
        {
            InitializeComponent();

        }
        private void register()
        {
            user item = new user();
            item.ID = 1;
            item.email = email;
            item.type_pasword = type_pass;
            App.Data.SaveUser(item);
            int bla = 1;

               if (type_pass == 1) {
                pin_password pass = new pin_password();
                pass.ID = 1;
                pass.id_user = 1;
                pass.password = //smety doplní input
                App.Data.SavePinPass(pass).Result;

               }else{
                text_password pass = new text_password();
                pass.ID = 1;
                pass.id_user = 1;
                pass.password = //smety doplní input
                App.Data.SaveTextPass(pass).Result;
               }

                
        }
    }
}
