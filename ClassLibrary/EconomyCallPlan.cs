using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class EconomyCallPlan : CallPlanType
    {
        private static int _id = 101;
        private static string _name = "Economy Call Plan";
        private static double _monthlyPlanCost = 10;
        private static double _extraCharge = 1.5;
        private static int _capLimit = 220;
        public EconomyCallPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }
    }
}
