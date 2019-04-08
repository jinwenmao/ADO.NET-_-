using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ExamDataSets
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
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.SqlClient.SqlDataAdapter daEmployee;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection cnNorthwind;
		private System.Data.SqlClient.SqlDataAdapter daSupplier;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.SqlClient.SqlDataAdapter daProducts;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
		private ExamDataSets.dsMain dsMain1;
		private System.Data.DataSet dsNew;
		private System.Data.DataSet dsProducts;
		private System.Data.DataTable dtMain;
		private System.Data.DataColumn MainID;
		private System.Data.DataColumn MainValue;
		private System.Data.DataTable dtSecond;
		private System.Data.DataColumn SecondID;
		private System.Data.DataColumn MainLink;
		private System.Data.DataColumn ThirdValue;
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
			dsProducts=new System.Data.DataSet("dsProducts");
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.daEmployee = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.cnNorthwind = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.daSupplier = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.daProducts = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
			this.dsMain1 = new ExamDataSets.dsMain();
			this.dsNew = new System.Data.DataSet();
			this.dtMain = new System.Data.DataTable();
			this.MainID = new System.Data.DataColumn();
			this.MainValue = new System.Data.DataColumn();
			this.dtSecond = new System.Data.DataTable();
			this.SecondID = new System.Data.DataColumn();
			this.MainLink = new System.Data.DataColumn();
			this.ThirdValue = new System.Data.DataColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMain1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsNew)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtMain)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtSecond)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(399, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "创建表";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(399, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "创建关系";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(399, 104);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "克隆数据集";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(399, 144);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "复制数据集";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 24);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(368, 264);
			this.dataGrid1.TabIndex = 4;
			// 
			// daEmployee
			// 
			this.daEmployee.DeleteCommand = this.sqlDeleteCommand1;
			this.daEmployee.InsertCommand = this.sqlInsertCommand1;
			this.daEmployee.SelectCommand = this.sqlSelectCommand1;
			this.daEmployee.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								 new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																			  new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																			  new System.Data.Common.DataColumnMapping("FirstName", "FirstName")})});
			this.daEmployee.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM Employees WHERE (EmployeeID = @Original_EmployeeID) AND (FirstName = " +
				"@Original_FirstName) AND (LastName = @Original_LastName)";
			this.sqlDeleteCommand1.Connection = this.cnNorthwind;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			// 
			// cnNorthwind
			// 
			this.cnNorthwind.ConnectionString = "workstation id=WP;packet size=4096;integrated security=SSPI;data source=\".\";persi" +
				"st security info=False;initial catalog=Northwind";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO Employees(LastName, FirstName) VALUES (@LastName, @FirstName); SELECT" +
				" EmployeeID, LastName, FirstName FROM Employees WHERE (EmployeeID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.cnNorthwind;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT EmployeeID, LastName, FirstName FROM Employees";
			this.sqlSelectCommand1.Connection = this.cnNorthwind;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Employees SET LastName = @LastName, FirstName = @FirstName WHERE (EmployeeID = @Original_EmployeeID) AND (FirstName = @Original_FirstName) AND (LastName = @Original_LastName); SELECT EmployeeID, LastName, FirstName FROM Employees WHERE (EmployeeID = @EmployeeID)";
			this.sqlUpdateCommand1.Connection = this.cnNorthwind;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
			// 
			// daSupplier
			// 
			this.daSupplier.DeleteCommand = this.sqlDeleteCommand2;
			this.daSupplier.InsertCommand = this.sqlInsertCommand2;
			this.daSupplier.SelectCommand = this.sqlSelectCommand2;
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
			this.daSupplier.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM Suppliers WHERE (SupplierID = @Original_SupplierID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL)";
			this.sqlDeleteCommand2.Connection = this.cnNorthwind;
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
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
			this.sqlInsertCommand2.CommandText = @"INSERT INTO Suppliers(CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) VALUES (@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax, @HomePage); SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers WHERE (SupplierID = @@IDENTITY)";
			this.sqlInsertCommand2.Connection = this.cnNorthwind;
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
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HomePage", System.Data.SqlDbType.NVarChar, 1073741823, "HomePage"));
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
				" PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
			this.sqlSelectCommand2.Connection = this.cnNorthwind;
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, Phone = @Phone, Fax = @Fax, HomePage = @HomePage WHERE (SupplierID = @Original_SupplierID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL); SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers WHERE (SupplierID = @SupplierID)";
			this.sqlUpdateCommand2.Connection = this.cnNorthwind;
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
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@HomePage", System.Data.SqlDbType.NVarChar, 1073741823, "HomePage"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
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
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			// 
			// daProducts
			// 
			this.daProducts.DeleteCommand = this.sqlDeleteCommand3;
			this.daProducts.InsertCommand = this.sqlInsertCommand3;
			this.daProducts.SelectCommand = this.sqlSelectCommand3;
			this.daProducts.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								 new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
																																																			 new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																			 new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
																																																			 new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
																																																			 new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
																																																			 new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
																																																			 new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
																																																			 new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
																																																			 new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
																																																			 new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
																																																			 new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})});
			this.daProducts.UpdateCommand = this.sqlUpdateCommand3;
			// 
			// sqlDeleteCommand3
			// 
			this.sqlDeleteCommand3.CommandText = @"DELETE FROM Products WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (Discontinued = @Original_Discontinued) AND (ProductName = @Original_ProductName) AND (QuantityPerUnit = @Original_QuantityPerUnit OR @Original_QuantityPerUnit IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = @Original_ReorderLevel OR @Original_ReorderLevel IS NULL AND ReorderLevel IS NULL) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL) AND (UnitPrice = @Original_UnitPrice OR @Original_UnitPrice IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = @Original_UnitsInStock OR @Original_UnitsInStock IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = @Original_UnitsOnOrder OR @Original_UnitsOnOrder IS NULL AND UnitsOnOrder IS NULL)";
			this.sqlDeleteCommand3.Connection = this.cnNorthwind;
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = @"INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued); SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE (ProductID = @@IDENTITY)";
			this.sqlInsertCommand3.Connection = this.cnNorthwind;
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"));
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" +
				", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
			this.sqlSelectCommand3.Connection = this.cnNorthwind;
			// 
			// sqlUpdateCommand3
			// 
			this.sqlUpdateCommand3.CommandText = @"UPDATE Products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, UnitsOnOrder = @UnitsOnOrder, ReorderLevel = @ReorderLevel, Discontinued = @Discontinued WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (Discontinued = @Original_Discontinued) AND (ProductName = @Original_ProductName) AND (QuantityPerUnit = @Original_QuantityPerUnit OR @Original_QuantityPerUnit IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = @Original_ReorderLevel OR @Original_ReorderLevel IS NULL AND ReorderLevel IS NULL) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL) AND (UnitPrice = @Original_UnitPrice OR @Original_UnitPrice IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = @Original_UnitsInStock OR @Original_UnitsInStock IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = @Original_UnitsOnOrder OR @Original_UnitsOnOrder IS NULL AND UnitsOnOrder IS NULL); SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE (ProductID = @ProductID)";
			this.sqlUpdateCommand3.Connection = this.cnNorthwind;
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Discontinued", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ReorderLevel", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "SupplierID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsInStock", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"));
			// 
			// dsMain1
			// 
			this.dsMain1.DataSetName = "dsMain";
			this.dsMain1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// dsNew
			// 
			this.dsNew.DataSetName = "dsNew";
			this.dsNew.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.dsNew.Tables.AddRange(new System.Data.DataTable[] {
																	   this.dtMain,
																	   this.dtSecond});
			// 
			// dtMain
			// 
			this.dtMain.Columns.AddRange(new System.Data.DataColumn[] {
																		  this.MainID,
																		  this.MainValue});
			this.dtMain.Constraints.AddRange(new System.Data.Constraint[] {
																			  new System.Data.UniqueConstraint("Constraint1", new string[] {
																																			   "MainID"}, false)});
			this.dtMain.TableName = "dtMain";
			// 
			// MainID
			// 
			this.MainID.Caption = "MainID";
			this.MainID.ColumnName = "MainID";
			this.MainID.DataType = typeof(int);
			// 
			// MainValue
			// 
			this.MainValue.Caption = "MainValue";
			this.MainValue.ColumnName = "MainValue";
			// 
			// dtSecond
			// 
			this.dtSecond.Columns.AddRange(new System.Data.DataColumn[] {
																			this.SecondID,
																			this.MainLink,
																			this.ThirdValue});
			this.dtSecond.Constraints.AddRange(new System.Data.Constraint[] {
																				new System.Data.ForeignKeyConstraint("MainChild", "dtMain", new string[] {
																																							 "MainID"}, new string[] {
																																														 "MainLink"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
			this.dtSecond.TableName = "dtSecond";
			// 
			// SecondID
			// 
			this.SecondID.Caption = "SecondID";
			this.SecondID.ColumnName = "SecondID";
			this.SecondID.DataType = typeof(int);
			// 
			// MainLink
			// 
			this.MainLink.Caption = "MainLink";
			this.MainLink.ColumnName = "MainLink";
			this.MainLink.DataType = typeof(int);
			// 
			// ThirdValue
			// 
			this.ThirdValue.Caption = "ThirdValue";
			this.ThirdValue.ColumnName = "ThirdValue";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(520, 298);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsMain1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsNew)).EndInit();
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			string strMessage;
			
			//创建表
			System.Data.DataTable dtEmployees;
			dtEmployees=this.dsNew.Tables.Add("Employees");

			//添加列
			dtEmployees.Columns.Add("EmployeeID",Type.GetType("System.Int32"));
			dtEmployees.Columns.Add("FirstName",Type.GetType("System.String"));
			dtEmployees.Columns.Add("LastName",Type.GetType("System.String"));

			//填充数据库
            this.daEmployee.Fill(this.dsNew.Tables["Employees"]);
			strMessage="第一个雇员是：";
			strMessage+=this.dsNew.Tables["Employees"].Rows[0]["LastName"];
			MessageBox.Show(strMessage);



		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string strMessage;

			//第一种方法：
			//创建一个关系对象并实例化
			System.Data.DataRelation draNew;
			draNew=new DataRelation("MainChild",this.dsNew.Tables["dtMain"].Columns["MainID"],this.dsNew.Tables["dtSecond"].Columns["MainLink"]);
			//将这个关系对象添加到非类型化数据集中
			this.dsNew.Relations.Add(draNew);

			//第二种方法：
			//直接调用数据集的Add方法添加一个新关系
			//this.dsNew.Relations.Add("MainChild",this.dsNew.Tables["dtMain"].Columns["MainID"],this.dsNew.Tables["dtSecond"].Columns["MainLink"]);

			//显示关系
			strMessage="关系是：";
			strMessage+=this.dsNew.Relations[0].RelationName.ToString();
			MessageBox.Show(strMessage);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			string strMessage;
			System.Data.DataSet dsClone;
			dsClone=this.dsMain1.Clone();
			strMessage="克隆的数据集中包含";
			strMessage+=dsClone.Tables.Count.ToString();
			strMessage += "张表";
			MessageBox.Show(strMessage);

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			String strMessage;
			System.Data.DataSet dsCopy;
			//填充原始数据集
			this.daEmployee.Fill(this.dsMain1.Employees);
			dsCopy = this.dsMain1.Copy();
			strMessage = "复制的数据集中有";
			strMessage += dsCopy.Tables["Employees"].Rows.Count.ToString();
			strMessage += "行在Employees表中";
			MessageBox.Show(strMessage);

		}
	}
}
