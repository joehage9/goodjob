
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace GoodJob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignUpPage2 : ContentPage
	{
		public SignUpPage2 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        private void Register_Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstName_Entry.Text) || string.IsNullOrEmpty(LastName_Entry.Text))
            {
                DisplayAlert("Empty Entries!", "Please Fill All The Entries!", "OK");

            }
            else
            {
                try
                {
                  
                }
                catch
                {

                }
                finally
                {
                    
                }
               
            }
        }
    }
}