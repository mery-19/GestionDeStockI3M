using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FournisseurServiceWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FournisseurServiceWCF.svc or FournisseurServiceWCF.svc.cs at the Solution Explorer and start debugging.
    public class FournisseurServiceWCF : IFournisseurServiceWCF
    {
        GestionDeStockEntities db = new GestionDeStockEntities();

        public void add(Fournisseur f)
        {
            db.Fournisseur.Add(f);
            db.SaveChanges();
            
        }

        public List<Fournisseur> findAll()
        {
            return db.Fournisseur.ToList();
        }

        public Fournisseur find(int id)
        {
            Fournisseur fo = db.Fournisseur.Where(f => f.id_fournisseur == id ).First();
            return fo;
        }

        public string findName(int id)
        {
            Fournisseur fo = db.Fournisseur.Where(f => f.id_fournisseur == id).First();
            return fo.nom;
        }

        public void delete(int id)
        {
            var v = (from fo in db.Fournisseur where fo.id_fournisseur == id select fo).First();

            db.Fournisseur.Remove(v);
            db.SaveChanges();
        }

        public void modifier(Fournisseur f)
        {
            var c = (from four in db.Fournisseur where four.id_fournisseur == f.id_fournisseur select four).First();
            c.nom = f.nom;
            c.adresse = f.adresse;
            c.phone = f.phone;
            c.email = f.email;
            db.SaveChanges();
        }

        public List<Fournisseur> findNom(string n)
        {
            return db.Fournisseur.Where(f => f.nom == n).ToList();
        }

        public List<Fournisseur> findbyId(int id)
        {
            return db.Fournisseur.Where(f => f.id_fournisseur == id).ToList();
        }
    }
}
