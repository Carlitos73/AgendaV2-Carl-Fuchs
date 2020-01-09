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
    public partial class GestionContact : PhoneApplicationPage
    {

        public ListeContacts listeContact;
        private ObservableCollection<Contact> mesContacts = new ObservableCollection<Contact>();
        public GestionContact()
        {
            InitializeComponent();
           


            using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (store.FileExists("Agenda/contact.xml"))
                {
                    using (IsolatedStorageFileStream fileStream = store.OpenFile("Agenda/contact.xml", System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ListeContacts));
                        listeContact = serializer.Deserialize(fileStream) as ListeContacts;

                    }



                }
                else
                {
                    listeContact = new ListeContacts();
                }
            }

         
            AffichageCollections();
        }
     
        public void AffichageCollections()
        {
            mesContacts.Clear();
            foreach (var unContact in listeContact.Items)
            {
                mesContacts.Add(unContact);
            }

            listcontact.ItemsSource = mesContacts;
        }

        public void TrieCollections()
        {
           
            mesContacts.Clear();
            listeContact.Items.Sort(Contact.CompareParNomPrenom);
            foreach (var unContact in listeContact.Items)
            {
                mesContacts.Add(unContact);
            }
         
            listcontact.ItemsSource = mesContacts;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PageVoirContact.xaml", UriKind.Relative));
        }

        private void btnAjouterContact_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/PageAjouterContact.xaml", UriKind.Relative));
            if (this.AddContactPanel.Visibility == System.Windows.Visibility.Collapsed)
            {
                this.AddContactPanel.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                this.AddContactPanel.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            AffichageCollections();
            this.AddContactPanel.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            AffichageCollections();
            listeContact.Items.Add(new Contact { Nom = Nom.Text.ToString(), Prenom = Prenom.Text.ToString(), Email = Email.Text.ToString(), Mobile = Mobile.Text.ToString() });
            listeContact.Sauvegarder();
            
            Nom.Text = "";
            Prenom.Text = "";
            Email.Text = "";
            Mobile.Text = "";
        }

        private void btnTrierContact_Click(object sender, RoutedEventArgs e)
        {
            TrieCollections();
        }
    }
}