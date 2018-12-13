using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodJob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage : ContentPage
	{
		public SignUpPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Next_Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username_Entry.Text) || string.IsNullOrEmpty(Password_Entry.Text) || string.IsNullOrEmpty(Email_Entry.Text))
            {
                DisplayAlert("Empty Entries!", "Please Fill All The Entries!", "OK");
            }
            else
            {
                Navigation.PushAsync(new SignUpPage2());
            }
        }
    }
}