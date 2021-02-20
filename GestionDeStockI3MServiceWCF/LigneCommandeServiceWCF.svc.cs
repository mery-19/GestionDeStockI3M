using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LigneCommandeServiceWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LigneCommandeServiceWCF.svc or LigneCommandeServiceWCF.svc.cs at the Solution Explorer and start debugging.
    public class LigneCommandeServiceWCF : ILigneCommandeServiceWCF
    {
        GestionDeStockEntities db = new GestionDeStockEntities();

        public void add(LigneCommande ligne)
        {
            db.LigneCommande.Add(ligne);
            db.SaveChanges();
        }
    }
}
