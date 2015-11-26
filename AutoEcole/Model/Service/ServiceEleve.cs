using AutoEcole.Model.Interface;
using AutoEcole.AppData;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AutoEcole.Model.Service
{
    public class ServiceEleve : IService<Eleve>
    {
        public Dal _db;

        public ServiceEleve()
        {
            this._db = new Dal();
        }
        
        public void Create(Eleve eleve)
        {
            
        }

        public void Update(Eleve type)
        {
            this._db.UpdateEleve(type);
        }

        public ObservableCollection<Eleve> Select()
        {
            return this._db.getEleves();
        }

        public void Delete(Eleve type)
        {
            throw new System.NotImplementedException();
        }


    }
}
