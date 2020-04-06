using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes
{
    public class Customer
    {
        private int _id;
        private string _title;
        private string _fname;
        private string _lname;
        private string _email;
        private DateTime _dob;
        private string _address;


        public Customer(int id, string title, string fname, string lname, string email, DateTime dob, string address)
        {
            Id = id;
            Title = title;
            Fname = fname;
            Lname = lname;
            Email = email;
            Dob = dob;
            Address = address;
        }

        public int Id { get => _id; set => _id = value; }
        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Title cannot be blank");
                _title = value;
            }
        }
        public string Fname
        {
            get => _fname; set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First Name cannot be blank");
                _fname = value;
            }
        }
        public string Lname
        {
            get => _lname; set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last Name cannot be blank");
                _lname = value;
            }
        }
        public string Email
        {
            get => _email; set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Email Name cannot be blank");
                _email = value;
            }
        }
        public DateTime Dob
        {
            get => _dob; set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("Date cannot be blank");
                _dob = value;
            }
        }

        public string Address
        {
            get => _address; set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Date cannot be blank");
                _address = value;
            }
        }
    }
}
