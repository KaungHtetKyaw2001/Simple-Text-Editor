using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor_L4DC_124_
{
    class clsUserRegister
    {
        private string UserID, Username, Age, Address, Email, Password, Phone;
        public string UID
        {
            get { return UserID; }
            set { UserID = value; }
        }
        public string UName
        {
            get { return Username; }
            set { Username = value; }
        }
        public string UAge
        {
            get { return Age; }
            set { Age = value; }
        }
        public string UAddress
        {
            get { return Address; }
            set { Address = value; }
        }
        public string UEmail
        {
            get { return Email; }
            set { Email = value; }
        }
        public string UPassword
        {
            get { return Password; }
            set { Password = value; }
        }
        public string UPhone
        {
            get { return Phone; }
            set { Phone = value; }
        }
    }
}