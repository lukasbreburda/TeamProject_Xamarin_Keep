using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp_Keep
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<pin_password> itemsFromDb;
        ObservableCollection<text_password> itemsFromDb2;
        int type_pass;
        string password;
        string data_pass;
        public MainPage()
        {
            InitializeComponent();
            int users = App.Data.back_users().Result.Count;
            cun.Text = users.ToString();
        }
        private void SelectedIndexChanged(object sensder, EventArgs e)
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            type_pass = pass.SelectedIndex;
            password = passwordEntry.Text;
            if (type_pass == 0)
            {
                int pin_pass = App.Data.login_back_pin().Result.Count;
                if (pin_pass != 0)
                {
                    itemsFromDb = new ObservableCollection<pin_password>(App.Data.login_back_pin().Result);
                    data_pass = itemsFromDb[0].password.ToString();


                    if (data_pass == password)
                    {
                        Navigation.PushAsync(new XamarinApp_Keep.HomePage());
                    }
                    else
                    {
                        cun.Text = "Pin není zadán správně !";
                        passwordEntry.Text = "";
                    }
                }
                else
                {
                    cun.Text = "Pro uživatele nexistuje PIN";
                    passwordEntry.Text = "";
                }

                
            }
            else if (type_pass == 1)
            {
                int text_pass = App.Data.login_back_text().Result.Count;
                if (text_pass != 0) {
                    itemsFromDb2 = new ObservableCollection<text_password>(App.Data.login_back_text().Result);
                    data_pass = itemsFromDb2[0].password;

                    if (data_pass == password)
                    {
                        Navigation.PushAsync(new XamarinApp_Keep.HomePage());
                    }
                    else
                    {
                        cun.Text = "Heslo není zadáné správně !";
                        passwordEntry.Text = "";
                    }
                }else
                {
                    cun.Text = "pro uživatele nexistuje textové heslo";
                    passwordEntry.Text = "";
                }
                
                    }
            else
            {

            }

        }
    }
    }
