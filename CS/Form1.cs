#region Using
using System;
using System.Windows.Forms;

using DevExpress.XtraPivotGrid;
using DevExpress.XtraCharts;
using DevExpress.Data.PivotGrid;
#endregion

namespace dxKB3226 {
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		#region Windows Form Designer generated code
		private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private dxKB3226.DataSet1 dataSet11;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraPivotGrid.PivotGridField categoryName;
		private DevExpress.XtraPivotGrid.PivotGridField productName;
		private DevExpress.XtraPivotGrid.PivotGridField quantity;
		private DevExpress.XtraPivotGrid.PivotGridField orderDate_Year;
		private DevExpress.XtraPivotGrid.PivotGridField orderDate_Month;

		private string category = "Beverages";
		private int year = 1994;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if(disposing) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.dataSet11 = new dxKB3226.DataSet1();
			this.categoryName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.productName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.quantity = new DevExpress.XtraPivotGrid.PivotGridField();
			this.orderDate_Year = new DevExpress.XtraPivotGrid.PivotGridField();
			this.orderDate_Month = new DevExpress.XtraPivotGrid.PivotGridField();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.DataSource = this.dataSet11.Employees;
			this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.categoryName,
            this.productName,
            this.quantity,
            this.orderDate_Year,
            this.orderDate_Month});
			this.pivotGridControl1.Location = new System.Drawing.Point(8, 48);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.OptionsDataField.FieldNaming = DevExpress.XtraPivotGrid.DataFieldNaming.Name;
			this.pivotGridControl1.Size = new System.Drawing.Size(735, 379);
			this.pivotGridControl1.TabIndex = 0;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("ru-RU");
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// categoryName
			// 
			this.categoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.categoryName.AreaIndex = 0;
			this.categoryName.FieldName = "CategoryName";
			this.categoryName.Name = "categoryName";
			// 
			// productName
			// 
			this.productName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.productName.AreaIndex = 1;
			this.productName.FieldName = "ProductName";
			this.productName.Name = "productName";
			// 
			// quantity
			// 
			this.quantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.quantity.AreaIndex = 0;
			this.quantity.FieldName = "Quantity";
			this.quantity.Name = "quantity";
			// 
			// orderDate_Year
			// 
			this.orderDate_Year.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.orderDate_Year.AreaIndex = 0;
			this.orderDate_Year.FieldName = "OrderDate";
			this.orderDate_Year.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.orderDate_Year.Name = "orderDate_Year";
			this.orderDate_Year.UnboundFieldName = "orderDate_Year";
			// 
			// orderDate_Month
			// 
			this.orderDate_Month.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.orderDate_Month.AreaIndex = 1;
			this.orderDate_Month.FieldName = "OrderDate";
			this.orderDate_Month.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.orderDate_Month.Name = "orderDate_Month";
			this.orderDate_Month.UnboundFieldName = "orderDate_Month";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Products.ProductID", "Products.ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("Products.CategoryID", "Products.CategoryID"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("Products.UnitPrice", "Products.UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
                        new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
                        new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"),
                        new System.Data.Common.DataColumnMapping("EAN13", "EAN13"),
                        new System.Data.Common.DataColumnMapping("Order Details.OrderID", "Order Details.OrderID"),
                        new System.Data.Common.DataColumnMapping("Order Details.ProductID", "Order Details.ProductID"),
                        new System.Data.Common.DataColumnMapping("Order Details.UnitPrice", "Order Details.UnitPrice"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("Discount", "Discount"),
                        new System.Data.Common.DataColumnMapping("Orders.OrderID", "Orders.OrderID"),
                        new System.Data.Common.DataColumnMapping("Orders.CustomerID", "Orders.CustomerID"),
                        new System.Data.Common.DataColumnMapping("Orders.EmployeeID", "Orders.EmployeeID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
                        new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
                        new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
                        new System.Data.Common.DataColumnMapping("Freight", "Freight"),
                        new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
                        new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                        new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
                        new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
                        new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
                        new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry"),
                        new System.Data.Common.DataColumnMapping("Employees.EmployeeID", "Employees.EmployeeID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCourtesy"),
                        new System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"),
                        new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                        new System.Data.Common.DataColumnMapping("Employees.Address", "Employees.Address"),
                        new System.Data.Common.DataColumnMapping("Employees.City", "Employees.City"),
                        new System.Data.Common.DataColumnMapping("Employees.Region", "Employees.Region"),
                        new System.Data.Common.DataColumnMapping("Employees.PostalCode", "Employees.PostalCode"),
                        new System.Data.Common.DataColumnMapping("Employees.Country", "Employees.Country"),
                        new System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"),
                        new System.Data.Common.DataColumnMapping("Extension", "Extension"),
                        new System.Data.Common.DataColumnMapping("Photo", "Photo"),
                        new System.Data.Common.DataColumnMapping("Notes", "Notes"),
                        new System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"),
                        new System.Data.Common.DataColumnMapping("Categories.CategoryID", "Categories.CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Picture", "Picture"),
                        new System.Data.Common.DataColumnMapping("Customers.CustomerID", "Customers.CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Customers.Address", "Customers.Address"),
                        new System.Data.Common.DataColumnMapping("Customers.City", "Customers.City"),
                        new System.Data.Common.DataColumnMapping("Customers.Region", "Customers.Region"),
                        new System.Data.Common.DataColumnMapping("Customers.PostalCode", "Customers.PostalCode"),
                        new System.Data.Common.DataColumnMapping("Customers.Country", "Customers.Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax")})});
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(8, 8);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(192, 32);
			this.simpleButton1.TabIndex = 2;
			this.simpleButton1.Text = "Show Chart for Category in Year";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(751, 439);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.pivotGridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}
		#endregion

		#region Form_Load
		private void Form1_Load(object sender, System.EventArgs e) {
			oleDbDataAdapter1.Fill(dataSet11);

			simpleButton1.Text = simpleButton1.Text.Replace("Category", category);
			simpleButton1.Text = simpleButton1.Text.Replace("Year", year.ToString());
		}
		#endregion

		private void simpleButton1_Click(object sender, System.EventArgs e) {
			Form2 form2 = new Form2();
			ChartControl chart = form2.chartControl1;

			PivotSummaryDataSource ds = pivotGridControl1.CreateSummaryDataSource();

			// Set the chart's datasource.
			chart.DataSource = ds;

			// Every month will be represented as a single series in the chart.
			chart.SeriesDataMember = "orderDate_Month";

			// Every product will be a series point argument.
			chart.SeriesTemplate.ArgumentDataMember = "productName";

			// Sum of products sold for this month will be a series point value.
			chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "quantity_Sum" });

			// Filter chart's datasource by category and year.
			chart.SeriesTemplate.FilterString = string.Format("[categoryName] = '{0}' And [orderDate_Year] = {1}", category, year);
			chart.SeriesSorting = SortingMode.Ascending;

			// Get the X-Axis of a Chart and adjust its labels.
			Axis xAxis = ((XYDiagram)chart.Diagram).AxisX;
			xAxis.Label.Angle = 45;
			xAxis.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;

			// Show the form.
			form2.Text = form2.Text.Replace("Category", category);
			form2.Text = form2.Text.Replace("Year", year.ToString());
			form2.Show();
		}

	}
}
