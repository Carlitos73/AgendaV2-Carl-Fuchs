using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 


namespace Agenda
{
   public  class Contact : INotifyPropertyChanged
    {
        private string leNom;
        private string lePrenom;
        private string leMail;
        private string leMobile;

  

        public Contact()
        {
         
        }
        //public Contact(string unNom,string unPrenom,string unMail,string unMobile)
        //{
        //    leNom = unNom;
        //    lePrenom = unPrenom;
        //    leMail = unMail;
        //    leMobile = unMobile;
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        public string Nom{
            get{ return leNom;}
            set{
                leNom = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(leNom));
            }
        }
        public string Prenom
        {
            get { return lePrenom; }
            set
            {
                lePrenom = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(lePrenom));
            }
        }
        public string Email
        {
            get { return leMail; }
            set
            {
                leMail = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(leMail));
            }
        }
        public string Mobile
        {
            get { return leMobile; }
            set
            {
                leMobile = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(leMobile));
            }
        }

        public static int CompareParNomPrenom(Contact x, Contact y)
        {
            if ((String.Compare(x.leNom,y.leNom)) < 0) // contact x precede contact y
            {
                return -1;
            }
            else if((String.Compare(x.leNom, y.leNom)) == 0)
            {
                if((String.Compare(x.lePrenom, y.lePrenom)) < 0)
                {
                    return -1;
                }
                else if((String.Compare(x.lePrenom, y.lePrenom)) > 0)
                {
                    return 1;
                }
                else if((String.Compare(x.lePrenom, y.lePrenom)) == 0)
                {
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
            else if((String.Compare(x.leNom, y.leNom)) > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        
    }
}
