using System;
using System.Collections.Generic;
using ERP.Data;
using ERP.Model;
using Xamarin.Forms;

namespace ERP
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        public void LoginEvent(object sender, EventArgs e)
        {
            IEnumerable<Account> A = App.Database.GetItems();
            App.Database.InsertAccount("User98", "123456");
            Boolean check = App.Database.Login(username.Text, password.Text);
            if (check)
            {
                Application.Current.MainPage = new WorkSpace();
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("ERROR!", "Username or Password is wrong!", "Cancel");
            }
        }
    }
}
