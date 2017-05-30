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
        string email;
        int type_pass;
        string password;
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

               if (type_pass == 0) {
                pin_password pass = new pin_password();
                pass.ID = 1;
                pass.id_user = 1;
                pass.password = Int32.Parse(password);
                App.Data.SavePinPass(pass);

               }else{
                text_password pass = new text_password();
                pass.ID = 1;
                pass.id_user = 1;
                pass.password = password;
                App.Data.SaveTextPass(pass);
               }

                
        }
        private void columnPicker_SelectedIndexChanged(object sensder, EventArgs e)
        {
            type_pass = pass.SelectedIndex;
            if (type_pass == 0)
            {
                passwordEntry.Keyboard = Keyboard.Numeric;
            }
            else if (type_pass == 1)
            {
                passwordEntry.Keyboard = Keyboard.Text;
            }
            else
            {
                passwordEntry.Keyboard = Keyboard.Default;
            }
        }

        private void reg_fn(object sender, EventArgs e)
        {
            email = emailEntry.Text;
            password = passwordEntry.Text;
            type_pass = pass.SelectedIndex;            
            register();
            Navigation.PushAsync(new XamarinApp_Keep.MainPage());

        }
    }
}
