﻿#pragma checksum "C:\Users\FUCHS\Desktop\Agenda\Agenda\Agenda\GestionContact.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9DB95D0CE16EC2D9938F15F562CFB442"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Agenda {
    
    
    public partial class GestionContact : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ListBox listcontact;
        
        internal System.Windows.Controls.Border AddContactPanel;
        
        internal System.Windows.Controls.Grid ContentPanel2;
        
        internal System.Windows.Controls.Grid grid1;
        
        internal System.Windows.Controls.TextBox Nom;
        
        internal System.Windows.Controls.TextBox Prenom;
        
        internal System.Windows.Controls.TextBox Email;
        
        internal System.Windows.Controls.TextBox Mobile;
        
        internal System.Windows.Controls.Button btnEnregistrer;
        
        internal System.Windows.Controls.Button btnAnnuler;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btnAjouterContact;
        
        internal System.Windows.Controls.Button btnTrierContact;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Agenda;component/GestionContact.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.listcontact = ((System.Windows.Controls.ListBox)(this.FindName("listcontact")));
            this.AddContactPanel = ((System.Windows.Controls.Border)(this.FindName("AddContactPanel")));
            this.ContentPanel2 = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel2")));
            this.grid1 = ((System.Windows.Controls.Grid)(this.FindName("grid1")));
            this.Nom = ((System.Windows.Controls.TextBox)(this.FindName("Nom")));
            this.Prenom = ((System.Windows.Controls.TextBox)(this.FindName("Prenom")));
            this.Email = ((System.Windows.Controls.TextBox)(this.FindName("Email")));
            this.Mobile = ((System.Windows.Controls.TextBox)(this.FindName("Mobile")));
            this.btnEnregistrer = ((System.Windows.Controls.Button)(this.FindName("btnEnregistrer")));
            this.btnAnnuler = ((System.Windows.Controls.Button)(this.FindName("btnAnnuler")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnAjouterContact = ((System.Windows.Controls.Button)(this.FindName("btnAjouterContact")));
            this.btnTrierContact = ((System.Windows.Controls.Button)(this.FindName("btnTrierContact")));
        }
    }
}

