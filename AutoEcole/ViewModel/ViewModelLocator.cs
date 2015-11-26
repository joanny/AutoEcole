using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using AutoEcole.Model.Interface;
using AutoEcole.AppData;
using AutoEcole.Model.Service;

namespace AutoEcole.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
                SimpleIoc.Default.Register<IService<Eleve>, DesignDataServiceEleve>();
            }
            else
            {
                // Create run time view services and models
                SimpleIoc.Default.Register<IService<Eleve>, ServiceEleve>();
            }

            SimpleIoc.Default.Register<AccueilViewModel>();
            SimpleIoc.Default.Register<GestionEleveViewModel>();
        }


        public AccueilViewModel VMAccueil 
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AccueilViewModel>();
            }
        }

        public GestionEleveViewModel VMlistEleve
        {
            get
            {
                return ServiceLocator.Current.GetInstance<GestionEleveViewModel>();
            }
        }
        
        public static void Cleanup()
        {
        }
    }
}