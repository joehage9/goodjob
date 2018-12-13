using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodJob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;           
          
           
        }

        private void Terms_Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TermPage());
            IsPresented = false;
        }

        private void Support_Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SupportPage());
            IsPresented = false;
        }

        private void Settings_Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SettingsPage());
            IsPresented = false;
        }

        private void Login_SignUp_Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Login());
            IsPresented = false;
        }

    }
}