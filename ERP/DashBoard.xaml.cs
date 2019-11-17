using System;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ERP
{
    public partial class DashBoard : ContentPage
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        protected void ImageTapped(object sender, EventArgs e)
        {
            Image image = ((Image)sender);
            image.Opacity = .5;
            image.Opacity = 1;
        }

        private void ShowPopUp(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new Popup());
        }


        
    }
}
