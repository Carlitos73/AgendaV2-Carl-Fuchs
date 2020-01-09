using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Data.Services.Client;
using Agenda.FuchsEntities;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Agenda
{
    public partial class ConsultationRDV : PhoneApplicationPage
    {
        private FUCHSEntities _context;
        private DataServiceCollection<VueRDV> vuerdv;
        //public List<Rdv> lesRdv = new List<Rdv>();
        private ObservableCollection<Rdv> lesRdv = new ObservableCollection<Rdv>();
        private ObservableCollection<Rdv> _jour1 = new ObservableCollection<Rdv>();
        public ObservableCollection<Rdv> _Jour1
        { get { return _jour1; } } 
        private ObservableCollection<Rdv> _jour2 = new ObservableCollection<Rdv>();
        public ObservableCollection<Rdv> _Jour2
        { get { return _jour2; } }
        private ObservableCollection<Rdv> _jour3 = new ObservableCollection<Rdv>();
        public ObservableCollection<Rdv> _Jour3
        { get { return _jour3; } }
        private ObservableCollection<Rdv> _jour4 = new ObservableCollection<Rdv>();
        public ObservableCollection<Rdv> _Jour4
        { get { return _jour4; } }
        private ObservableCollection<Rdv> _jour5 = new ObservableCollection<Rdv>();
        public ObservableCollection<Rdv> _Jour5
        { get { return _jour5; } }

        private ObservableCollection<ObservableCollection<Rdv>> ListeRdv = new ObservableCollection<ObservableCollection<Rdv>>();

        private DateTime DateDebut = new DateTime(2020, 1, 7); //DateTime.Today
     


        public Collection<PanoramaItem> mesJours;
        public ConsultationRDV()
        {
        
            InitializeComponent();
            
            _context = new FUCHSEntities(new Uri("http://localhost:28898/WcfDataServiceTASSET.svc/",UriKind.Absolute));

            ////////////////lesRdv////////////////////
            vuerdv = new DataServiceCollection<VueRDV>(_context);
            vuerdv.LoadCompleted += new EventHandler<LoadCompletedEventArgs>(HandlevueRdvLoaded);
            DataServiceQuery<VueRDV> vuerdvquery = (DataServiceQuery<VueRDV>)
                 from r in _context.VueRDV
                 select r ;
            vuerdv.LoadAsync(vuerdvquery);
         
           

            
        }

        private void HandlevueRdvLoaded(object sender, LoadCompletedEventArgs e)
        {

            foreach (VueRDV unRdv in vuerdv)
            {
                Rdv r = new Rdv();
                r.Date = unRdv.dateRdv;
                r.Jour = unRdv.dateRdv.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                r.Horaire = unRdv.dateRdv.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
                r.nomPraticien = unRdv.nomPraticien.ToString();
                r.prenomPraticien = unRdv.prenomPraticien.ToString();
                r.nomCollaborateur = unRdv.nomCollaborateur.ToString();
                r.prenomCollaborateur = unRdv.prenomCollaborateur.ToString();
                lesRdv.Add(r);


            }
            ////////////////Affichage Nom jour////////////////////

           mesJours = new Collection<PanoramaItem>();
           mesJours.Add(Jour1);
            mesJours.Add(Jour2);
            mesJours.Add(Jour3);
            mesJours.Add(Jour4);
            mesJours.Add(Jour5);

            ListeRdv.Add(_Jour1);
            ListeRdv.Add(_Jour2);
            ListeRdv.Add(_Jour3);
            ListeRdv.Add(_Jour4);
            ListeRdv.Add(_Jour5);

            int i = 0;
            foreach (PanoramaItem leJour in mesJours)
            {
                var req =
               from r in lesRdv
               where r.Date.Day == DateDebut.Day &&
                r.Date.Month == DateDebut.Month && r.Date.Year == DateDebut.Year
               select r;
                leJour.Header = DateDebut.ToString("dddd", new System.Globalization.CultureInfo("fr-FR")) + " " + (DateDebut.Day).ToString();
                foreach (Rdv unRdv in req)
                {
                    ListeRdv.ElementAt(i).Add(unRdv);
                }
            
                if (DateDebut.DayOfWeek == DayOfWeek.Friday)
                {
                    DateDebut = DateDebut.AddDays(3);
                }
                else
                {
                    DateDebut = DateDebut.AddDays(1);
                }
                i++;
            }



            listeJour1.ItemsSource = _jour1;
            listeJour2.ItemsSource = _jour2;
            listeJour3.ItemsSource = _jour3;
            listeJour4.ItemsSource = _jour4;
            listeJour5.ItemsSource = _jour5;
            

        
            }
        }
}