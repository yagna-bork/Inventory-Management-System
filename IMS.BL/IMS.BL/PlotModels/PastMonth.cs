﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot.Axes;

namespace IMS.BL.PlotModels
{
    public class PastMonth : PlotModelCreator
    {
        public PastMonth(Dictionary<DateTime, int> _QuantityData, Dictionary<DateTime, decimal> _RevenueData) : base(_QuantityData, _RevenueData)
        {
            this.Title = "Past Month";

            //pick max value from both set of dps
            AddAxes(GetMaxValue(_QuantityData, _RevenueData));
        }

        void AddAxes(double maxValue)
        {
            var keyAxis = new DateTimeAxis()
            {
                Position = AxisPosition.Bottom,
                Title = "Time",
                StringFormat = "dd/mm/yy",
            };

            var valueAxis = new LinearAxis()
            {
                Position = AxisPosition.Left,
                StartPosition = 0,
                Minimum = 0,
                Maximum = maxValue + 1,
                Title = "Value"
            };

            this.Axes.Add(keyAxis);
            this.Axes.Add(valueAxis);

        }

    }
}
