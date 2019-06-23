using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init() {
            BackgroundColor = Constants.BackGroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            loginicon.HeightRequest = Constants.LogInIconHeight;
            App.StartCheckIfInternet(lbl_NoInternet, this); 

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e); 
        }
        async void SignInProcedure(object sender, EventArgs e) {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation()) {
                DisplayAlert("Login", "Login Success.", "Ok");
                var result = await App.RestService.Login(user);
                if (result.access_token != null)
                {
                    App.UserDatabase.SaveUser(user);
                }

            }
            else {
                DisplayAlert("Login", "Login Not Correct, empty username or password", "Ok");
            }

        }

    }
}