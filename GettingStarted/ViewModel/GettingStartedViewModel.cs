using System;
using System.Collections.ObjectModel;
using Syncfusion.XForms.Chat;
using System.ComponentModel;

namespace GettingStarted
{
    public class GettingStartedViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Collection of messages or conversation.
        /// </summary>
        private ObservableCollection<object> messages;

        /// <summary>
        /// current user of chat.
        /// </summary>
        private Author currentUser;

        public GettingStartedViewModel()
        {
            this.messages = new ObservableCollection<object>();
            this.currentUser = new Author() { Name = "Nancy", Avatar = "People_Circle16.png" };
            this.GenerateMessages();
        }

        /// <summary>
        /// Gets or sets the group message conversation.
        /// </summary>
        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }

            set
            {
                this.messages = value;
            }
        }

        /// <summary>
        /// Gets or sets the current author.
        /// </summary>
        public Author CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            set
            {
                this.currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }

        /// <summary>
        /// Property changed handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs when property is changed.
        /// </summary>
        /// <param name="propName">changed property name</param>
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private void GenerateMessages()
        {

            this.Messages.Add(new TextMessage()
            {
                Author = null,
                Text = "Security Code Changed. Click for more info."
            });

            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "Hi.",
            });

            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Nancy", Avatar = "People_Circle2.png" },
                Text = "Hi.",
            });
            
            this.Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "How are you?",
            });

            this.Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Nancy", Avatar = "People_Circle2.png" },
                Text = "Iam fine.",
            });


        }
    }
}
