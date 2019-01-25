<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to display the PivotGridControl's data in XtraCharts


> This example is outdated. Refer to the [E2911](https://github.com/DevExpress-Examples/how-to-visualize-pivot-grid-data-via-the-xtracharts-suite-e2911) example.


To obtain the summary data source generated by the PivotGridControl you should call its <strong>CreateSummaryDataSource</strong> method. Then, this datasource should be assigned to the **ChartControl.DataSource** property, and specify what data fields should be considered as series (**SeriesDataMember** property), what as series points arguments (**SeriesTemplate.ArgumentDataMember** property), and what as series points values (**SeriesTemplate.ValueDataMembers**).

In the following example the pivotGridControl1 is bound to the Northwind Traders (nwind.mdb sample database) and shows sales data on products of different categories per years and months. Then, this data will be shown within a chartControl1 for the particular Category ("Beverages") and Year (2015). The [OptionsDataField.FieldNaming](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridOptionsDataField.FieldNaming) property value is DataFieldNaming.Name. This was done to differentiate between two OrderMonth columns with different GroupIntervals.