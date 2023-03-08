# How-to-create-a-multiple-axes-Column-Chart-in-.NET-MAUI
This sample demonstrate how to create a multiple axes Column Chart in .NET MAUI
<br><br>
The .NET MAUI Chart provides support for accessing multiple axes within the column chart. We can arrange these multiple axes using XAxisName and YAxisName properties of the Cartesian series. An axis can be positioned anywhere in the chart area by using the CrossesAt property. Column charts allow easy comparisons among several items and trends analysis.
<br>
**[XAML]**
```
<chart:SfCartesianChart >
…
  <chart:SfCartesianChart.XAxes>
      <chart:DateTimeAxis Name="XAxis1"/>
   </chart:SfCartesianChart.XAxes>
            
   <chart:SfCartesianChart.YAxes>
      <chart:NumericalAxis  Name="YAxis1"  />
      <chart:NumericalAxis CrossesAt="{Static x:Double.MaxValue}" Name="YAxis2" />
   </chart:SfCartesianChart.YAxes>
            
   <chart:ColumnSeries XBindingPath="Year"  YBindingPath="SalesValue "  
                                   XAxisName="XAxis1" YAxisName="YAxis1"
                                   ItemsSource="{Binding SalesData }"> 
   </chart:ColumnSeries>
            
   <chart:ColumnSeries  XBindingPath="Year" YBindingPath="SalesRevenue " 
                                    XAxisName="XAxis1" YAxisName="YAxis2" 
                                     ItemsSource="{Binding SalesData }">
    </chart:ColumnSeries >
</chart:SfCartesianChart>
```

**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
ChartViewModel viewModel = new ChartViewModel();
        DateTimeAxis primaryAxis1 = new DateTimeAxis()
        {
            Name = "XAxis1",
        };

        chart.XAxes.Add(primaryAxis1);

        NumericalAxis secondaryAxis1 = new NumericalAxis()
        {
            Name = "YAxis1",
        };
        NumericalAxis secondaryAxis2 = new NumericalAxis()
        {
           Name = "YAxis2",
           CrossesAt = double.MaxValue,
        };

        chart.YAxes.Add(secondaryAxis1);
        chart.YAxes.Add(secondaryAxis2);

        ColumnSeries series1 = new ColumnSeries ()
        {
            XBindingPath = "Year",YBindingPath = "SalesValue",
            ItemsSource = viewModel.SalesData,
            Opacity = 0.6, XAxisName = "XAxis1", YAxisName = "YAxis1"
        };

        ColumnSeries series2 = new ColumnSeries ()
        {
            XBindingPath = "Year",YBindingPath = "SalesRevenue",
            ItemsSource = viewModel.SalesData,
            Opacity = 0.4, YAxisName = "YAxis2", XAxisName = "XAxis1"
        };

        chart.Series.Add(series1);
        chart.Series.Add(series2);
        Content = chart;
```

**Output**

<img width="754" alt="ColumnChart" src="https://user-images.githubusercontent.com/105482474/223488785-280cedd1-0cf6-4806-9ad5-c555b60a84f5.png">

**See also**

[How to add multiple axes in .NET MAUI Chart (SfCartesianChart)](https://www.syncfusion.com/kb/13738/how-to-add-multiple-axes-in-net-maui-chart-sfcartesianchart)

[Multiple axis in .NET MAUI chart (SfCartesianChart)](https://help.syncfusion.com/maui/cartesian-charts/axis/types#multiple-axes)
