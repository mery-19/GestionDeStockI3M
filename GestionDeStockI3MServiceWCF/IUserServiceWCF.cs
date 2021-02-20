using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface IUserServiceWCF
    {
        [OperationContract]
        void add(User u);

        [OperationContract]
        List<User> getAll();
    }
}
