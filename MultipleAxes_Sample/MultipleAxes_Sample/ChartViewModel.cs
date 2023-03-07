using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleAxes_Sample {
    public class ChartViewModel 
    {
        public ObservableCollection<ChartDataModel> SalesData { get; set; }
        public ObservableCollection<ChartDataModel> WireSalesDetails { get; set; }

        public ChartViewModel() {
            SalesData = new ObservableCollection<ChartDataModel>()
            {
            //new ChartDataModel(new DateTime(2007,01,01),1.39,5),
            new ChartDataModel(new DateTime(2008,01,01),11.63,241),
            new ChartDataModel(new DateTime(2009, 01, 01), 20.73, 2949),
            new ChartDataModel(new DateTime(2010, 01, 01), 39.99, 5578),
            new ChartDataModel(new DateTime(2011, 01, 01), 72.29, 10239),
            new ChartDataModel(new DateTime(2012, 01, 01), 125.05, 23950),
            new ChartDataModel(new DateTime(2013, 01, 01), 150.26, 30660),
            new ChartDataModel(new DateTime(2014, 01, 01), 169.22, 32498),
            new ChartDataModel(new DateTime(2015, 01, 01), 231.22, 51182),
            new ChartDataModel(new DateTime(2016, 01, 01), 211.88, 51635),
            new ChartDataModel(new DateTime(2017, 01, 01), 216.76, 54378)  ,
            new ChartDataModel(new DateTime(2018, 01, 01), 217.72, 61576),
            
        };

        }
    }
}
