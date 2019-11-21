using System;
using System.Collections.Generic;
using ERP.Model;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERP
{
    public partial class Popup : PopupPage
    {
        public Popup()
        {
            InitializeComponent();
        }

        protected void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }

        protected void OnSave(object sender, EventArgs e)
        {
            App.databaseTask.InsertTask("#Issue01", "Fix Bug");
            IEnumerable<Task> tasks = App.databaseTask.GetItems();
            PopupNavigation.Instance.PopAsync();
        }
    }
}
