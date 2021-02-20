using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommandeServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface ICommandeServiceWCF
    {
        [OperationContract]
        int add(Commande commande);

        [OperationContract]
        List<Commande> commandeEnCours();

        [OperationContract]
        List<Commande> commandeEnRetard();

        [OperationContract]
        List<Commande> commandeConfirme();

        [OperationContract]
        decimal prixCommande(int id);

        [OperationContract]
        int confirmeCommande(int id);

        [OperationContract]
        int delete(int id);

        [OperationContract]
        List<ProduitCommande> GetProduitsOfCommande(int id);


    }


    [DataContract]
    public class ProduitCommande
    {

        [DataMember]
        public int Id_produit { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public int Quantite { get; set; }
        [DataMember]
        public decimal Prix_grossiste { get; set; }
    }
}
