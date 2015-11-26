using AutoEcole.AppData;
using AutoEcole.Model.Service;
using AutoEcole.ViewModel.GeniqueVM;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Navigation;

namespace AutoEcole.ViewModel
{
    public class AccueilViewModel : GeneriqueViewModel
    {
        #region commandes
        public RelayCommand ShowLecon;
        public RelayCommand ShowEleve;
        public RelayCommand ShowVehicule;
        #endregion

        #region listEleves
        private ObservableCollection<Eleve> les_eleves;

        public ObservableCollection<Eleve> LesEleves
        {
            get { return this.les_eleves; }
            set { NotifyPropertyChanged(ref les_eleves, value); }
        }


        #endregion

        public AccueilViewModel()
        {
            this.les_eleves = new ServiceEleve().Select();
            ShowEleve  = new RelayCommand(AfficherGestionEleve);
            ShowLecon = new RelayCommand(AfficherGestionLecon);
            ShowVehicule = new RelayCommand(AfficherGestionVehicule);
        }

        #region Actions
        public void AfficherGestionEleve()
        {
         
        }

        public void AfficherGestionLecon()
        {
             
        }

        public void AfficherGestionVehicule()
        {

        }
        #endregion
    }
}
