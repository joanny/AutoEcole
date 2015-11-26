using AutoEcole.AppData;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AutoEcole.Model.Interface
{
    /// <summary>
    /// CREATE , UPDATE , DELETE INTERFACE
    /// </summary>
    public interface IService<T>
    {
         void Create(T type);
         void Update(T type);
         ObservableCollection<Eleve> Select();
         void Delete(T type);
    }
}
