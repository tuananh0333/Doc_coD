using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_LTUD_LeTuanAnh
{
    class User
    {
        protected string ID;
        protected string userName;
        protected string name;
        protected string password;

        public User(string ID, string userName, string name, string password)
        {
            this.ID = ID;
            this.userName = userName;
            this.name = name;
            this.password = password;
        }

        public string getID()
        {
            return this.ID;
        }

        public void setName(string newName)
        {
            this.name = newName;
        }
        public string getName()
        {
            return this.name;
        }

        public void setUserName(string newUserName)
        {
            this.userName = newUserName;
        }
        public string getUserName()
        {
            return this.userName;
        }

        public void setPassword(string newPassword)
        {
            this.password = newPassword;
        }
        public string getPassword()
        {
            return this.password;
        }
    }
}
