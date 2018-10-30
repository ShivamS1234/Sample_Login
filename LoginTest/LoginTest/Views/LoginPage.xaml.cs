using LoginTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginTest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        bool isPressed = false;

        LoginPageViewModel viewModel;
		public LoginPage ()
		{
            try
            {
                InitializeComponent();
                this.BindingContext = viewModel = new LoginPageViewModel();
            }
            catch(Exception ex)
            {
                
            }
	


        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(isPressed)
            {
                btnImage.Source = "submit_button_active.png";
            }
            else
            {
                btnImage.Source = "submitButton.png";
            }
            isPressed = !isPressed; 
        }

	}
}