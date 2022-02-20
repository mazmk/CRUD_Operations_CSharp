using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersContext.model;

// Data Access Layer
namespace UsersContext
{
    class DAO
    {
        DataStore ds = new DataStore();
        public dynamic Save(UserData user)
        {
            return ds.Save(user);
        }
        public dynamic Update(UserData user)
        {
            return ds.Update(user);
        }
        public dynamic Load(int id)
        {
            //return ds.Save(user);
            return ds.Load(id);
        }
        public dynamic Delete(int id)
        {
            return ds.Delete(id);
        }
    }

}
