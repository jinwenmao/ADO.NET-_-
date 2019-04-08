using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataAdapters
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGrid dgEmployees;
		private System.Windows.Forms.DataGrid dgCustomers;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter daEmployees;
		private System.Data.SqlClient.SqlDataAdapter daCustomers;

		//表明了4个Command对象和数据适配器
		private System.Data.SqlClient.SqlCommand cmdSelectEmployees;
		private System.Data.SqlClient.SqlCommand cmdInsertEmployees;
		private System.Data.SqlClient.SqlCommand cmdUpdateEmployees;
		private System.Data.SqlClient.SqlCommand cmdDeleteEmployees;
		private System.Data.SqlClient.SqlDataAdapter daEmp;



		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private DataAdapters.dsEmployees dsEmployees;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private DataAdapters.dsCoustomers dsCustomers;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button3;


		
		private void daEmployees_RowUpdating(object sender,System.Data.SqlClient.SqlRowUpdatingEventArgs e)
		{			
			string strMsg;
			
			//响应OnRowUpdating事件，查看RowUpdatingEventArgs属性
			strMsg = "开始更新......";
			strMsg += "\n数据库中的记录正在被修改。";
			MessageBox.Show(strMsg);
		}

		private void daEmployees_RowUpdated(object sender,System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{			
			string strMsg;
			
			//响应OnRowUpdated事件，查看RowUpdatedEventArgs属性
			strMsg = "更新完成。";
			strMsg += "\n数据库中的记录已经被修改。";
			MessageBox.Show(strMsg);			
		}

		


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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dgEmployees = new System.Windows.Forms.DataGrid();
			this.dgCustomers = new System.Windows.Forms.DataGrid();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.daEmployees = new System.Data.SqlClient.SqlDataAdapter();
			this.daCustomers = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dsEmployees = new DataAdapters.dsEmployees();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.dsCustomers = new DataAdapters.dsCoustomers();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(400, 224);
			this.tabControl1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(424, 40);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "填  充";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(424, 88);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "更  新";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dgEmployees);
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(392, 199);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Employees";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dgCustomers);
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(392, 199);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Customers";
			// 
			// dgEmployees
			// 
			this.dgEmployees.DataMember = "Employees";
			this.dgEmployees.DataSource = this.dsEmployees;
			this.dgEmployees.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgEmployees.Location = new System.Drawing.Point(8, 8);
			this.dgEmployees.Name = "dgEmployees";
			this.dgEmployees.Size = new System.Drawing.Size(376, 184);
			this.dgEmployees.TabIndex = 0;
			// 
			// dgCustomers
			// 
			this.dgCustomers.DataMember = "Customers";
			this.dgCustomers.DataSource = this.dsCustomers;
			this.dgCustomers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgCustomers.Location = new System.Drawing.Point(8, 8);
			this.dgCustomers.Name = "dgCustomers";
			this.dgCustomers.Size = new System.Drawing.Size(376, 184);
			this.dgCustomers.TabIndex = 0;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=WP;packet size=4096;integrated security=SSPI;data source=\".\";persi" +
				"st security info=False;initial catalog=Northwind";
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
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT EmployeeID, LastName, FirstName FROM Employees";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO Employees(LastName, FirstName) VALUES (@LastName, @FirstName); SELECT" +
				" EmployeeID, LastName, FirstName FROM Employees WHERE (EmployeeID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Employees SET LastName = @LastName, FirstName = @FirstName WHERE (EmployeeID = @Original_EmployeeID) AND (FirstName = @Original_FirstName) AND (LastName = @Original_LastName); SELECT EmployeeID, LastName, FirstName FROM Employees WHERE (EmployeeID = @EmployeeID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM Employees WHERE (EmployeeID = @Original_EmployeeID) AND (FirstName = " +
				"@Original_FirstName) AND (LastName = @Original_LastName)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			// 
			// dsEmployees
			// 
			this.dsEmployees.DataSetName = "dsEmployees";
			this.dsEmployees.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," +
				" PostalCode, Country, Phone, Fax FROM Customers";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = @"INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax); SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)";
			this.sqlInsertCommand2.Connection = this.sqlConnection1;
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
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = @"UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, Phone = @Phone, Fax = @Fax WHERE (CustomerID = @Original_CustomerID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL); SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)";
			this.sqlUpdateCommand2.Connection = this.sqlConnection1;
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
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = @"DELETE FROM Customers WHERE (CustomerID = @Original_CustomerID) AND (Address = @Original_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Original_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Original_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Original_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original_Region OR @Original_Region IS NULL AND Region IS NULL)";
			this.sqlDeleteCommand2.Connection = this.sqlConnection1;
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
			// dsCustomers
			// 
			this.dsCustomers.DataSetName = "dsCoustomers";
			this.dsCustomers.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(96, 248);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(168, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "运行时创建数据适配器";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 272);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(168, 56);
			this.dataGrid1.TabIndex = 4;
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(184, 272);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(152, 52);
			this.listBox1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(512, 242);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
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
			this.dsEmployees.Clear();
			this.dsCustomers.Clear();

            //填充来自数据适配器的每一个数据集
			this.daEmployees.Fill(this.dsEmployees.Employees);
			this.daCustomers.Fill(this.dsCustomers.Customers);


		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//更新数据源
			this.daEmployees.Update(this.dsEmployees.Employees);

			//响应更新中的事件处理程序
			this.daEmployees.RowUpdating += new System.Data.SqlClient.SqlRowUpdatingEventHandler(daEmployees_RowUpdating);

			//响应更新完成的事件处理程序
            this.daEmployees.RowUpdated  += new System.Data.SqlClient.SqlRowUpdatedEventHandler(daEmployees_RowUpdated);
			
		}

		

		private void button3_Click(object sender, System.EventArgs e)
		{
			
			//使用默认的构造函数实例化每个对象
			this.cmdDeleteEmployees = new System.Data.SqlClient.SqlCommand();
			this.cmdInsertEmployees = new System.Data.SqlClient.SqlCommand();
			this.cmdSelectEmployees = new System.Data.SqlClient.SqlCommand();
			this.cmdUpdateEmployees = new System.Data.SqlClient.SqlCommand();
			
			this.daEmp = new System.Data.SqlClient.SqlDataAdapter();
			
			//把4个Command对象赋给daEmpdaEmployees数据适配器
			this.daEmp.DeleteCommand = this.cmdDeleteEmployees;
			this.daEmp.InsertCommand = this.cmdInsertEmployees;
			this.daEmp.SelectCommand = this.cmdSelectEmployees;
			this.daEmp.UpdateCommand = this.cmdUpdateEmployees;

			

			//在代码中设置CommandText
			this.cmdSelectEmployees.CommandText = "select firstname from Employees";
			this.cmdSelectEmployees.Connection = this.sqlConnection1;
			this.cmdSelectEmployees.CommandType=CommandType.Text;

			/*//数据阅读器，添加一个listBox1用于显示数据
			this.sqlConnection1.Open();
			System.Data.SqlClient.SqlDataReader drEmp;
			drEmp=this.daEmp.SelectCommand.ExecuteReader();
			while(drEmp.Read())
				this.listBox1.Items.Add(drEmp.GetString(0));
			drEmp.Close();
            this.sqlConnection1.Close();		
			*/

			/*//数据集，添加一个dataGrid1用于显示数据
			System.Data.DataSet dsEmp;
			dsEmp=new System.Data.DataSet("dsEmp");			
			this.daEmp.Fill(dsEmp);
			this.dataGrid1.DataSource=dsEmp.Tables[0];
			this.dataGrid1.Refresh();
			*/
			
		}
	}
}
