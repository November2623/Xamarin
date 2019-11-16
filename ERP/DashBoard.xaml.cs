using System;
using System.Collections.Generic;

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
    }
}
