using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Payment
{
    public class CreditCard : Payment
    {
        private string _fname;
        private string _lname;
        private string _bank;
        private string _cardType;
        private DateTime _expDate;


        public CreditCard(string fname, string lname, string bank, string cardType, DateTime expDate, double amount) : base(amount)
        {
            Fname = fname;
            Lname = lname;
            Bank = bank;
            CardType = cardType;
            ExpDate = expDate;
        }

        public string Fname { get => _fname; set => _fname = value; }
        public string Lname { get => _lname; set => _lname = value; }
        public string Bank { get => _bank; set => _bank = value; }
        public string CardType { get => _cardType; set => _cardType = value; }
        public DateTime ExpDate { get => _expDate; set => _expDate = value; }
    }
}
