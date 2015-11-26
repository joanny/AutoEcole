using AutoEcole.AppData;
using AutoEcole.Model.Interface;
using AutoEcole.Model.Service;
using AutoEcole.ViewModel.GeniqueVM;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AutoEcole.ViewModel
{
    public class GestionEleveViewModel : ObservableCollection<Eleve>
    {

        public IService<Eleve> Service { get; set; }

        public ObservableCollection<Eleve> lesEleves;
        public ObservableCollection<Eleve> LesEleves { get; set; }


        private int id;

        public int Id
        { get; set; }

        public string nom;

        public string Nom
        { get; set; }
        public string prenom;

        public string Prenom
        { get; set; }

        public int creditHoraire;

        public int CreditHoraire
        { get; set; }

        public ICommand SelectionElementCommand { get; set; }

        public ICommand ValidForm { get; set; }

        public GestionEleveViewModel(IService<Eleve> unService)
        {
            Service = unService;
            lesEleves = Service.Select();
            SelectionElementCommand = new RelayCommand<SelectionChangedEventArgs>(OnSelectionElement);
            ValidForm = new RelayCommand<Eleve>(ValiderFormulaire, CanExecuteValidForm);
            Add(Service.Select().First());
        }


        private bool CanExecuteValidForm(Eleve arg)
        {
            return true;
        }

        private void ValiderFormulaire(Eleve obj)
        {
            ServiceEleve sc = new ServiceEleve();
            sc.Update(new Eleve() { Id = Id, Nom = Nom, Prenom = Prenom, CreditHoraire = CreditHoraire }); lesEleves = Service.Select();
        }

        private void OnSelectionElement(SelectionChangedEventArgs obj)
        {
            Eleve SelectedEleve = (Eleve)obj.AddedItems[0];
            Id = SelectedEleve.Id;
            Nom = SelectedEleve.Nom;
            Prenom = SelectedEleve.Prenom;
            CreditHoraire = Convert.ToInt32(SelectedEleve.CreditHoraire);
        }
    }
}
