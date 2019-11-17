using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ERP
{
    public partial class Content : ContentView
    {
        public Content()
        {
            InitializeComponent();
        }
        protected void ShowPopUp(object o, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new Content());
        }
    }
}
