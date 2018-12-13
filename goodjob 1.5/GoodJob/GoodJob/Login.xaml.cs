using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodJob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            var assembly = typeof(Login);
            backgroundImage.Source = ImageSource.FromResource("GoodJob.Assets.Images.careers.jpg", assembly);
        }

     
        
        private void Forgot_Password_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Login_Button_Clicked(object sender, EventArgs e)
        {

        }


        private void SIGN_UP_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        
    }
}