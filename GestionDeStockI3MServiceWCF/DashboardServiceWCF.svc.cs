using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionDeStockI3MServiceWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "DashboardServiceWCF" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez DashboardServiceWCF.svc ou DashboardServiceWCF.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class DashboardServiceWCF : IDashboardServiceWCF
    {
        GestionDeStockEntities db = new GestionDeStockEntities();


        // calcule le gain d'un produit en endtrant son id
        public int gain(int id, DateTime d, int id_vente)
        {

            // List<Vente> vente =  db.Vente.Where(c => c.date_ajout == date).ToList();
            // var n = from v in vente select v.quantite_vendu;

            Vente pv = db.Vente.Where(c => c.id_produit == id && c.date_ajout.Value == d && c.id_vente == id_vente).First();
            Produit pr = db.Produit.Where(c => c.id_produit == id).First();

            int q = Convert.ToInt32(pv.quantite_vendu);
            int prix = Convert.ToInt32(pr.prix_vente);

            int prix_total = prix_prod(id, q);
            LigneCommande l = db.LigneCommande.Where(c => c.id_produit == id).First();

            int prix_achat = Convert.ToInt32(l.prix_grossiste / l.quantite);
            int gain = prix_total - prix_achat * q;
            return gain;
        }
      //gain month
        public int gain1(int id, int m, int i,int y)
        {
            // List<Vente> vente =  db.Vente.Where(c => c.date_ajout == date).ToList();
            // var n = from v in vente select v.quantite_vendu;

            Vente pv = db.Vente.Where(c => c.id_produit == id && c.date_ajout.Value.Month == m && c.id_vente == i && c.date_ajout.Value.Year==y).First();
            Produit pr = db.Produit.Where(c => c.id_produit == id).First();

            int q = Convert.ToInt32(pv.quantite_vendu);
            int prix = Convert.ToInt32(pr.prix_vente);

            int prix_total = prix_prod(id, q);
            LigneCommande l = db.LigneCommande.Where(c => c.id_produit == id).First();

            int prix_achat = Convert.ToInt32(l.prix_grossiste / l.quantite);
            int gain = prix_total - prix_achat * q;
            return gain;
        }

        // nombre de ventes effectués dans une date donné  !!
        public int nb_ventes(DateTime date)
        {
            List<Vente> list = db.Vente.Where(l => l.date_ajout.Value == date).ToList();
            var n = from l in list select l.id_vente;
            return Convert.ToInt32(n.Count().ToString());
        }


        // nombre de tous les ventes effectué dans une date donnee
        public int nb_ventes_total()
        {
            List<Vente> list = db.Vente.ToList();
            var n = from l in list select l.id_vente;
            int num = Convert.ToInt32(n.Count().ToString());
            return num;

        }



        // calcule le prix avec on a vendu un produit en entrant son id et la quantite 
        public int prix_prod(int id, int quantite)
        {
            Produit prod = db.Produit.Where(p => p.id_produit == id).First();
            int prix_vente = Convert.ToInt32(prod.prix_vente);
            return prix_vente * quantite;
        }

        // le gain de tous les produits vendus dans une date donnée 
        int s = 0;
        public int gain_tout(DateTime d)
        {
            List<Vente> list = db.Vente.Where(l => l.date_ajout.Value == d).ToList();
            foreach (var v in list)
            {
                Produit p = db.Produit.Where(s => s.id_produit == v.id_produit).First();
                int i = p.id_produit;
                int i2 = v.id_vente;

                s += gain(i, d, i2);
            }
            return s;
        }

        public int som = 0;
        public int perte(DateTime d)
        {

            List<Produit> list = db.Produit.Where(p => p.date_expiration < d && p.quantite != 0).ToList<Produit>();
            foreach (var item in list)
            {
                som += Convert.ToInt32(item.prix_vente);
            }
            return som;
        }

        public List<Vente> findAll()
        {
            return db.Vente.ToList();
        }

        public List<Vente> findByMounth(int m,int y)
        {
            return db.Vente.Where(d => d.date_ajout.Value.Month == m &&  d.date_ajout.Value.Year==y).ToList();

        }
        public List<Vente> findByYear(int y)
        {
            return db.Vente.Where(d => d.date_ajout.Value.Year == y).ToList();
        }
        //DateTime d = DateTime.Now.;
        public List<Vente> findByDay(int d)
        {
            return db.Vente.Where(da => da.date_ajout.Value.Day == d).ToList();
        }
        public List<Vente> findnow(DateTime d)
        {
            return db.Vente.Where(da => da.date_ajout.Value == d).ToList();
        }


        int q = 0;
        public int QuantiteMonth(int m,int y)
        {
            List<Vente> l = findByMounth(m,y);
            foreach (var item in l)
            {
                q += Convert.ToInt32(item.quantite_vendu);
            }
            return q;
        }
        int g = 0;
        public int nb_venteByMonth(int m,int y)
        {
            List<Vente> l = findByMounth(m,y);
            var n = from li in l select li.id_vente;
            g = Convert.ToInt32(n.Count().ToString());

            return g;
        }

        public int gain_month(int m,int y)
        {
            List<Vente> list = db.Vente.Where(l => l.date_ajout.Value.Month == m && l.date_ajout.Value.Year==y).ToList();
            foreach (var v in list)
            {
                Produit p = db.Produit.Where(s => s.id_produit == v.id_produit).First();
                int i = p.id_produit;
                int id = v.id_vente;

                s += gain1(i, m, id,y);
            }
            return s;
        }
        int num = 0;
        public int nb_produit_des(DateTime d)
        {
            List<Produit> list = db.Produit.Where(p => p.date_expiration.Value < d && p.quantite != 0).ToList<Produit>();
            var n = from l in list select l.id_produit;
            int num = Convert.ToInt32(n.Count().ToString());
            return num;
        }

        int qa = 0;
        public int qu(int id, DateTime d)
        {
            List<Vente> l = db.Vente.Where(v => v.id_produit == id && v.date_ajout.Value == d).ToList();
            foreach (var item in l)
            {
                qa += Convert.ToInt32(item.quantite_vendu);
            }
            return qa;
        }

        public int QuantiteYear(int y)
        {
            List<Vente> ventes = findByYear(y);
            foreach (var item in ventes)
            {
                q += Convert.ToInt32(item.quantite_vendu);
            }
            return q;
        }

        public int nb_venteByYear(int y)
        {
            List<Vente> ve = findByYear(y);
            return ve.Count();
        }

        public decimal gain_year(int y)
        {
            decimal s = 0;
            List<Vente> ventes = findByYear(y);
            foreach (var v in ventes)
            {
                Produit p = db.Produit.Where(elt => elt.id_produit == v.id_produit).First();
                int id = p.id_produit;
                var prix_vente = p.prix_vente;

                LigneCommande l = db.LigneCommande.Where(li => li.id_produit == id).First();
                var prix_achat = l.prix_grossiste / l.quantite ;

                //if (prix_vente >= prix_achat)
                //{
                    s += Convert.ToDecimal((prix_vente - prix_achat) * v.quantite_vendu );
                //}

            }
            return s;
        }

        public decimal perte_year(int y)
        {
            decimal s = 0;
            decimal sum = 0;
            List<Produit> list = db.Produit.Where(p => p.date_expiration < DateTime.Now && p.quantite != 0).ToList<Produit>();
            foreach (var item in list)
            {
                sum +=Convert.ToDecimal(item.prix_vente);
            }

            /*List<Vente> ventes = findByYear(y);
            foreach (var v in ventes)
            {
                Produit p = db.Produit.Where(elt => elt.id_produit == v.id_produit).First();
                int id = p.id_produit;
                var prix_vente = p.prix_vente;

                LigneCommande l = db.LigneCommande.Where(c => c.id_produit == id).First();
                var prix_achat = l.prix_grossiste;

                if(prix_vente <= prix_achat)
                {
                    s += Convert.ToDecimal((prix_achat - prix_vente) * v.quantite_vendu);
                }
            }*///Convert.ToDecimal(
            return  sum ;
        }

        public int QuantityWeek(DateTime d, DateTime dd)
        {
            int q = 0;
           var ventes = db.Vente.Where(v => v.date_ajout.Value.Date < dd && v.date_ajout.Value.Date > d ).ToList();
            foreach(var v in ventes)
            {
                q += Convert.ToInt32(v.quantite_vendu);
            }
            return q;
        }
        public string name_prod(int i)
        {
            Produit p = db.Produit.Where(s => s.id_produit == i).First();
            return p.nom;
        }

        public int nbr_achat(DateTime d)
        {
            List<Commande> l = db.Commande.Where(c => c.date_commande.Value == d).ToList();
            var n = from i in l select i.id_commande;

            return Convert.ToInt32(n.Count().ToString());
        }
        // quantite vendu d'un prodduit en entrant son id et le mois et l,'annee
        public int q_v_m(int id, int m, int y)
        {
            int q = 0;

            List<Vente> l = db.Vente.Where(p => p.id_produit == id && p.date_ajout.Value.Month == m && p.date_ajout.Value.Year == y).ToList();
            foreach (var item in l)
            {
                q += Convert.ToInt32(item.quantite_vendu);
            }
            return q;
        }

        public decimal perte_mois(int m, int y)
        {
            decimal s = 0;
            List<Produit> p = db.Produit.Where(r => r.date_expiration.Value.Month < m && r.date_expiration.Value.Year < y).ToList();
            foreach (var item in p)
            {
                LigneCommande c = db.LigneCommande.Where(w => w.id_produit == item.id_produit).First();
                s += Convert.ToInt32(c.prix_grossiste) * Convert.ToInt32(item.quantite);
            }
            return s;
        }

    }
}
