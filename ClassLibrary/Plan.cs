using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Plan
    {
        private TextPlanType _textPlanType;
        private DataPlanType _dataPlanType;
        private CallPlanType _callPlanType;

        public Plan(int textselected, int dataSelected, int callSelected)
        {
            switch (textselected)
            {
                case 0: _textPlanType = new EconomyTextPlan(); break;
                case 1: _textPlanType = new MiddleTextPlan(); break;
                case 2: _textPlanType = new UnlimitedTextPlan(); break;
            }
            switch (dataSelected)
            {
                case 0: _dataPlanType = new EconomyDataPlan(); break;
                case 1: _dataPlanType = new MiddleDataPlan(); break;
                case 2: _dataPlanType = new UnlimitedDataPlan(); break;
            }
            switch (callSelected)
            {
                case 0: _callPlanType = new EconomyCallPlan(); break;
                case 1: _callPlanType = new MiddleCallPlan(); break;
                case 2: _callPlanType = new UnlimitedCallPlan(); break;
            }

        }

        public TextPlanType TextPlanType { get { return _textPlanType; } set { _textPlanType = value; } }
        public DataPlanType DataPlanType { get { return _dataPlanType; } set { _dataPlanType = value; } }
        public CallPlanType CallPlanType { get { return _callPlanType; } set { _callPlanType = value; } }



    }
}
