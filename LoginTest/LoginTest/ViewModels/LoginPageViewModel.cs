using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginTest.ViewModels
{
    
    public class LoginPageViewModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public ICommand SubmitCommand { protected set; get; }

        public LoginPageViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                
            }
            else if (string.IsNullOrEmpty(Password))
            {
                
            }
            else
            {
                
            }
        }
    }
}
