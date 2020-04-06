using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Consumer
    {
        private int _id;
        private Customer _customer;
        private Plan _plan;
        private bool _isActive;
        private DateTime RenewalDate;
        public Consumer(Customer customer, Plan plan, bool isActive)
        {
            _customer = customer;
            _plan = plan;
            _isActive = isActive;
        }
        public int ID { set { _id = value; } get { return _id; } }
        public Customer Customer { set { _customer = value; } get { return _customer; } }
        public Plan Plan { set { _plan = value; } get { return _plan; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public DateTime RevewalDate { get { return RenewalDate; } set { if (IsActive == true) RenewalDate = value; } }

        public void Bill(int textUsage, int dataUsage, int callUsage)
        {
            CalculateBill calculateBill = new CalculateBill(Plan, textUsage, dataUsage, callUsage);
        }

    }


}
