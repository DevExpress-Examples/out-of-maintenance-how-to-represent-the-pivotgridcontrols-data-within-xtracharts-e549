#Region "Using"
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Windows.Forms
#End Region

Namespace dxKB3226
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form

		#Region "Windows Form Designer generated code"
		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
		Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
		Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
		Private dataSet11 As dxKB3226.DataSet1
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private categoryName As DevExpress.XtraPivotGrid.PivotGridField
'INSTANT VB NOTE: The variable productName was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private productName_Renamed As DevExpress.XtraPivotGrid.PivotGridField
		Private quantity As DevExpress.XtraPivotGrid.PivotGridField
		Private orderDate_Year As DevExpress.XtraPivotGrid.PivotGridField
		Private orderDate_Month As DevExpress.XtraPivotGrid.PivotGridField

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.dataSet11 = New dxKB3226.DataSet1()
			Me.categoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.productName_Renamed = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.quantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.orderDate_Year = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.orderDate_Month = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
			Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
			Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.dataSet11.Employees
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.categoryName, Me.productName_Renamed, Me.quantity, Me.orderDate_Year, Me.orderDate_Month})
			Me.pivotGridControl1.Location = New System.Drawing.Point(8, 48)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsDataField.FieldNaming = DevExpress.XtraPivotGrid.DataFieldNaming.Name
			Me.pivotGridControl1.Size = New System.Drawing.Size(735, 379)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.Locale = New System.Globalization.CultureInfo("ru-RU")
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoryName
			' 
			Me.categoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.categoryName.AreaIndex = 0
			Me.categoryName.FieldName = "CategoryName"
			Me.categoryName.Name = "categoryName"
			' 
			' productName
			' 
			Me.productName_Renamed.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.productName_Renamed.AreaIndex = 1
			Me.productName_Renamed.FieldName = "ProductName"
			Me.productName_Renamed.Name = "productName"
			' 
			' quantity
			' 
			Me.quantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.quantity.AreaIndex = 0
			Me.quantity.FieldName = "Quantity"
			Me.quantity.Name = "quantity"
			' 
			' orderDate_Year
			' 
			Me.orderDate_Year.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.orderDate_Year.AreaIndex = 0
			Me.orderDate_Year.FieldName = "OrderDate"
			Me.orderDate_Year.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.orderDate_Year.Name = "orderDate_Year"
			Me.orderDate_Year.UnboundFieldName = "orderDate_Year"
			' 
			' orderDate_Month
			' 
			Me.orderDate_Month.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.orderDate_Month.AreaIndex = 1
			Me.orderDate_Month.FieldName = "OrderDate"
			Me.orderDate_Month.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.orderDate_Month.Name = "orderDate_Month"
			Me.orderDate_Month.UnboundFieldName = "orderDate_Month"
			' 
			' oleDbDataAdapter1
			' 
			Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
			Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("Products.ProductID", "Products.ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("Products.CategoryID", "Products.CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("Products.UnitPrice", "Products.UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"), New System.Data.Common.DataColumnMapping("EAN13", "EAN13"), New System.Data.Common.DataColumnMapping("Order Details.OrderID", "Order Details.OrderID"), New System.Data.Common.DataColumnMapping("Order Details.ProductID", "Order Details.ProductID"), New System.Data.Common.DataColumnMapping("Order Details.UnitPrice", "Order Details.UnitPrice"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("Orders.OrderID", "Orders.OrderID"), New System.Data.Common.DataColumnMapping("Orders.CustomerID", "Orders.CustomerID"), New System.Data.Common.DataColumnMapping("Orders.EmployeeID", "Orders.EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry"), New System.Data.Common.DataColumnMapping("Employees.EmployeeID", "Employees.EmployeeID"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCourtesy"), New System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"), New System.Data.Common.DataColumnMapping("HireDate", "HireDate"), New System.Data.Common.DataColumnMapping("Employees.Address", "Employees.Address"), New System.Data.Common.DataColumnMapping("Employees.City", "Employees.City"), New System.Data.Common.DataColumnMapping("Employees.Region", "Employees.Region"), New System.Data.Common.DataColumnMapping("Employees.PostalCode", "Employees.PostalCode"), New System.Data.Common.DataColumnMapping("Employees.Country", "Employees.Country"), New System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"), New System.Data.Common.DataColumnMapping("Extension", "Extension"), New System.Data.Common.DataColumnMapping("Photo", "Photo"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"), New System.Data.Common.DataColumnMapping("Categories.CategoryID", "Categories.CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture"), New System.Data.Common.DataColumnMapping("Customers.CustomerID", "Customers.CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Customers.Address", "Customers.Address"), New System.Data.Common.DataColumnMapping("Customers.City", "Customers.City"), New System.Data.Common.DataColumnMapping("Customers.Region", "Customers.Region"), New System.Data.Common.DataColumnMapping("Customers.PostalCode", "Customers.PostalCode"), New System.Data.Common.DataColumnMapping("Customers.Country", "Customers.Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax")})})
			' 
			' oleDbSelectCommand1
			' 
			Me.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText")
			Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
			' 
			' oleDbConnection1
			' 
			Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(8, 8)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(192, 32)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Show Chart"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(751, 439)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "Form_Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
			oleDbDataAdapter1.Fill(dataSet11)
		End Sub
		#End Region

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			Dim year As Integer = 2015
			Dim category As String = "Beverages"

			Dim form2 As New Form2()
			Dim chart As ChartControl = form2.chartControl1

			Dim ds As PivotSummaryDataSource = pivotGridControl1.CreateSummaryDataSource()

			' Set the chart's datasource.
			chart.DataSource = ds

			' Every month will be represented as a single series in the chart.
			chart.SeriesDataMember = "orderDate_Month"

			' Every product will be a series point argument.
			chart.SeriesTemplate.ArgumentDataMember = "productName"

			' Sum of products sold for this month will be a series point value.
			chart.SeriesTemplate.ValueDataMembers.AddRange(New String() { "quantity_Sum" })

			' Filter chart's datasource by category and year.
			chart.SeriesTemplate.DataFilters.Add("categoryName", "System.String", DataFilterCondition.Equal, category)
			chart.SeriesTemplate.DataFilters.Add("orderDate_Year", "System.Int32", DataFilterCondition.Equal, year)
			chart.SeriesSorting = SortingMode.Ascending

			' Get the X-Axis of a Chart and adjust its labels.
			Dim xAxis As Axis = CType(chart.Diagram, XYDiagram).AxisX
			xAxis.Label.Angle = 45
			xAxis.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True


			' Show the form.
			form2.Text = String.Format("{0}, {1}", category, year)
			form2.Show()
		End Sub
	End Class
End Namespace
