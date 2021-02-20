using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GestionDeStockI3MServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserServiceWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserServiceWCF.svc or UserServiceWCF.svc.cs at the Solution Explorer and start debugging.
    public class UserServiceWCF : IUserServiceWCF
    {
        GestionDeStockEntities db = new GestionDeStockEntities();
        public void add(User u)
        {
            db.User.Add(u);
            db.SaveChanges();
        }

        public List<User> getAll()
        {
            return db.User.ToList<User>();
        }
    }
}
