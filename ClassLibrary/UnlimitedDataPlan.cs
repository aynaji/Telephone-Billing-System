using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class UnlimitedDataPlan : DataPlanType
    {
        private static string _name = "Unlimited Data Plan";
        private static double _monthlyPlanCost = 25;
        private static double _extraCharge = 1;
        private static int _id = 302;
        private static int _capLimit = 5000;
        public UnlimitedDataPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }

    }
}
