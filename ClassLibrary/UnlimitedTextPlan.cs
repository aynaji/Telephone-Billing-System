using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class UnlimitedTextPlan : TextPlanType
    {
        private static string _name = "Unlimited Text Plan";
        private static double _monthlyPlanCost = 25;
        private static double _extraCharge = 1;
        private static int _id = 303;
        private static int _capLimit = 1000;
        public UnlimitedTextPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }


    }
}
