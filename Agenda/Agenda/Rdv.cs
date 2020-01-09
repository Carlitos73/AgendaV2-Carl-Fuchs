using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
   
        public class Rdv : INotifyPropertyChanged
        {
        private string leprenomPraticien;
        private string lenomPraticien;
        private string lenomCollaborateur;
        private string leprenomCollaborateur;
        private string leJour;
        private string lHoraire;
        private DateTime laDate;





        public Rdv()
            {

            }
        
            public event PropertyChangedEventHandler PropertyChanged;
        public string prenomPraticien
        {
            get { return leprenomPraticien; }
            set
            {
                leprenomPraticien = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(leprenomPraticien));
            }
        }
        public string nomPraticien
            {
                get { return lenomPraticien; }
                set
                {
                lenomPraticien = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs(lenomPraticien));
                }
            }
        public string prenomCollaborateur
        {
            get { return leprenomCollaborateur ; }
            set
            {
                leprenomCollaborateur = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(leprenomCollaborateur));
            }
        }
        public string nomCollaborateur
        {
            get { return lenomCollaborateur; }
            set
            {
                lenomCollaborateur = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(lenomCollaborateur));
            }
        }
        public string Jour
            {
                get { return leJour; }
                set
                {
                leJour = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs(leJour));
                }
            }
        public string Horaire
        {
            get { return lHoraire; }
            set
            {
                lHoraire = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(lHoraire));
            }
        }
        public DateTime Date
        {
            get { return laDate; }
            set
            {
                laDate = value;
                
            }
        }




    }
    
}
