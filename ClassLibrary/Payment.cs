using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Payment
{
    public class Payment
    {
        private double _amount;

        public Payment(double amount)
        {
            Amount = amount;
        }

        public Double Amount { get { return _amount; } set { if (value > 0) _amount = value; } }
    }
}

