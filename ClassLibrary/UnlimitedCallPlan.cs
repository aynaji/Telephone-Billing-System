using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class UnlimitedCallPlan : CallPlanType
    {
        private static string _name = "Unlimited Call Plan";
        private static int _monthlyPlanCost = 25;
        private static int _extraCharge = 1;
        private static int _id = 301;
        private static int _capLimit = 1500;
        public UnlimitedCallPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }



    }
}
