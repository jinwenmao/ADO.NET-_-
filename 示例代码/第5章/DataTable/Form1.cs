using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataTable
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Data.SqlClient.SqlDataAdapter daEmployees;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlCnNorthwind;
		private DataTable.dsEmployees dsEmployees;
		private System.Data.SqlClient.SqlDataAdapter daProducts;
		private System.Data.SqlClient.SqlDataAdapter daSupplier;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		private System.Data.DataSet dsUntyped;
		private DataTable.dsProducts dsProducts;
		private DataTable.dsSuppliers dsSuppliers;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.DataTable dtMain;
		private System.Data.DataTable dtSecond;
		private System.Data.DataColumn MainID;
		private System.Data.DataColumn MainValue;
		private System.Data.DataColumn SecondID;
		private System.Data.DataColumn MainLink;
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.daEmployees = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlCnNorthwind = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dsEmployees = new DataTable.dsEmployees();
			this.daProducts = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.daSupplier = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.dsUntyped = new System.Data.DataSet();
			this.dsProducts = new DataTable.dsProducts();
			this.dsSuppliers = new DataTable.dsSuppliers();
			this.dtMain = new System.Data.DataTable();
			this.dtSecond = new System.Data.DataTable();
			this.MainID = new System.Data.DataColumn();
			this.MainValue = new System.Data.DataColumn();
			this.SecondID = new System.Data.DataColumn();
			this.MainLink = new System.Data.DataColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsUntyped)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsSuppliers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtSecond)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(440, 272);
			this.dataGrid1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(480, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "创建表";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(480, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "数据集中创建表";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(480, 80);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 24);
			this.button3.TabIndex = 3;
			this.button3.Text = "创建计算列";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(480, 112);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "添加行";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(480, 144);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 23);
			this.button5.TabIndex = 5;
			this.button5.Text = "外键约束";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(480, 176);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(112, 23);
			this.button6.TabIndex = 6;
			this.button6.Text = "唯一约束";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(480, 208);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(112, 23);
			this.button7.TabIndex = 7;
			this.button7.Text = "查询";
			this.button7.Click += new System.EventHandler(this.button7_Click);
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
			// dsEmployees
			// 
			this.dsEmployees.DataSetName = "dsEmployees";
			this.dsEmployees.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// daProducts
			// 
			this.daProducts.DeleteCommand = this.sqlDeleteCommand2;
			this.daProducts.InsertCommand = this.sqlInsertCommand2;
			this.daProducts.SelectCommand = this.sqlSelectCommand2;
			this.daProducts.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								 new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
																																																			 new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																			 new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
																																																			 new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
																																																			 new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID")})});
			this.daProducts.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM Products WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (ProductName = @Original_ProductName) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlCnNorthwind;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO Products(ProductName, SupplierID, CategoryID) VALUES (@ProductName, @" +
				"SupplierID, @CategoryID); SELECT ProductID, ProductName, SupplierID, CategoryID " +
				"FROM Products WHERE (ProductID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.sqlCnNorthwind;
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT ProductID, ProductName FROM Products";
			this.sqlSelectCommand2.Connection = this.sqlCnNorthwind;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE Products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (ProductName = @Original_ProductName) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL); SELECT ProductID, ProductName, SupplierID, CategoryID FROM Products WHERE (ProductID = @ProductID)";
			this.sqlUpdateCommand2.Connection = this.sqlCnNorthwind;
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"));
			// 
			// daSupplier
			// 
			this.daSupplier.DeleteCommand = this.sqlDeleteCommand3;
			this.daSupplier.InsertCommand = this.sqlInsertCommand3;
			this.daSupplier.SelectCommand = this.sqlSelectCommand3;
			this.daSupplier.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								 new System.Data.Common.DataTableMapping("Table", "Suppliers", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
																																																			  new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
																																																			  new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
																																																			  new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
																																																			  new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																			  new System.Data.Common.DataColumnMapping("City", "City"),
																																																			  new System.Data.Common.DataColumnMapping("Region", "Region"),
																																																			  new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
																																																			  new System.Data.Common.DataColumnMapping("Country", "Country"),
																																																			  new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																			  new System.Data.Common.DataColumnMapping("Fax", "Fax"),
																																																			  new System.Data.Common.DataColumnMapping("HomePage", "HomePage")})});
			this.daSupplier.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sqlDeleteCommand3
			// 
			this.sqlDeleteCommand3.CommandText = @"DELETE FROM Suppliers WHERE (SupplierID = @Original_SupplierID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL)";
			this.sqlDeleteCommand3.Connection = this.sqlCnNorthwind;
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = @"INSERT INTO Suppliers(CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) VALUES (@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax, @HomePage); SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers WHERE (SupplierID = @@IDENTITY)";
			this.sqlInsertCommand3.Connection = this.sqlCnNorthwind;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HomePage", System.Data.SqlDbType.NVarChar, 1073741823, "HomePage"));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
				" PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
			this.sqlSelectCommand3.Connection = this.sqlCnNorthwind;
			// 
			// sqlUpdateCommand3
			// 
			this.sqlUpdateCommand3.CommandText = @"UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, Phone = @Phone, Fax = @Fax, HomePage = @HomePage WHERE (SupplierID = @Original_SupplierID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL); SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers WHERE (SupplierID = @SupplierID)";
			this.sqlUpdateCommand3.Connection = this.sqlCnNorthwind;
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HomePage", System.Data.SqlDbType.NVarChar, 1073741823, "HomePage"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CompanyName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ContactTitle", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Country", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PostalCode", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Region", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			// 
			// dsUntyped
			// 
			this.dsUntyped.DataSetName = "NewDataSet";
			this.dsUntyped.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.dsUntyped.Tables.AddRange(new System.Data.DataTable[] {
																		   this.dtMain,
																		   this.dtSecond});
			// 
			// dsProducts
			// 
			this.dsProducts.DataSetName = "dsProducts";
			this.dsProducts.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// dsSuppliers
			// 
			this.dsSuppliers.DataSetName = "dsSuppliers";
			this.dsSuppliers.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// dtMain
			// 
			this.dtMain.Columns.AddRange(new System.Data.DataColumn[] {
																		  this.MainID,
																		  this.MainValue});
			this.dtMain.TableName = "dtMain";
			// 
			// dtSecond
			// 
			this.dtSecond.Columns.AddRange(new System.Data.DataColumn[] {
																			this.SecondID,
																			this.MainLink});
			this.dtSecond.TableName = "dtSecond";
			// 
			// MainID
			// 
			this.MainID.ColumnName = "MainID";
			this.MainID.DataType = typeof(int);
			// 
			// MainValue
			// 
			this.MainValue.Caption = "MainValue";
			this.MainValue.ColumnName = "MainValue";
			// 
			// SecondID
			// 
			this.SecondID.ColumnName = "SecondID";
			this.SecondID.DataType = typeof(int);
			// 
			// MainLink
			// 
			this.MainLink.ColumnName = "MainLink";
			this.MainLink.DataType = typeof(int);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(616, 290);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGrid1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsUntyped)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsSuppliers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtMain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtSecond)).EndInit();
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

		private void button5_Click(object sender, System.EventArgs e)
		{
			//创建外键约束
			System.Data.ForeignKeyConstraint fkNew;
		
			fkNew = new System.Data.ForeignKeyConstraint("MyFK",this.dsUntyped.Tables["dtMain"].Columns["MainID"],this.dsUntyped.Tables["dtSecond"].Columns["MainLink"]);
			//添加外键约束
			this.dsUntyped.Tables["dtSecond"].Constraints.Add(fkNew);
			
			string strMessage;
			strMessage = "新的约束名称为：  ";
			strMessage +=this.dsUntyped.Tables["dtSecond"].Constraints[0].ConstraintName.ToString();
			MessageBox.Show(strMessage);

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string strMessage;
			//创建表
			System.Data.DataTable dtEmployees;
			dtEmployees = new System.Data.DataTable("Employees");
			strMessage  = "添加的表名为：";
			strMessage  += dtEmployees.TableName.ToString();
			MessageBox.Show(strMessage);

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string strMessage;
			//数据集中创建表
			this.dsUntyped.Tables.Add("TableTest");
			strMessage  = "表名为：";
			strMessage  +=  this.dsUntyped.Tables[0].TableName.ToString();
			MessageBox.Show(strMessage);
			
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			
			//用来自数据集的数据进行填充
			this.daEmployees.Fill(this.dsEmployees.Tables[0]);

			//创建列
			System.Data.DataColumn dcName;
			dcName = new System.Data.DataColumn("Name");
			dcName.DataType = System.Type.GetType("System.String");
			dcName.Expression = "FirstName+' '+LastName";

			//添加计算列
			this.dsEmployees.Tables["Employees"].Columns.Add(dcName);

			//绑定到数据网格
			dataGrid1.DataSource = dsEmployees.Tables[0];


		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			//用来自数据集的数据进行填充
			this.daProducts.Fill(this.dsProducts.Tables[0]);

			//创建新行
			System.Data.DataRow drNew;
			drNew = this.dsProducts.Products.NewRow();
			drNew["ProductID"] = "100";
			drNew["ProductName"] = "Car";

			//将行添加到表中
			this. dsProducts.Products.Rows.Add(drNew);
			//刷新显示
			this.dataGrid1.DataSource=this.dsProducts.Tables[0];
			this.dataGrid1.Refresh();

		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			//创建唯一约束
			System.Data.UniqueConstraint ucNew;
			ucNew = new System.Data.UniqueConstraint("MyUnique",this.dsUntyped.Tables["dtMain"].Columns["MainValue"]);
			
			//添加唯一约束
			this.dsUntyped.Tables["dtMain"].Constraints.Add(ucNew);

			string strMessage;
			strMessage = "新的约束名称为： ";
			strMessage +=this.dsUntyped.Tables["dtMain"].Constraints["MyUnique"].ConstraintName.ToString();
			MessageBox.Show(strMessage);

		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			//填充数据集
			this.daEmployees.Fill(this.dsEmployees);
			//创建一个数据行对象
			System.Data.DataRow[] drFound;
			drFound = this.dsEmployees.Employees.Select("FirstName LIKE" + "'M*'");
			//循环查找满足条件的数据行
			string strMessage = "结果为：";
			foreach(System.Data.DataRow dr in drFound)
			{
				strMessage += dr["FirstName"] + ",";
			}
			MessageBox.Show(strMessage);

		}
	}
}
