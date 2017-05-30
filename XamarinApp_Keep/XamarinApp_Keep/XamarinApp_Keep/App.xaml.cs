using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinApp_Keep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            int users = Data.back_users().Result.Count;
            if(users == 0)
            {
                MainPage =new NavigationPage(new XamarinApp_Keep.FirstPage());
            }else
            {
                MainPage =new NavigationPage(new XamarinApp_Keep.MainPage());
            }
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        private static Database _data;

        public static Database Data
        {
            get
            {
                if (_data == null)
                {
                    _data = new Database(DependencyService.Get<IFileHelper>().GetLocalFilePath("keep.db3"));
                    
                }
                return _data;
            }
        }
    }
}
