using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;

namespace Agenda
{
    public partial class PageVoirContact : PhoneApplicationPage
    {
        public ListeContacts listecontact;
        private ObservableCollection<Contact> mesContacts = new ObservableCollection<Contact>();
        
        public PageVoirContact()
        {
            InitializeComponent();
           
         


            using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (store.FileExists("Agenda/contact.xml"))
                {
                    using (IsolatedStorageFileStream fileStream = store.OpenFile("Agenda/contact.xml", System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ListeContacts));
                        listecontact = serializer.Deserialize(fileStream) as ListeContacts;

                    }
                    
                   
                    
                }
                else
                {
                listecontact = new ListeContacts();
                
                }
            }

            foreach (var unContact in listecontact.Items)
            {
                mesContacts.Add(unContact);
            }

            listcontact.ItemsSource = mesContacts;
        }
    }
}