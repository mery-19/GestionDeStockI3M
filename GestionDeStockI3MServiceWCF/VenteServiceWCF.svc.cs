using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VenteServiceWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VenteServiceWCF.svc or VenteServiceWCF.svc.cs at the Solution Explorer and start debugging.
    public class VenteServiceWCF : IVenteServiceWCF
    {
        GestionDeStockEntities db = new GestionDeStockEntities();
        public int add(Vente vente)
        {
            db.Vente.Add(vente);
            db.SaveChanges();

            return vente.id_vente;
        }

        public decimal QtProduit(int id_produit)
        {
            //return (decimal)db.Produit.Where(p => p.id_produit == id_produit).First().quantite;
            var q = db.Database.SqlQuery<int>("SELECT quantite FROM Produit WHERE id_produit = " + id_produit).First();
            return q;
        }
        
        public List<Vente> listeVente()
        {
            return db.Vente.ToList<Vente>();
        }

        public Vente find(int id)
        {
            return db.Vente.Where(v => v.id_vente == id).First();
        }

        public int nbVente(DateTime d)
        {
            var q=db.Vente.Where(v => v.date_ajout == d).ToList().Count();
            return q;
        }

        public void updateQuantity(int qt,int id)
        {
            /* var pr = db.Produit.Where(p => p.id_produit == id).First();
             pr.quantite = qt;*/
            db.Database.ExecuteSqlCommand("UPDATE Produit set quantite = " + qt + " WHERE id_produit = " + id);
            
        }


        
    }
}
