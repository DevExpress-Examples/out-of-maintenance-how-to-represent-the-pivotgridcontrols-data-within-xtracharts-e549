<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582459/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E549)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to display the PivotGridControl's data in XtraCharts


> This example is outdated. Refer to the [E2911](https://github.com/DevExpress-Examples/how-to-visualize-pivot-grid-data-via-the-xtracharts-suite-e2911) example.


To obtain the summary data source generated by the PivotGridControl, call the [CreateSummaryDataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CreateSummaryDataSource) method. Assign the data source to the **ChartControl.DataSource** property, and specify series, series point arguments and series point values.
