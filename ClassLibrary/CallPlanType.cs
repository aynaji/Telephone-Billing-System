using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class CallPlanType
    {
        private int _id;
        private string _name;
        private double _monthlyPlanCost;
        private double _extraCharge;
        private int _capLimit;

        public CallPlanType(int id, string name, double monthlyPlanCost, double extraCharge, int capLimit)
        {
            Id = id;
            Name = name;
            MonthlyPlanCost = monthlyPlanCost;
            ExtraCharge = extraCharge;
            CapLimit = capLimit;
        }

        public int Id
        {
            get => _id; set
            {
                if (value < 0)
                    throw new ArgumentException("Call Id cannot be negative");
                _id = value;
            }
        }
        public string Name
        {
            get => _name; set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Call Plan name cannot be blank");
                _name = value;
            }
        }
        public double MonthlyPlanCost
        {
            get => _monthlyPlanCost; set
            {
                if (value < 0)
                    throw new ArgumentException("Call Plan cost cannot be negative");
                _monthlyPlanCost = value;
            }
        }
        public double ExtraCharge
        {
            get => _extraCharge; set
            {
                if (value < 0)
                    throw new ArgumentException("Extra Charge cannot be negative");
                _extraCharge = value;
            }
        }
        public int CapLimit
        {
            get => _capLimit; set
            {
                if (value < 0)
                    throw new ArgumentException("Call Cap Limit cannot be negative");
                _capLimit = value;
            }

        }
    }
}
