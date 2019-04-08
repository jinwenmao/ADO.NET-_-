using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace EditSamples
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmEditData : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblSutID;
		private System.Windows.Forms.Label lblStuName;
		private System.Windows.Forms.Label lblSex;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox grpRowVer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStuID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtSex;
		private System.Windows.Forms.GroupBox grpRowStatus;
		private System.Windows.Forms.RadioButton rbtnUnchanged;
		private System.Windows.Forms.RadioButton rbtnModified;
		private System.Windows.Forms.TextBox txtOriginalName;
		private System.Windows.Forms.TextBox txtCurrentName;
		private System.Windows.Forms.TextBox txtCurrentID;
		private System.Windows.Forms.TextBox txtOriginalID;
		private System.Windows.Forms.TextBox txtCurrentSex;
		private System.Windows.Forms.TextBox txtOriginalSex;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnMoveNext;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnMoveForward;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCommand;
		private System.Windows.Forms.Button btnFill;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnReject;
		private System.Windows.Forms.Button btnDefer;
		private System.Data.SqlClient.SqlConnection cnStudent;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.RadioButton rbtnNew;
		private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.Label lblAddr;
		private System.Windows.Forms.TextBox txtAddr;
		private System.Windows.Forms.TextBox txtOriginalAddr;
		private System.Windows.Forms.TextBox txtCurrentAddr;
		private System.Data.SqlClient.SqlDataAdapter daStudent;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private EditSamples.dsStudent dsStudent1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmEditData()
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
			this.lblSutID = new System.Windows.Forms.Label();
			this.lblStuName = new System.Windows.Forms.Label();
			this.lblSex = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtStuID = new System.Windows.Forms.TextBox();
			this.dsStudent1 = new EditSamples.dsStudent();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSex = new System.Windows.Forms.TextBox();
			this.grpRowVer = new System.Windows.Forms.GroupBox();
			this.txtOriginalAddr = new System.Windows.Forms.TextBox();
			this.txtOriginalName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCurrentName = new System.Windows.Forms.TextBox();
			this.txtCurrentID = new System.Windows.Forms.TextBox();
			this.txtOriginalID = new System.Windows.Forms.TextBox();
			this.txtCurrentSex = new System.Windows.Forms.TextBox();
			this.txtOriginalSex = new System.Windows.Forms.TextBox();
			this.txtCurrentAddr = new System.Windows.Forms.TextBox();
			this.grpRowStatus = new System.Windows.Forms.GroupBox();
			this.rbtnNew = new System.Windows.Forms.RadioButton();
			this.rbtnModified = new System.Windows.Forms.RadioButton();
			this.rbtnUnchanged = new System.Windows.Forms.RadioButton();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnMoveNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnMoveForward = new System.Windows.Forms.Button();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCommand = new System.Windows.Forms.Button();
			this.btnFill = new System.Windows.Forms.Button();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnReject = new System.Windows.Forms.Button();
			this.btnDefer = new System.Windows.Forms.Button();
			this.cnStudent = new System.Data.SqlClient.SqlConnection();
			this.btnEdit = new System.Windows.Forms.Button();
			this.lblAddr = new System.Windows.Forms.Label();
			this.txtAddr = new System.Windows.Forms.TextBox();
			this.daStudent = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dsStudent1)).BeginInit();
			this.grpRowVer.SuspendLayout();
			this.grpRowStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSutID
			// 
			this.lblSutID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lblSutID.Location = new System.Drawing.Point(16, 16);
			this.lblSutID.Name = "lblSutID";
			this.lblSutID.Size = new System.Drawing.Size(56, 23);
			this.lblSutID.TabIndex = 0;
			this.lblSutID.Text = "学号";
			// 
			// lblStuName
			// 
			this.lblStuName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lblStuName.Location = new System.Drawing.Point(16, 72);
			this.lblStuName.Name = "lblStuName";
			this.lblStuName.Size = new System.Drawing.Size(56, 23);
			this.lblStuName.TabIndex = 1;
			this.lblStuName.Text = "姓名";
			// 
			// lblSex
			// 
			this.lblSex.Location = new System.Drawing.Point(208, 64);
			this.lblSex.Name = "lblSex";
			this.lblSex.Size = new System.Drawing.Size(48, 23);
			this.lblSex.TabIndex = 2;
			this.lblSex.Text = "性别：";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(528, 48);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(56, 23);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "添加";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtStuID
			// 
			this.txtStuID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsStudent1, "student.stu_id"));
			this.txtStuID.Location = new System.Drawing.Point(72, 16);
			this.txtStuID.Name = "txtStuID";
			this.txtStuID.TabIndex = 4;
			this.txtStuID.Text = "";
			// 
			// dsStudent1
			// 
			this.dsStudent1.DataSetName = "dsStudent";
			this.dsStudent1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsStudent1, "student.name"));
			this.txtName.Location = new System.Drawing.Point(72, 64);
			this.txtName.Name = "txtName";
			this.txtName.TabIndex = 5;
			this.txtName.Text = "";
			// 
			// txtSex
			// 
			this.txtSex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsStudent1, "student.sex"));
			this.txtSex.Location = new System.Drawing.Point(264, 64);
			this.txtSex.Name = "txtSex";
			this.txtSex.Size = new System.Drawing.Size(104, 21);
			this.txtSex.TabIndex = 6;
			this.txtSex.Text = "";
			// 
			// grpRowVer
			// 
			this.grpRowVer.Controls.Add(this.txtOriginalAddr);
			this.grpRowVer.Controls.Add(this.txtOriginalName);
			this.grpRowVer.Controls.Add(this.label2);
			this.grpRowVer.Controls.Add(this.label1);
			this.grpRowVer.Controls.Add(this.txtCurrentName);
			this.grpRowVer.Controls.Add(this.txtCurrentID);
			this.grpRowVer.Controls.Add(this.txtOriginalID);
			this.grpRowVer.Controls.Add(this.txtCurrentSex);
			this.grpRowVer.Controls.Add(this.txtOriginalSex);
			this.grpRowVer.Controls.Add(this.txtCurrentAddr);
			this.grpRowVer.Controls.Add(this.grpRowStatus);
			this.grpRowVer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.grpRowVer.Location = new System.Drawing.Point(0, 144);
			this.grpRowVer.Name = "grpRowVer";
			this.grpRowVer.Size = new System.Drawing.Size(488, 160);
			this.grpRowVer.TabIndex = 7;
			this.grpRowVer.TabStop = false;
			this.grpRowVer.Text = "行版本";
			this.grpRowVer.Enter += new System.EventHandler(this.grpRowVer_Enter);
			// 
			// txtOriginalAddr
			// 
			this.txtOriginalAddr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtOriginalAddr.Location = new System.Drawing.Point(296, 24);
			this.txtOriginalAddr.Name = "txtOriginalAddr";
			this.txtOriginalAddr.Size = new System.Drawing.Size(184, 21);
			this.txtOriginalAddr.TabIndex = 3;
			this.txtOriginalAddr.Text = "";
			// 
			// txtOriginalName
			// 
			this.txtOriginalName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtOriginalName.Location = new System.Drawing.Point(176, 24);
			this.txtOriginalName.Name = "txtOriginalName";
			this.txtOriginalName.Size = new System.Drawing.Size(72, 21);
			this.txtOriginalName.TabIndex = 2;
			this.txtOriginalName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "当前值：";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "初始值：";
			// 
			// txtCurrentName
			// 
			this.txtCurrentName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtCurrentName.Location = new System.Drawing.Point(176, 56);
			this.txtCurrentName.Name = "txtCurrentName";
			this.txtCurrentName.Size = new System.Drawing.Size(72, 21);
			this.txtCurrentName.TabIndex = 2;
			this.txtCurrentName.Text = "";
			// 
			// txtCurrentID
			// 
			this.txtCurrentID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtCurrentID.Location = new System.Drawing.Point(96, 56);
			this.txtCurrentID.Name = "txtCurrentID";
			this.txtCurrentID.Size = new System.Drawing.Size(56, 21);
			this.txtCurrentID.TabIndex = 2;
			this.txtCurrentID.Text = "";
			this.txtCurrentID.TextChanged += new System.EventHandler(this.txtCurrentID_TextChanged);
			// 
			// txtOriginalID
			// 
			this.txtOriginalID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtOriginalID.Location = new System.Drawing.Point(96, 24);
			this.txtOriginalID.Name = "txtOriginalID";
			this.txtOriginalID.Size = new System.Drawing.Size(56, 21);
			this.txtOriginalID.TabIndex = 2;
			this.txtOriginalID.Text = "";
			// 
			// txtCurrentSex
			// 
			this.txtCurrentSex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtCurrentSex.Location = new System.Drawing.Point(256, 56);
			this.txtCurrentSex.Name = "txtCurrentSex";
			this.txtCurrentSex.Size = new System.Drawing.Size(32, 21);
			this.txtCurrentSex.TabIndex = 2;
			this.txtCurrentSex.Text = "";
			// 
			// txtOriginalSex
			// 
			this.txtOriginalSex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtOriginalSex.Location = new System.Drawing.Point(256, 24);
			this.txtOriginalSex.Name = "txtOriginalSex";
			this.txtOriginalSex.Size = new System.Drawing.Size(32, 21);
			this.txtOriginalSex.TabIndex = 2;
			this.txtOriginalSex.Text = "";
			// 
			// txtCurrentAddr
			// 
			this.txtCurrentAddr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txtCurrentAddr.Location = new System.Drawing.Point(296, 56);
			this.txtCurrentAddr.Name = "txtCurrentAddr";
			this.txtCurrentAddr.Size = new System.Drawing.Size(184, 21);
			this.txtCurrentAddr.TabIndex = 3;
			this.txtCurrentAddr.Text = "";
			// 
			// grpRowStatus
			// 
			this.grpRowStatus.Controls.Add(this.rbtnNew);
			this.grpRowStatus.Controls.Add(this.rbtnModified);
			this.grpRowStatus.Controls.Add(this.rbtnUnchanged);
			this.grpRowStatus.Location = new System.Drawing.Point(16, 88);
			this.grpRowStatus.Name = "grpRowStatus";
			this.grpRowStatus.Size = new System.Drawing.Size(328, 64);
			this.grpRowStatus.TabIndex = 8;
			this.grpRowStatus.TabStop = false;
			this.grpRowStatus.Text = "行状态";
			// 
			// rbtnNew
			// 
			this.rbtnNew.Location = new System.Drawing.Point(248, 32);
			this.rbtnNew.Name = "rbtnNew";
			this.rbtnNew.Size = new System.Drawing.Size(56, 24);
			this.rbtnNew.TabIndex = 2;
			this.rbtnNew.Text = "新建";
			// 
			// rbtnModified
			// 
			this.rbtnModified.Location = new System.Drawing.Point(144, 32);
			this.rbtnModified.Name = "rbtnModified";
			this.rbtnModified.Size = new System.Drawing.Size(80, 24);
			this.rbtnModified.TabIndex = 1;
			this.rbtnModified.Text = "修改";
			// 
			// rbtnUnchanged
			// 
			this.rbtnUnchanged.Location = new System.Drawing.Point(40, 32);
			this.rbtnUnchanged.Name = "rbtnUnchanged";
			this.rbtnUnchanged.Size = new System.Drawing.Size(88, 24);
			this.rbtnUnchanged.TabIndex = 0;
			this.rbtnUnchanged.Text = "未改变";
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(16, 312);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(32, 24);
			this.btnFirst.TabIndex = 9;
			this.btnFirst.Text = "|<<";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnMoveNext
			// 
			this.btnMoveNext.Location = new System.Drawing.Point(72, 312);
			this.btnMoveNext.Name = "btnMoveNext";
			this.btnMoveNext.Size = new System.Drawing.Size(32, 24);
			this.btnMoveNext.TabIndex = 10;
			this.btnMoveNext.Text = "<";
			this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.Location = new System.Drawing.Point(432, 312);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(32, 24);
			this.btnLast.TabIndex = 10;
			this.btnLast.Text = ">>|";
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnMoveForward
			// 
			this.btnMoveForward.Location = new System.Drawing.Point(384, 312);
			this.btnMoveForward.Name = "btnMoveForward";
			this.btnMoveForward.Size = new System.Drawing.Size(32, 24);
			this.btnMoveForward.TabIndex = 9;
			this.btnMoveForward.Text = ">";
			this.btnMoveForward.Click += new System.EventHandler(this.btnMoveForward_Click);
			// 
			// txtPosition
			// 
			this.txtPosition.Location = new System.Drawing.Point(144, 312);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(208, 21);
			this.txtPosition.TabIndex = 11;
			this.txtPosition.Text = "";
			this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(528, 16);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(56, 23);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(528, 80);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(56, 23);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "删除";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(528, 144);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(56, 24);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "更新";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCommand
			// 
			this.btnCommand.Location = new System.Drawing.Point(528, 176);
			this.btnCommand.Name = "btnCommand";
			this.btnCommand.Size = new System.Drawing.Size(56, 23);
			this.btnCommand.TabIndex = 15;
			this.btnCommand.Text = "命令";
			this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
			// 
			// btnFill
			// 
			this.btnFill.Location = new System.Drawing.Point(528, 208);
			this.btnFill.Name = "btnFill";
			this.btnFill.Size = new System.Drawing.Size(56, 24);
			this.btnFill.TabIndex = 16;
			this.btnFill.Text = "填充";
			this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
			// 
			// btnAccept
			// 
			this.btnAccept.Location = new System.Drawing.Point(528, 240);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(56, 24);
			this.btnAccept.TabIndex = 17;
			this.btnAccept.Text = "接受";
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// btnReject
			// 
			this.btnReject.Location = new System.Drawing.Point(528, 272);
			this.btnReject.Name = "btnReject";
			this.btnReject.Size = new System.Drawing.Size(56, 24);
			this.btnReject.TabIndex = 18;
			this.btnReject.Text = "拒绝";
			this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
			// 
			// btnDefer
			// 
			this.btnDefer.Location = new System.Drawing.Point(528, 304);
			this.btnDefer.Name = "btnDefer";
			this.btnDefer.Size = new System.Drawing.Size(56, 24);
			this.btnDefer.TabIndex = 19;
			this.btnDefer.Text = "推迟";
			this.btnDefer.Click += new System.EventHandler(this.btnDefer_Click);
			// 
			// cnStudent
			// 
            //this.cnStudent.ConnectionString = "packet size=4096;integrated security=SSPI;data source=\".\";persist security info=F" +
            //    "alse;initial catalog=student";
            this.cnStudent.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=student;Integrated Security=True";
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(528, 112);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(56, 23);
			this.btnEdit.TabIndex = 20;
			this.btnEdit.Text = "编辑";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// lblAddr
			// 
			this.lblAddr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lblAddr.Location = new System.Drawing.Point(16, 104);
			this.lblAddr.Name = "lblAddr";
			this.lblAddr.Size = new System.Drawing.Size(48, 24);
			this.lblAddr.TabIndex = 21;
			this.lblAddr.Text = "地址";
			// 
			// txtAddr
			// 
			this.txtAddr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsStudent1, "student.addr"));
			this.txtAddr.Location = new System.Drawing.Point(88, 104);
			this.txtAddr.Name = "txtAddr";
			this.txtAddr.Size = new System.Drawing.Size(296, 21);
			this.txtAddr.TabIndex = 22;
			this.txtAddr.Text = "";
			// 
			// daStudent
			// 
			this.daStudent.DeleteCommand = this.sqlDeleteCommand1;
			this.daStudent.InsertCommand = this.sqlInsertCommand1;
			this.daStudent.SelectCommand = this.sqlSelectCommand1;
			this.daStudent.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																								new System.Data.Common.DataTableMapping("Table", "student", new System.Data.Common.DataColumnMapping[] {
																																																		   new System.Data.Common.DataColumnMapping("stu_id", "stu_id"),
																																																		   new System.Data.Common.DataColumnMapping("name", "name"),
																																																		   new System.Data.Common.DataColumnMapping("sex", "sex"),
																																																		   new System.Data.Common.DataColumnMapping("addr", "addr")})});
			this.daStudent.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM student WHERE (stu_id = @Original_stu_id) AND (addr = @Original_addr OR @Original_addr IS NULL AND addr IS NULL) AND (name = @Original_name OR @Original_name IS NULL AND name IS NULL) AND (sex = @Original_sex OR @Original_sex IS NULL AND sex IS NULL)";
			this.sqlDeleteCommand1.Connection = this.cnStudent;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_stu_id", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "stu_id", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_addr", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "addr", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "name", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_sex", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "sex", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO student(stu_id, name, sex, addr) VALUES (@stu_id, @name, @sex, @addr)" +
				"; SELECT stu_id, name, sex, addr FROM student WHERE (stu_id = @stu_id)";
			this.sqlInsertCommand1.Connection = this.cnStudent;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@stu_id", System.Data.SqlDbType.VarChar, 10, "stu_id"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 20, "name"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sex", System.Data.SqlDbType.VarChar, 4, "sex"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@addr", System.Data.SqlDbType.VarChar, 50, "addr"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT stu_id, name, sex, addr FROM student";
			this.sqlSelectCommand1.Connection = this.cnStudent;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE student SET stu_id = @stu_id, name = @name, sex = @sex, addr = @addr WHERE" +
				" (stu_id = @stu_id)";
			this.sqlUpdateCommand1.Connection = this.cnStudent;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@stu_id", System.Data.SqlDbType.VarChar, 10, "stu_id"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 20, "name"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@sex", System.Data.SqlDbType.VarChar, 4, "sex"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@addr", System.Data.SqlDbType.VarChar, 50, "addr"));
			// 
			// frmEditData
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(600, 349);
			this.Controls.Add(this.txtAddr);
			this.Controls.Add(this.lblAddr);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDefer);
			this.Controls.Add(this.btnReject);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.btnFill);
			this.Controls.Add(this.btnCommand);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPosition);
			this.Controls.Add(this.btnMoveNext);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.grpRowVer);
			this.Controls.Add(this.txtSex);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtStuID);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblSex);
			this.Controls.Add(this.lblStuName);
			this.Controls.Add(this.lblSutID);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnMoveForward);
			this.Name = "frmEditData";
			this.Text = "编辑和更新数据";
			this.Load += new System.EventHandler(this.frmEditData_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsStudent1)).EndInit();
			this.grpRowVer.ResumeLayout(false);
			this.grpRowStatus.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmEditData());
		}

		private void grpRowVer_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			dsStudent.studentRow drNew;
			drNew=(dsStudent.studentRow)this.dsStudent1.student.NewRow();
			drNew["stu_id"]="6033220";
			drNew["name"]="宋平";
			drNew["sex"]="男";
			drNew["addr"]="四川成都";
			this.dsStudent1.student.AddstudentRow(drNew);
		
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[this.dsStudent1,"Student"].Position=0;
			UpdateDisplay();
		}

		private void txtCurrentID_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			DataRow drCurrentRow; 
			//获得窗体中当前列
			drCurrentRow=GetRow();
			
		  //删除此行
			drCurrentRow.Delete();
			//移动到下条记录
			this.BindingContext[this.dsStudent1,"Student"].Position+=1;
			UpdateDisplay();

		}
		#region UpdateDisplay方法
		private void UpdateDisplay()
		{
			//显示初始值
			DataRow drv;
			drv=this.dsStudent1.student.Rows[this.BindingContext[this.dsStudent1,"Student"].Position];

			this.txtCurrentID.Text=drv["stu_id"].ToString();
			this.txtCurrentName.Text=drv["name"].ToString();
			this.txtCurrentSex.Text=drv["sex"].ToString();
			this.txtCurrentAddr.Text=drv["addr"].ToString();
			
			if (drv.HasVersion(DataRowVersion.Original))
			{
				this.txtOriginalID.Text=drv["stu_id",DataRowVersion.Original].ToString();
				this.txtOriginalName.Text=drv["name",DataRowVersion.Original].ToString();
				this.txtOriginalSex.Text=drv["sex",DataRowVersion.Original].ToString();
				this.txtOriginalAddr.Text=drv["addr",DataRowVersion.Original].ToString();
			
			}
			else
			{
				this.txtOriginalID.Text="";
				this.txtOriginalName.Text="";
				this.txtOriginalSex.Text="";
				this.txtOriginalAddr.Text="";
			}
			switch(drv.RowState)
			{
				case DataRowState.Added:
					this.rbtnNew.Checked=true;
					break;
				case DataRowState.Modified:
					this.rbtnModified.Checked=true;
					break;
				case DataRowState.Unchanged:
					this.rbtnUnchanged.Checked=true;
					break;
					
              }
           int crIndex=this.BindingContext[this.dsStudent1,"Student"].Position+1;
			this.txtPosition.Text="Student " + crIndex.ToString() +" of " +
				this.BindingContext[this.dsStudent1,"Student"].Count.ToString();
		}
