using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;

namespace Agenda
{
    public class ListeContacts
    {
        public List<Contact> Items { get; set; }

        public ListeContacts()
        {
            Items = new List<Contact>();
           
        }
        //public void AjouterContact(Contact unContact)
        //{
        //    Items.Add(unContact);
        //}
        public void Sauvegarder()
        {
            using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!store.DirectoryExists("Agenda"))
                {
                    store.CreateDirectory("Agenda");
                }

                /////ecrire un fichier
                using (IsolatedStorageFileStream fileStream = store.OpenFile("Agenda/contact.xml", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ListeContacts));
                    serializer.Serialize(fileStream, this);
                }
            }
        }
    }
}