using SentEmail.ViewModels;
using SentEmail.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SentEmail
{
    public partial class EmailPage : Xamarin.Forms.Shell
    {
        public EmailPage()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
