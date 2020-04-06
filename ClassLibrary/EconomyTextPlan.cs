using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class EconomyTextPlan : TextPlanType
    {
        private static string _name = "Economy Text Plan";
        private static double _monthlyPlanCost = 10;
        private static double _extraCharge = 1.5;
        private static int _id = 102;
        private static int _capLimit = 100;
        public EconomyTextPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }

    }
}
