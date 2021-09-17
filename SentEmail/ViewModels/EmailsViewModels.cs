using System;
using System.Collections.Generic;
using System.Text;
using SentEmail.forms;
using System.Windows.Input;
using SentEmail.ViewModels;
using SentEmail.Models;
using System.Collections.Objectmodel;

namespace SentEmail.ViewModels
{
    class AddUserViewModel
    {

        public ICommand RegisterCommand { get; }
        public string To { get; set; }
        public string Subject { get; set; }
        public ObservableCollection<Email> Emails { get; }
        public AddUserViewModel(ObservableCollection<Contact>EmailList)
        {
            Emails = EmailList;
            RegisterCommand = new Command(OnRegister);
        }
        private async void OnRegister()
        {
            Contacts.Add(new Email(To, Subject));
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}

