using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleAxes_Sample {
    public class ChartDataModel
    {
        public double ElectronicsSales { get; set; }
        public double WireSales { get; set; }
        public DateTime Date { get; set; }
        public DateTime Year { get; set; }
        public double SalesValue { get; set; }
        public double SalesRevenue { get; set; }

        public ChartDataModel(DateTime year,double salesValue, double salesRevenue)
        {
            Year = year;
            SalesValue = salesValue;
            SalesRevenue = salesRevenue;
        }
    }
}
