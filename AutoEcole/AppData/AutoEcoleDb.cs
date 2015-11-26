using AutoEcole.AppData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;

public class AutoEcoleContext : DbContext
{
    public AutoEcoleContext()
        : base("AutoEcoleEntities")
    {

    }
    public DbSet<Eleve> lesEleves { get; set; }
    public DbSet<Lecon> lesLecons { get; set; }
    public DbSet<Vehicule> lesVehicules { get; set; }
}


public interface IDal : IDisposable
{
    ObservableCollection<Eleve> getEleves();
    ObservableCollection<Vehicule> getVehicules();
    ObservableCollection<Lecon> getLecons();
}
public class Dal : IDal
{
    public AutoEcoleContext dbAutoEcole;

    public Dal()
    {
        this.dbAutoEcole = new AutoEcoleContext();
    }



    public void Dispose()
    {
        this.dbAutoEcole.Dispose();
    }


    #region Select
    public ObservableCollection<Eleve> getEleves()
    {
        ObservableCollection<Eleve> lst = new ObservableCollection<Eleve>();

        foreach (Eleve e in this.dbAutoEcole.lesEleves)
        {
            lst.Add(e);
        }
        return lst;
    }

    public ObservableCollection<Vehicule> getVehicules()
    {
        ObservableCollection<Vehicule> lst = new ObservableCollection<Vehicule>();

        foreach (Vehicule e in this.dbAutoEcole.lesVehicules)
        {
            lst.Add(e);
        }
        return lst;
    }

    public ObservableCollection<Lecon> getLecons()
    {
        ObservableCollection<Lecon> lst = new ObservableCollection<Lecon>();

        foreach (Lecon e in this.dbAutoEcole.lesLecons)
        {
            lst.Add(e);
        }
        return lst;
    }
    #endregion

    #region Create
    public void CreateEleve(Eleve unEleve)
    {
        this.dbAutoEcole.lesEleves.Add(unEleve);
        End();
    }

    public void CreateLecon(Lecon unLecon)
    {
        this.dbAutoEcole.lesLecons.Add(unLecon);
        End();
    }

    public void CreateVehicule(Vehicule unVehicule)
    {
        this.dbAutoEcole.lesVehicules.Add(unVehicule);
        End();
    }
    #endregion

    #region Delete
    public void DeleteEleve(Eleve unEleve)
    {
        this.dbAutoEcole.lesEleves.Remove(unEleve);
        End(); 
    }

    public void DeleteLecon(Lecon unLecon)
    {
        this.dbAutoEcole.lesLecons.Remove(unLecon);
        End();
    }

    public void DeleteVehicule(Vehicule unVehicule)
    {
        this.dbAutoEcole.lesVehicules.Remove(unVehicule);
        End();
    }
    #endregion

    #region Update
    public void UpdateEleve(Eleve unEleve)
    {
        dbAutoEcole.lesEleves.Attach(unEleve);
        dbAutoEcole.Entry(unEleve).State = EntityState.Modified;
        dbAutoEcole.SaveChanges();

    }

    #endregion

    private void End()
    {
        this.dbAutoEcole.SaveChanges();
    }
}