using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProduitServiceWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProduitServiceWCF.svc or ProduitServiceWCF.svc.cs at the Solution Explorer and start debugging.
    public class ProduitServiceWCF : IProduitServiceWCF
    {
        GestionDeStockEntities db = new GestionDeStockEntities();

        public void add(Produit p)
        {
            db.Produit.Add(p);
            db.SaveChanges();
        }

        public Produit find(int id)
        {
            return db.Produit.Where(x => x.id_produit == id).First();
        }

        public List<Produit> findAll()
        {
            return db.Produit.ToList<Produit>();
        }

        public List<Produit> findByFournisseur(int id_fourn)
        {
            //les produit disponible d'u fournisseur
            return db.Produit.Where(p => p.id_fournisseur == id_fourn && p.date_expiration > DateTime.Now).ToList();
        }

        public int updateQuantite(int id_commande)
        {
            try
            {
                List<LigneCommande> ligneCommandes = db.LigneCommande.Where(x => x.id_commande == id_commande).ToList();
                foreach (LigneCommande l in ligneCommandes)
                {
                    var i = db.Database.SqlQuery<int>("SELECT quantite FROM Produit WHERE id_produit = " + l.id_produit).First();
                    i = i + (int)l.quantite;

                    int res = db.Database.ExecuteSqlCommand("UPDATE Produit set quantite = " + i +
                        " WHERE id_produit = " + l.id_produit);
                    return res;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        public List<Fournisseur> findAllFournisseur()
        {
            return db.Fournisseur.ToList<Fournisseur>();
        }

        public Fournisseur findFournisseurByName(string nom)
        {
            return db.Fournisseur.Single(f => f.nom == nom);
        }


        public List<Produit> findAvaibleProducts()
        {
            return db.Produit.Where(p => p.date_expiration > DateTime.Now && p.quantite != 0).ToList<Produit>();

        }

        public List<Produit> findProductsNotAvaible()
        {
            return db.Produit.Where(p => p.date_expiration > DateTime.Now && p.quantite == 0).ToList<Produit>();
        }

        public List<Produit> findDestockedProduts()
        {
            return db.Produit.Where(p => p.date_expiration < DateTime.Now && p.quantite != 0).ToList<Produit>();
        }

        public List<Produit> findProductsByName(string nom)
        {
            return db.Produit.Where(p => p.nom.Contains(nom)).ToList();
        }

        public void delete(int id)
        {
            Produit p = db.Produit.Single(pr => pr.id_produit == id);
            var entry = db.Entry(p);
            if (entry.State == System.Data.Entity.EntityState.Detached)
                db.Produit.Attach(p);
            db.Produit.Remove(p);
            db.SaveChanges();
        }

        public Fournisseur findProductsById(int id)
        {
            return db.Fournisseur.Single(f => f.id_fournisseur == id);
        }

        public void edit(Produit p)
        {
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        
    }
}
