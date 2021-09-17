using System;
using System.Collections.Generic;
using System.Text;
using SentEmail.forms;
using Xamarin.Forms;
using SentEmail.Views;
using System.Windows.Input;
using SentEmail.Models;
using System.Collections.Objectmodel;
using System.Linq;
using Xamarin.Essentials;

namespace SentEmail.ViewModels
{
    public class HomeViewmodel
    {
        public ObservableCollection<Email> Emails { get; }
        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand MoreCommand { get; }
        public HomeViewModel()
        {
            MoreCommand = new Command<Email>(OnMore);
            AddCommand = new Command(OnAddEmail);
            DeleteCommand = new Command<Email>(OnDeleteEmail);

            Emails = new ObservableCollection<Email>
            {
            };
        }
       
    }

}
