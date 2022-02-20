using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersContext.model
{
    class UserData
    {
        public string name;
        public string username;
        public string password;
        public string gender;
        public int id;
        public UserData(int Id, string Name, string Username, string Password, string Gender)
        {
            name = Name;
            username = Username;
            password = Password;
            gender = Gender;
            id = Id;
        }
    }

}
