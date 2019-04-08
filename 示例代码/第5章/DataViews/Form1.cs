using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataViews
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGrid dgOrders;
		private System.Data.SqlClient.SqlDataAdapter daEmployees;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlCnNorthwind;
		private System.Data.SqlClient.SqlDataAdapter daCustomers;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.SqlClient.SqlDataAdapter daOrders;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		private DataViews.dsMaster1 dsMaster1;
		private System.Data.DataView dvOrders;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.daOrders.Fill(this.dsMaster1);

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dgOrders = new System.Windows.Forms.DataGrid();
			this.daEmployees = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlCnNorthwind = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.daCustomers = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.daOrders = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.dsMaster1 = new DataViews.dsMaster1();
			this.dvOrders = new System.Data.DataView();
			((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dvOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(440, 40);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "创建";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(440, 88);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "行状态过滤";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(440, 136);
			this.button3.Name = "button3";
			this.button3.TabIndex = 2;
			this.button3.Text = "排序";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(440, 184);
			this.button4.Name = "button4";
			this.button4.TabIndex = 3;
			this.button4.Text = "Find方法";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// dgOrders
			// 
			this.dgOrders.DataMember = "";
			this.dgOrders.DataSource = this.dvOrders;
			this.dgOrders.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgOrders.Location = new System.Drawing.Point(8, 8);
			this.dgOrders.Name = "dgOrders";
			this.dgOrders.Size = new System.Drawing.Size(416, 232);
			this.dgOrders.TabIndex = 4;
			// 
			// daEmployees
			// 
			this.daEmployees.DeleteCommand = this.sqlDeleteCommand1;
			this.daEmployees.InsertCommand = this.sqlInsertCommand1;
			this.daEmployees.SelectCommand = this.sqlSelectCommand1;
			this.daEmployees.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								  new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
																																																			   new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																			   new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																			   new System.Data.Common.DataColumnMapping("FirstName", "FirstName")})});
			this.daEmployees.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM Employees WHERE (EmployeeID = @Original_EmployeeID) AND (FirstName = " +
				"@Original_FirstName) AND (LastName = @Original_LastName)";
			this.sqlDeleteCommand1.Connection = this.sqlCnNorthwind;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			// 
			// sqlCnNorthwind
			// 
			this.sqlCnNorthwind.ConnectionString = "workstation id=WP;packet size=4096;integrated security=SSPI;data source=\".\";persi" +
				"st security info=False;initial catalog=Northwind";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO Employees(LastName, FirstName) VALUES (@LastName, @FirstName); SELECT" +
				" EmployeeID, LastName, FirstName FROM Employees WHERE (EmployeeID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlCnNorthwind;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT EmployeeID, LastName, FirstName FROM Employees";
			this.sqlSelectCommand1.Connection = this.sqlCnNorthwind;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Employees SET LastName = @LastName, FirstName = @FirstName WHERE (EmployeeID = @Original_EmployeeID) AND (FirstName = @Original_FirstName) AND (LastName = @Original_LastName); SELECT EmployeeID, LastName, FirstName FROM Employees WHERE (EmployeeID = @EmployeeID)";
			this.sqlUpdateCommand1.Connection = this.sqlCnNorthwind;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
			// 
			// daCustomers
			// 
			this.daCustomers.DeleteCommand = this.sqlDeleteCommand2;
			this.daCustomers.InsertCommand = this.sqlInsertCommand2;
			this.daCustomers.SelectCommand = this.sqlSelectCommand2;
			this.daCustomers.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								  new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
																																																			   new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
																																																			   new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
																																																			   new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
																																																			   new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
																																																			   new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																			   new System.Data.Common.DataColumnMapping("City", "City"),
																																																			   new System.Data.Common.DataColumnMapping("Region", "Region"),
																																																			   new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
																																																			   new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																			   new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																			   new System.Data.Common.DataColumnMapping("Fax", "Fax")})});
			this.daCustomers.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM Customers WHERE (CustomerID = @Original_CustomerID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlCnNorthwind;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = @"INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax); SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)";
			this.sqlInsertCommand2.Connection = this.sqlCnNorthwind;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
				" PostalCode, Country, Phone, Fax FROM Customers";
			this.sqlSelectCommand2.Connection = this.sqlCnNorthwind;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, Phone = @Phone, Fax = @Fax WHERE (CustomerID = @Original_CustomerID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL); SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)";
			this.sqlUpdateCommand2.Connection = this.sqlCnNorthwind;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// daOrders
			// 
			this.daOrders.DeleteCommand = this.sqlDeleteCommand3;
			this.daOrders.InsertCommand = this.sqlInsertCommand3;
			this.daOrders.SelectCommand = this.sqlSelectCommand3;
			this.daOrders.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							   new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
																																																		 new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
																																																		 new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
																																																		 new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
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
																																																		 new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
			this.daOrders.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sqlDeleteCommand3
			// 
			this.sqlDeleteCommand3.CommandText = @"DELETE FROM Orders WHERE (OrderID = @Original_OrderID) AND (CustomerID = @Original_CustomerID OR @Original_CustomerID IS NULL AND CustomerID IS NULL) AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND EmployeeID IS NULL) AND (Freight = @Original_Freight OR @Original_Freight IS NULL AND Freight IS NULL) AND (OrderDate = @Original_OrderDate OR @Original_OrderDate IS NULL AND OrderDate IS NULL) AND (RequiredDate = @Original_RequiredDate OR @Original_RequiredDate IS NULL AND RequiredDate IS NULL) AND (ShipAddress = @Original_ShipAddress OR @Original_ShipAddress IS NULL AND ShipAddress IS NULL) AND (ShipCity = @Original_ShipCity OR @Original_ShipCity IS NULL AND ShipCity IS NULL) AND (ShipCountry = @Original_ShipCountry OR @Original_ShipCountry IS NULL AND ShipCountry IS NULL) AND (ShipName = @Original_ShipName OR @Original_ShipName IS NULL AND ShipName IS NULL) AND (ShipPostalCode = @Original_ShipPostalCode OR @Original_ShipPostalCode IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = @Original_ShipRegion OR @Original_ShipRegion IS NULL AND ShipRegion IS NULL) AND (ShipVia = @Original_ShipVia OR @Original_ShipVia IS NULL AND ShipVia IS NULL) AND (ShippedDate = @Original_ShippedDate OR @Original_ShippedDate IS NULL AND ShippedDate IS NULL)";
			this.sqlDeleteCommand3.Connection = this.sqlCnNorthwind;
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = @"INSERT INTO Orders(CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) VALUES (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry); SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders WHERE (OrderID = @@IDENTITY)";
			this.sqlInsertCommand3.Connection = this.sqlCnNorthwind;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" +
				"pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" +
				"Country FROM Orders";
			this.sqlSelectCommand3.Connection = this.sqlCnNorthwind;
			// 
			// sqlUpdateCommand3
			// 
			this.sqlUpdateCommand3.CommandText = "UPDATE Orders SET CustomerID = @CustomerID, EmployeeID = @EmployeeID, OrderDate =" +
				" @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, ShipVia =" +
				" @ShipVia, Freight = @Freight, ShipName = @ShipName, ShipAddress = @ShipAddress," +
				" ShipCity = @ShipCity, ShipRegion = @ShipRegion, ShipPostalCode = @ShipPostalCod" +
				"e, ShipCountry = @ShipCountry WHERE (OrderID = @Original_OrderID) AND (CustomerI" +
				"D = @Original_CustomerID OR @Original_CustomerID IS NULL AND CustomerID IS NULL)" +
				" AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND Empl" +
				"oyeeID IS NULL) AND (Freight = @Original_Freight OR @Original_Freight IS NULL AN" +
				"D Freight IS NULL) AND (OrderDate = @Original_OrderDate OR @Original_OrderDate I" +
				"S NULL AND OrderDate IS NULL) AND (RequiredDate = @Original_RequiredDate OR @Ori" +
				"ginal_RequiredDate IS NULL AND RequiredDate IS NULL) AND (ShipAddress = @Origina" +
				"l_ShipAddress OR @Original_ShipAddress IS NULL AND ShipAddress IS NULL) AND (Shi" +
				"pCity = @Original_ShipCity OR @Original_ShipCity IS NULL AND ShipCity IS NULL) A" +
				"ND (ShipCountry = @Original_ShipCountry OR @Original_ShipCountry IS NULL AND Shi" +
				"pCountry IS NULL) AND (ShipName = @Original_ShipName OR @Original_ShipName IS NU" +
				"LL AND ShipName IS NULL) AND (ShipPostalCode = @Original_ShipPostalCode OR @Orig" +
				"inal_ShipPostalCode IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = @Origi" +
				"nal_ShipRegion OR @Original_ShipRegion IS NULL AND ShipRegion IS NULL) AND (Ship" +
				"Via = @Original_ShipVia OR @Original_ShipVia IS NULL AND ShipVia IS NULL) AND (S" +
				"hippedDate = @Original_ShippedDate OR @Original_ShippedDate IS NULL AND ShippedD" +
				"ate IS NULL); SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, S" +
				"hippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipP" +
				"ostalCode, ShipCountry FROM Orders WHERE (OrderID = @OrderID)";
			this.sqlUpdateCommand3.Connection = this.sqlCnNorthwind;
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"));
			// 
			// dsMaster1
			// 
			this.dsMaster1.DataSetName = "dsMaster1";
			this.dsMaster1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// dvOrders
			// 
			this.dvOrders.Sort = "OrderID";
			this.dvOrders.Table = this.dsMaster1.Orders;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(528, 258);
			this.Controls.Add(this.dgOrders);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "DataViews";
			((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMaster1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dvOrders)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//创建数据视图
			System.Data.DataView dvNew;
			dvNew = new System.Data.DataView();
			//配置数据视图
			dvNew.Table=this.dsMaster1.Orders;
			dvNew.RowFilter="EmployeeID=1";

			//重新绑定数据网格
			this.dgOrders.DataSource = dvNew;

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//更改排序顺序，首先对EmployeeID升序排序，然后对CustomerID升序排序，最后对OrderID降序排序
			this.dvOrders.Sort = "EmployeeID,CustomerID,OrderID DESC";
			//刷新数据网格
			this.dgOrders.Refresh();

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			System.Data.DataRowView drNew;
			//添加新行
			drNew = this.dvOrders.AddNew();
			drNew["CustomerID"] = "AFLKI";
			drNew["EmployeeID"] = 1;
			drNew["OrderID"] = 0;

			//设置行状态过滤器
			this.dvOrders.RowStateFilter = DataViewRowState.Added;
			//刷新数据网格
			this.dgOrders.Refresh();

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			int idxFound;
			string strMessage;
            idxFound = this.dvOrders.Find(10259);
			strMessage = "This OrderID is" + this.dvOrders[idxFound]["OrderID"];
			strMessage += "\nThe CustomerID is " + this.dvOrders[idxFound]["CustomerID"];
			strMessage += "\nThe EmployeeID is " + this.dvOrders[idxFound]["EmployeeID"];
			MessageBox.Show(strMessage);

		}
	}
}
