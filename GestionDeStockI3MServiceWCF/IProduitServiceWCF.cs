using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProduitServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface IProduitServiceWCF
    {
        [OperationContract]
        List<Produit> findAll();

        [OperationContract]
        Produit find(int id);

        [OperationContract]
        void add(Produit p);

        /*START Task*/
        [OperationContract]
        List<Produit> findByFournisseur(int id_fourn);

        [OperationContract]
        int updateQuantite(int id);
        /*END Task*/


        [OperationContract]
        List<Fournisseur> findAllFournisseur();

        [OperationContract]
        Fournisseur findFournisseurByName(string nom);

        [OperationContract]
        List<Produit> findProductsByName(string nom);
        [OperationContract]
        List<Produit> findAvaibleProducts();

        [OperationContract]
        List<Produit> findProductsNotAvaible();
        [OperationContract]
        List<Produit> findDestockedProduts();

        [OperationContract]
        void delete(int id);

        [OperationContract]
        Fournisseur findProductsById(int id);

        [OperationContract]
        void edit(Produit p);

        

    }
}
