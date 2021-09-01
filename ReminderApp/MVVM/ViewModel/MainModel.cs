using ReminderApp.Core;
using ReminderApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderApp.MVVM.ViewModel
{
    class MainModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */
        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }


        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }


        public MainModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";
            });

            Messages.Add(new MessageModel
            {
                Username = "Adam",
                UsernameColour = "#409aff",
                ImageSource = "https://image.flaticon.com/icons/png/512/147/147144.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            }); ;

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Adam",
                    UsernameColour = "#409aff",
                    ImageSource = "https://image.flaticon.com/icons/png/512/147/147144.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                }); ;
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Trevor",
                    UsernameColour = "#409aff",
                    ImageSource = "https://image.flaticon.com/icons/png/512/194/194938.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true
                }); ;
            }

            Messages.Add(new MessageModel
            {
                Username = "Trevor",
                UsernameColour = "#409aff",
                ImageSource = "https://image.flaticon.com/icons/png/512/194/194938.png",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true
            }); ;

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Adam {i}",
                    ImageSource = "https://image.flaticon.com/icons/png/512/147/147144.png",
                    Messages = Messages
                });
            }
        }
    }
}
