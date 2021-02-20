using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFournisseurServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface IFournisseurServiceWCF
    {
        [OperationContract]
        void add(Fournisseur f);

        [OperationContract]
        List<Fournisseur> findAll();

        [OperationContract]
        Fournisseur find(int id);

        [OperationContract]
        string findName(int id);
        [OperationContract]
        void delete(int id);

        [OperationContract]
        void modifier(Fournisseur f);

        [OperationContract]
        List<Fournisseur> findNom(string n);

        [OperationContract]
        List<Fournisseur> findbyId(int id);
    }
}