#endregion
		#region 获得当前行
		private DataRow GetRow()
		{
			System.Windows.Forms.BindingManagerBase bm;
			DataRowView drv;
			bm =this.BindingContext[this.dsStudent1,"Student"];
			drv=(System.Data.DataRowView) bm.Current;
			return drv.Row;
		}
#endregion
		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			this.daStudent.Update(this.dsStudent1.student);
			UpdateDisplay();

		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
		    DataRow drCurrentRow;
			drCurrentRow=GetRow();
			drCurrentRow["name"]="已改变";
			UpdateDisplay();
		}

		private void btnDefer_Click(object sender, System.EventArgs e)
		{
			DataRow drCurrentRow;
			drCurrentRow=GetRow();
			drCurrentRow.BeginEdit();  //开始编辑
			drCurrentRow["name"]=this.txtName.Text; //修改列名
			MessageBox.Show(drCurrentRow["name",DataRowVersion.Proposed].ToString());
			drCurrentRow.CancelEdit();  //撤销编辑
		}

		private void frmEditData_Load(object sender, System.EventArgs e)
		{
            //cnStudent = new SqlConnection("");
            string strSql = "select stu_id,name,sex,addr from student";
            daStudent = new SqlDataAdapter(strSql, cnStudent);
            //DataSet dsStudent = new DataSet();
			this.daStudent.Fill(this.dsStudent1,"student");
			UpdateDisplay();
		}

		private void btnCommand_Click(object sender, System.EventArgs e)
		{
			SqlCommand cmdUpdate;
			DataRow drCurrentRow;
		    cmdUpdate=this.daStudent.UpdateCommand;
			drCurrentRow=GetRow();
			
			cmdUpdate.Parameters["@stu_id"].Value=drCurrentRow["stu_id"];
			cmdUpdate.Parameters["@name"].Value=drCurrentRow["name"];
			cmdUpdate.Parameters["@sex"].Value=drCurrentRow["sex"];
			cmdUpdate.Parameters["@addr"].Value=drCurrentRow["addr"];
			this.cnStudent.Open();       //打开数据连接
			cmdUpdate.ExecuteNonQuery(); //执行命令
			this.cnStudent.Close();      //关闭数据连接
			this.dsStudent1.AcceptChanges();
			UpdateDisplay(); //更新界面显示
		}

		private void btnFill_Click(object sender, System.EventArgs e)
		{
			this.dsStudent1.student.Clear();  
			this.daStudent.Fill(this.dsStudent1.student); //填充数据集
			UpdateDisplay();	
		}

		private void btnReject_Click(object sender, System.EventArgs e)
		{
			this.dsStudent1.RejectChanges(); //拒绝更改
			UpdateDisplay();
		}

		private void btnMoveNext_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[this.dsStudent1,"Student"].Position-=1;
			UpdateDisplay();
		}

		private void btnMoveForward_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[this.dsStudent1,"Student"].Position+=1;
			UpdateDisplay();
		}

		private void btnLast_Click(object sender, System.EventArgs e)
		{
		this.BindingContext[this.dsStudent1,"Student"].Position=this.BindingContext[this.dsStudent1,"Student"].Count-1;
			UpdateDisplay();
		}

		private void btnAccept_Click(object sender, System.EventArgs e)
		{
			this.dsStudent1.AcceptChanges();
			UpdateDisplay();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			BindingManagerBase bm;
			DataRowView drv;
			bm=this.BindingContext[this.dsStudent1,"Student"];
			drv=(DataRowView) bm.Current;
			drv.EndEdit ();
			UpdateDisplay();
		}
	}
}
