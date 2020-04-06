using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class CalculateBill
    {
        private Plan plan;
        private double _textUsage;
        private double _dataUsage;
        private double _callUsage;
        private double _bill;

        public CalculateBill(Plan plan, double textUsage, double dataUsage, double callUsage)
        {
            this.Plan = plan;
            TextUsage = textUsage;
            DataUsage = dataUsage;
            CallUsage = callUsage;
        }

        public Plan Plan { get => plan; set => plan = value; }
        public double TextUsage
        {
            get => _textUsage; set
            {
                if (value < 0)
                    throw new ArgumentException("Text Usage cannot be negative");
                _textUsage = value;
            }
        }
        public double DataUsage
        {
            get => _dataUsage; set
            {
                if (value < 0)
                    throw new ArgumentException("Text Usage cannot be negative");
                _dataUsage = value;
            }
        }
        public double CallUsage
        {
            get => _callUsage; set
            {
                if (value < 0)
                    throw new ArgumentException("Text Usage cannot be negative");
                _callUsage = value;
            }
        }

        public double Bill { get => _bill; set => _bill = value; }

        private void CalculateCurrentBillWithoutTax()
        {
            Bill =
          Plan.CallPlanType.MonthlyPlanCost * Plan.DataPlanType.MonthlyPlanCost * Plan.TextPlanType.MonthlyPlanCost;
            if (CallUsage > Plan.CallPlanType.CapLimit)
            {
                Bill = +Plan.CallPlanType.CapLimit;
            }
            if (TextUsage > Plan.TextPlanType.CapLimit)
            {
                Bill += Plan.TextPlanType.CapLimit;
            }

            if (DataUsage > Plan.DataPlanType.CapLimit)
            {
                Bill += Plan.DataPlanType.CapLimit;
            }
        }

        private double CalculateCurrentBillWithTax()
        {
            CalculateCurrentBillWithoutTax();
            return Bill * 1.13;
        }
        private double CalculateYearlyBill()
        {
            return Bill * 12;
        }
        private double CalculateNetBill()
        {
            return CalculateCurrentBillWithTax() * 12;
        }
    }
}