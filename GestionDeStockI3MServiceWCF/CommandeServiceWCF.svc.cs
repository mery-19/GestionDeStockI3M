using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CommandeServiceWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CommandeServiceWCF.svc or CommandeServiceWCF.svc.cs at the Solution Explorer and start debugging.
    public class CommandeServiceWCF : ICommandeServiceWCF
    {
        GestionDeStockEntities db = new GestionDeStockEntities();
        public int add(Commande commande)
        {
            db.Commande.Add(commande);
            db.SaveChanges();

            return commande.id_commande;
        }

        public List<Commande> commandeEnCours()
        {
            return db.Commande.Where(x => x.date_souhaite > DateTime.Now && x.confirme != true).ToList();
        }

        public List<Commande> commandeEnRetard()
        {
            return db.Commande.Where(x => x.date_souhaite < DateTime.Now && x.confirme != true).ToList();
        }

        public List<Commande> commandeConfirme()
        {
            return db.Commande.Where(x => x.confirme == true).ToList();
        }

        public decimal prixCommande(int id)
        {
            try
            {
                return (decimal)db.LigneCommande.Where(x => x.id_commande == id).Sum(x => x.prix_grossiste);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int confirmeCommande(int id)
        {
            try
            {
                Commande commande = db.Commande.Where(x => x.id_commande == id).FirstOrDefault();
                commande.date_arrive = DateTime.Now;
                commande.confirme = true;
                db.Entry(commande).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }
        }

        List<ProduitCommande> ICommandeServiceWCF.GetProduitsOfCommande(int id)
        {
            
            var v = db.Database.SqlQuery<ProduitCommande>("SELECT p.id_produit as Id_produit, p.nom as Nom, " +
                    "lc.quantite as Quantite,lc.prix_grossiste as Prix_grossiste" +
                     " FROM Produit p, LigneCommande lc " +
                     "WHERE p.id_produit = lc.id_produit and lc.id_commande = " +id ).ToList();


            return v;
        }

        public int delete(int id)
        {
            try
            {
                Commande commande = db.Commande.Where(x => x.id_commande == id).First();
                db.Commande.Remove(commande);
                return db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
    }

}
