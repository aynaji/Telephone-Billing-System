using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class MiddleDataPlan : DataPlanType
    {
        private static string _name = "Middle Data Plan";
        private static double _monthlyPlanCost = 15;
        private static double _extraCharge = 1.5;
        private static int _id = 202;
        private static int _capLimit = 500;
        public MiddleDataPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }
    }
}