using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVenteServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface IVenteServiceWCF
    {
        [OperationContract]
        int add(Vente vente);

        [OperationContract]
        decimal QtProduit(int id_produit);

        [OperationContract]
        List<Vente> listeVente();

        [OperationContract]
        Vente find(int id);

        [OperationContract]
        int nbVente(DateTime d);


        [OperationContract]
        void updateQuantity(int qt, int id);
    }
}
