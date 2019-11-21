using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ERP.Model;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ERP
{
    public partial class DashBoard : INotifyPropertyChanged
    {
        IEnumerable<Task> tasks = App.databaseTask.GetItems();
        public event PropertyChangedEventHandler propertyChanged;
        public IEnumerable<Task> Tasks
        {
            set
            {
                tasks = App.databaseTask.GetItems();
                PropertyChangedEventHandler handler = propertyChanged;
                if(handler != null)
                {
                    handler(this, new PropertyChangedEventArgs("tasks"));
                }
            }
            get
            {
                return tasks;
            }
        }

        public DashBoard()
        {
            InitializeComponent();
            List<string> tasks = new List<string>
            {
                "#Task-01: Create Java Core",
                "#Issue-01: Fix bug Login Deadline: 1/1/2020",
                "#Meeting: [3:PM] Something about project",
                "#Task-02: Create API for products.",
                "#Task-09: Create Java Core",
                "#Issue-03: Fix bug Logout Deadline: 1/1/2020",
                "#Meeting: [3:PM] Something about project",
                "#Task-07: Create API for products.",

            };
            
            //this.tasks = App.databaseTask.GetItems();
            BindingContext = tasks;

        }
        protected void ImageTapped(object sender, EventArgs e)
        {
            Image image = ((Image)sender);
            image.Opacity = .5;
            image.Opacity = 1;
        }

        private  void ShowPopUp(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new Popup());
        }

    }
}
