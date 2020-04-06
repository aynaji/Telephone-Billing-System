using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class MiddleTextPlan : TextPlanType
    {
        private static string _name = "Middle Text Plan";
        private static double _monthlyPlanCost = 15;
        private static double _extraCharge = 1.5;
        private static int _id = 203;
        private static int _capLimit = 200;
        public MiddleTextPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }
    }
}