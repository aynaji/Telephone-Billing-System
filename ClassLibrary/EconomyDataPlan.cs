using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Phone
{
    public class EconomyDataPlan : DataPlanType
    {
        private static int _id = 102;
        private static string _name = "Economy Data Plan";
        private static double _monthlyPlanCost = 10;
        private static double _extraCharge = 1.5;
        private static int _capLimit = 500;

        public EconomyDataPlan() : base(_id, _name, _monthlyPlanCost, _extraCharge, _capLimit)
        {

        }
    }
}
