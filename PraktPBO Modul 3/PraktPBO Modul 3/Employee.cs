using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktPBO_Modul_3
{
    class Employee
    {
        //memasukkan instance variable
        private int _empID;
        private string _loginName;
        private string _password;
        private int _securityLevel;
        //mendefinisikan properti
        public int EmployeeID
        {
            get { return _empID; }
        }
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int SecurityLevel
        {
            get { return _securityLevel; }
        }
        public Boolean Login(string LoginName, string Password)
        {
            if (LoginName == "Evan" & Password == "wkwk")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;
            }
            else if (LoginName == "Ananda" & Password == "haha")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Employee() { }
        public Employee(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
        }
    }
}
