using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodJob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			InitializeComponent ();
            var assembly = typeof(FirstPage);
            backgroundImage.Source = ImageSource.FromResource("GoodJob.Assets.Images.careers.jpg", assembly);

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void User_button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());

        }

        private void Guest_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MasterPage());
        }
    }
}