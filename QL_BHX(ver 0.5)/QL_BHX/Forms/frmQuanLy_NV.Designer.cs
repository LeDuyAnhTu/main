namespace QL_BHX
{
    partial class frmQuanLy_NV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_NV));
            this.tvBranches = new System.Windows.Forms.TreeView();
            this.lvStaffs_List = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBranch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmList_Staff = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRemove_Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdate_Staff = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gboStaff_Info = new System.Windows.Forms.GroupBox();
            this.gboSingle = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID_Person = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaff_Wage = new System.Windows.Forms.TextBox();
            this.cboStaff_Branch = new System.Windows.Forms.ComboBox();
            this.txtStaff_ID = new System.Windows.Forms.TextBox();
            this.txtStaff_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtStaff_Phone = new System.Windows.Forms.TextBox();
            this.btnAdd_List = new System.Windows.Forms.Button();
            this.radStaff_Multi = new System.Windows.Forms.RadioButton();
            this.radStaff_One = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errWage = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFind = new System.Windows.Forms.TextBox();
            this.ctmList_Staff.SuspendLayout();
            this.gboStaff_Info.SuspendLayout();
            this.gboSingle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errWage)).BeginInit();
            this.SuspendLayout();
            // 
            // tvBranches
            // 
            this.tvBranches.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvBranches.Location = new System.Drawing.Point(0, 0);
            this.tvBranches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvBranches.Name = "tvBranches";
            this.tvBranches.Size = new System.Drawing.Size(195, 743);
            this.tvBranches.TabIndex = 0;
            this.tvBranches.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBranches_AfterSelect);
            // 
            // lvStaffs_List
            // 
            this.lvStaffs_List.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvStaffs_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStaffs_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colIDPerson,
            this.colPhone,
            this.colDOB,
            this.colWage,
            this.colBranch,
            this.colGender});
            this.lvStaffs_List.ContextMenuStrip = this.ctmList_Staff;
            this.lvStaffs_List.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvStaffs_List.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStaffs_List.FullRowSelect = true;
            this.lvStaffs_List.GridLines = true;
            this.lvStaffs_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStaffs_List.HideSelection = false;
            this.lvStaffs_List.Location = new System.Drawing.Point(195, 0);
            this.lvStaffs_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvStaffs_List.Name = "lvStaffs_List";
            this.lvStaffs_List.Size = new System.Drawing.Size(1009, 339);
            this.lvStaffs_List.TabIndex = 1;
            this.lvStaffs_List.UseCompatibleStateImageBehavior = false;
            this.lvStaffs_List.View = System.Windows.Forms.View.Details;
            this.lvStaffs_List.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvStaffs_List_ColumnWidthChanging);
            this.lvStaffs_List.SelectedIndexChanged += new System.EventHandler(this.lvStaffs_List_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 131;
            // 
            // colName
            // 
            this.colName.Text = "Họ và tên";
            this.colName.Width = 195;
            // 
            // colIDPerson
            // 
            this.colIDPerson.Text = "CCCD";
            this.colIDPerson.Width = 155;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Số điện thoại";
            this.colPhone.Width = 125;
            // 
            // colDOB
            // 
            this.colDOB.Text = "Ngày sinh";
            this.colDOB.Width = 132;
            // 
            // colWage
            // 
            this.colWage.Text = "Mức lương";
            this.colWage.Width = 140;
            // 
            // colBranch
            // 
            this.colBranch.Text = "Chi nhánh";
            this.colBranch.Width = 140;
            // 
            // colGender
            // 
            this.colGender.Text = "Giới tính";
            // 
            // ctmList_Staff
            // 
            this.ctmList_Staff.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmList_Staff.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRemove_Staff,
            this.tsmUpdate_Staff});
            this.ctmList_Staff.Name = "ctmList_Staff";
            this.ctmList_Staff.Size = new System.Drawing.Size(172, 52);
            // 
            // tsmRemove_Staff
            // 
            this.tsmRemove_Staff.Name = "tsmRemove_Staff";
            this.tsmRemove_Staff.Size = new System.Drawing.Size(171, 24);
            this.tsmRemove_Staff.Text = "Xóa nhân viên";
            // 
            // tsmUpdate_Staff
            // 
            this.tsmUpdate_Staff.Name = "tsmUpdate_Staff";
            this.tsmUpdate_Staff.Size = new System.Drawing.Size(171, 24);
            this.tsmUpdate_Staff.Text = "Sửa thông tin";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(201, 677);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 54);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm nhân viên";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.AutoSize = true;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(590, 676);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(208, 54);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xóa nhân viên";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gboStaff_Info
            // 
            this.gboStaff_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gboStaff_Info.Controls.Add(this.gboSingle);
            this.gboStaff_Info.Controls.Add(this.btnAdd_List);
            this.gboStaff_Info.Controls.Add(this.radStaff_Multi);
            this.gboStaff_Info.Controls.Add(this.radStaff_One);
            this.gboStaff_Info.Enabled = false;
            this.gboStaff_Info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboStaff_Info.Location = new System.Drawing.Point(201, 384);
            this.gboStaff_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboStaff_Info.Name = "gboStaff_Info";
            this.gboStaff_Info.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboStaff_Info.Size = new System.Drawing.Size(986, 278);
            this.gboStaff_Info.TabIndex = 4;
            this.gboStaff_Info.TabStop = false;
            this.gboStaff_Info.Text = "Thông tin nhân viên";
            // 
            // gboSingle
            // 
            this.gboSingle.Controls.Add(this.label8);
            this.gboSingle.Controls.Add(this.txtID_Person);
            this.gboSingle.Controls.Add(this.cboGender);
            this.gboSingle.Controls.Add(this.label6);
            this.gboSingle.Controls.Add(this.txtStaff_Wage);
            this.gboSingle.Controls.Add(this.cboStaff_Branch);
            this.gboSingle.Controls.Add(this.txtStaff_ID);
            this.gboSingle.Controls.Add(this.txtStaff_Name);
            this.gboSingle.Controls.Add(this.label1);
            this.gboSingle.Controls.Add(this.label2);
            this.gboSingle.Controls.Add(this.label5);
            this.gboSingle.Controls.Add(this.label4);
            this.gboSingle.Controls.Add(this.label7);
            this.gboSingle.Controls.Add(this.label3);
            this.gboSingle.Controls.Add(this.dtpDOB);
            this.gboSingle.Controls.Add(this.txtStaff_Phone);
            this.gboSingle.Location = new System.Drawing.Point(31, 30);
            this.gboSingle.Margin = new System.Windows.Forms.Padding(4);
            this.gboSingle.Name = "gboSingle";
            this.gboSingle.Padding = new System.Windows.Forms.Padding(4);
            this.gboSingle.Size = new System.Drawing.Size(939, 174);
            this.gboSingle.TabIndex = 19;
            this.gboSingle.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "CCCD:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID_Person
            // 
            this.txtID_Person.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Person.Location = new System.Drawing.Point(611, 21);
            this.txtID_Person.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_Person.Name = "txtID_Person";
            this.txtID_Person.Size = new System.Drawing.Size(307, 30);
            this.txtID_Person.TabIndex = 22;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGender.Location = new System.Drawing.Point(128, 130);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(156, 30);
            this.cboGender.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Giới tính:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStaff_Wage
            // 
            this.txtStaff_Wage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff_Wage.Location = new System.Drawing.Point(611, 89);
            this.txtStaff_Wage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaff_Wage.Name = "txtStaff_Wage";
            this.txtStaff_Wage.Size = new System.Drawing.Size(307, 30);
            this.txtStaff_Wage.TabIndex = 18;
            this.txtStaff_Wage.TextChanged += new System.EventHandler(this.txtStaff_Wage_TextChanged);
            // 
            // cboStaff_Branch
            // 
            this.cboStaff_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaff_Branch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaff_Branch.FormattingEnabled = true;
            this.cboStaff_Branch.Location = new System.Drawing.Point(611, 123);
            this.cboStaff_Branch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStaff_Branch.Name = "cboStaff_Branch";
            this.cboStaff_Branch.Size = new System.Drawing.Size(307, 30);
            this.cboStaff_Branch.TabIndex = 17;
            this.cboStaff_Branch.SelectedIndexChanged += new System.EventHandler(this.cboStaff_Branch_SelectedIndexChanged);
            // 
            // txtStaff_ID
            // 
            this.txtStaff_ID.Enabled = false;
            this.txtStaff_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff_ID.Location = new System.Drawing.Point(128, 18);
            this.txtStaff_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaff_ID.Name = "txtStaff_ID";
            this.txtStaff_ID.Size = new System.Drawing.Size(287, 30);
            this.txtStaff_ID.TabIndex = 2;
            // 
            // txtStaff_Name
            // 
            this.txtStaff_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff_Name.Location = new System.Drawing.Point(128, 55);
            this.txtStaff_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaff_Name.Name = "txtStaff_Name";
            this.txtStaff_Name.Size = new System.Drawing.Size(287, 30);
            this.txtStaff_Name.TabIndex = 3;
            this.txtStaff_Name.TextChanged += new System.EventHandler(this.txtStaff_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ tên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chi nhánh:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mức lương:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "SĐT:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDOB
            // 
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(128, 92);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(287, 30);
            this.dtpDOB.TabIndex = 9;
            // 
            // txtStaff_Phone
            // 
            this.txtStaff_Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff_Phone.Location = new System.Drawing.Point(611, 55);
            this.txtStaff_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaff_Phone.Name = "txtStaff_Phone";
            this.txtStaff_Phone.Size = new System.Drawing.Size(307, 30);
            this.txtStaff_Phone.TabIndex = 10;
            this.txtStaff_Phone.TextChanged += new System.EventHandler(this.txtStaff_Phone_TextChanged);
            // 
            // btnAdd_List
            // 
            this.btnAdd_List.Enabled = false;
            this.btnAdd_List.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_List.Location = new System.Drawing.Point(51, 209);
            this.btnAdd_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_List.Name = "btnAdd_List";
            this.btnAdd_List.Size = new System.Drawing.Size(157, 59);
            this.btnAdd_List.TabIndex = 18;
            this.btnAdd_List.Text = "Thêm danh sách nhân viên";
            this.btnAdd_List.UseVisualStyleBackColor = true;
            this.btnAdd_List.Click += new System.EventHandler(this.btnAdd_List_Click);
            // 
            // radStaff_Multi
            // 
            this.radStaff_Multi.AutoSize = true;
            this.radStaff_Multi.Location = new System.Drawing.Point(5, 231);
            this.radStaff_Multi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radStaff_Multi.Name = "radStaff_Multi";
            this.radStaff_Multi.Size = new System.Drawing.Size(17, 16);
            this.radStaff_Multi.TabIndex = 1;
            this.radStaff_Multi.UseVisualStyleBackColor = true;
            // 
            // radStaff_One
            // 
            this.radStaff_One.AutoSize = true;
            this.radStaff_One.Checked = true;
            this.radStaff_One.Location = new System.Drawing.Point(5, 44);
            this.radStaff_One.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radStaff_One.Name = "radStaff_One";
            this.radStaff_One.Size = new System.Drawing.Size(17, 16);
            this.radStaff_One.TabIndex = 0;
            this.radStaff_One.TabStop = true;
            this.radStaff_One.UseVisualStyleBackColor = true;
            this.radStaff_One.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(990, 678);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 54);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa thông tin";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(404, 677);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(180, 54);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(804, 678);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 54);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // errSDT
            // 
            this.errSDT.ContainerControl = this;
            // 
            // errWage
            // 
            this.errWage.ContainerControl = this;
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.Gray;
            this.txtFind.Location = new System.Drawing.Point(843, 349);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(307, 30);
            this.txtFind.TabIndex = 9;
            this.txtFind.Text = "Tỉm nhân viên....";
            this.txtFind.Enter += new System.EventHandler(this.txtFind_Enter);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            this.txtFind.Leave += new System.EventHandler(this.txtFind_Leave);
            // 
            // frmQuanLy_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 743);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gboStaff_Info);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvStaffs_List);
            this.Controls.Add(this.tvBranches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLy_NV";
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLy_NhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLy_NhanVien_Load);
            this.ctmList_Staff.ResumeLayout(false);
            this.gboStaff_Info.ResumeLayout(false);
            this.gboStaff_Info.PerformLayout();
            this.gboSingle.ResumeLayout(false);
            this.gboSingle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvBranches;
        private System.Windows.Forms.ListView lvStaffs_List;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gboStaff_Info;
        private System.Windows.Forms.RadioButton radStaff_Multi;
        private System.Windows.Forms.RadioButton radStaff_One;
        private System.Windows.Forms.TextBox txtStaff_ID;
        private System.Windows.Forms.TextBox txtStaff_Phone;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStaff_Name;
        private System.Windows.Forms.ComboBox cboStaff_Branch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDOB;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colWage;
        private System.Windows.Forms.ColumnHeader colBranch;
        private System.Windows.Forms.Button btnAdd_List;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gboSingle;
        private System.Windows.Forms.TextBox txtStaff_Wage;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errSDT;
        private System.Windows.Forms.ErrorProvider errWage;
        private System.Windows.Forms.ColumnHeader colIDPerson;
        private System.Windows.Forms.ContextMenuStrip ctmList_Staff;
        private System.Windows.Forms.ToolStripMenuItem tsmRemove_Staff;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate_Staff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID_Person;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ColumnHeader colGender;
    }
}