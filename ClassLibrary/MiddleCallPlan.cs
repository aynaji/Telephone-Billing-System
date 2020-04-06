using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class MiddleCallPlan : CallPlanType
    {
        private static string _name = "Middle Call Plan";
        private static double _monthlyPlanCost = 15;
        private static double _extraCharge = 1.5;
        private static int _id = 201;
        private static int _capLimit = 320;
        public MiddleCallPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }
    }
}
