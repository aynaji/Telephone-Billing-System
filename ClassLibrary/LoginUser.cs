using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class LoginUser : IComparable
    {

        private string _loginName;
        private string _password;
        private bool _accessGrant;
        public LoginUser(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
        }

        public string LoginName
        {
            get { return _loginName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Login Name cannot be blank");
                _loginName = value;
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Password cannot be blank");
                _password = value;
            }
        }

        public bool AccessGrant { get { return _accessGrant; } }

        public int CompareTo(LoginUser other)
        {
            return (this.LoginName.CompareTo(other.LoginName));
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsGranted()
        {

            DAO.BillingSystemDAO loginDAO = new DAO.BillingSystemDAO();


            foreach (var item in loginDAO.LoginEntry(LoginName, Password))
            {
                if (item.LoginName == LoginName)
                {
                    _accessGrant = true;
                }

                else
                {
                    _accessGrant = false;
                }

            }
            return AccessGrant;
        }

    }




}
