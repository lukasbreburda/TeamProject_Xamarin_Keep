using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp_Keep
{
    public partial class MainPage : ContentPage
    {
        int type_pass;
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

        }
    }
    }
