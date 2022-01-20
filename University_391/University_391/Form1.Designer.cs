using System.Windows.Forms;

namespace University_391
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.students_tab = new System.Windows.Forms.TabPage();
            this.login_button = new System.Windows.Forms.Button();
            this.studentView = new System.Windows.Forms.DataGridView();
            this.studentView_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentView_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentView_dept_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentView_tot_cred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sql_connection = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.database_name = new System.Windows.Forms.TextBox();
            this.connPortBox = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.connHostBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.connection_status_label = new System.Windows.Forms.Label();
            this.user_ID = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.network_radioButton = new System.Windows.Forms.RadioButton();
            this.local_radioButton = new System.Windows.Forms.RadioButton();
            this.password = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.reg_tab = new System.Windows.Forms.TabPage();
            this.studentHistoryBox = new System.Windows.Forms.GroupBox();
            this.courseHistDGV = new System.Windows.Forms.DataGridView();
            this.courseHistCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseHistYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseHistTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseHistDeptname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseHistCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseHistGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCurrentEnrollBox = new System.Windows.Forms.GroupBox();
            this.currentDGV = new System.Windows.Forms.DataGridView();
            this.currentDGVColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDGVColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDGVColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDGVColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDGVColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDGVColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableClassBox = new System.Windows.Forms.GroupBox();
            this.availableDGV = new System.Windows.Forms.DataGridView();
            this.availableDGVcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDGVcourse_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDGVtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDGVsection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDGVdept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDGVbldg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDGVroom_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDGVtime_slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDGVcred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingCartBox = new System.Windows.Forms.GroupBox();
            this.prereqTest = new System.Windows.Forms.Label();
            this.prereqUnmet = new System.Windows.Forms.Label();
            this.prereqMet = new System.Windows.Forms.Label();
            this.addCart = new System.Windows.Forms.Button();
            this.cartTimeLabel = new System.Windows.Forms.Label();
            this.cartBldgRoomLabel = new System.Windows.Forms.Label();
            this.cartSecLabel = new System.Windows.Forms.Label();
            this.cartSemYearLabel = new System.Windows.Forms.Label();
            this.cartCreditsLabel = new System.Windows.Forms.Label();
            this.cartDeptLabel = new System.Windows.Forms.Label();
            this.cartTitleLabel = new System.Windows.Forms.Label();
            this.cartIDLabel = new System.Windows.Forms.Label();
            this.cartSeatsLabel = new System.Windows.Forms.Label();
            this.cartLabel9 = new System.Windows.Forms.Label();
            this.cartLabel8 = new System.Windows.Forms.Label();
            this.cartLabel7 = new System.Windows.Forms.Label();
            this.cartLabel6 = new System.Windows.Forms.Label();
            this.cartLabel5 = new System.Windows.Forms.Label();
            this.cartLabel4 = new System.Windows.Forms.Label();
            this.cartLabel3 = new System.Windows.Forms.Label();
            this.cartLabel2 = new System.Windows.Forms.Label();
            this.cartLabel1 = new System.Windows.Forms.Label();
            this.cartDGV = new System.Windows.Forms.DataGridView();
            this.cartDGVcourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartDGVtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartDGVsection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBox = new System.Windows.Forms.GroupBox();
            this.totcredLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.iDLabel = new System.Windows.Forms.Label();
            this.regTotcredLabel = new System.Windows.Forms.Label();
            this.regDeptnameLabel = new System.Windows.Forms.Label();
            this.regNameLabel = new System.Windows.Forms.Label();
            this.regIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cartRemove = new System.Windows.Forms.Button();
            this.goRegister = new System.Windows.Forms.Button();
            this.students_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).BeginInit();
            this.sql_connection.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.reg_tab.SuspendLayout();
            this.studentHistoryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseHistDGV)).BeginInit();
            this.studentCurrentEnrollBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentDGV)).BeginInit();
            this.availableClassBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableDGV)).BeginInit();
            this.shoppingCartBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).BeginInit();
            this.studentInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // students_tab
            // 
            this.students_tab.BackColor = System.Drawing.Color.SeaShell;
            this.students_tab.Controls.Add(this.login_button);
            this.students_tab.Controls.Add(this.studentView);
            this.students_tab.Location = new System.Drawing.Point(4, 22);
            this.students_tab.Name = "students_tab";
            this.students_tab.Padding = new System.Windows.Forms.Padding(3);
            this.students_tab.Size = new System.Drawing.Size(1452, 710);
            this.students_tab.TabIndex = 1;
            this.students_tab.Text = "Students";
            this.students_tab.Click += new System.EventHandler(this.students_tab_Click);
            this.students_tab.Enter += new System.EventHandler(this.students_tab_Enter);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(42, 21);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(177, 42);
            this.login_button.TabIndex = 25;
            this.login_button.Text = "Login as this Student";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // studentView
            // 
            this.studentView.AllowUserToAddRows = false;
            this.studentView.AllowUserToResizeRows = false;
            this.studentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentView_ID,
            this.studentView_name,
            this.studentView_dept_name,
            this.studentView_tot_cred});
            this.studentView.Location = new System.Drawing.Point(267, 3);
            this.studentView.MultiSelect = false;
            this.studentView.Name = "studentView";
            this.studentView.RowHeadersVisible = false;
            this.studentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentView.ShowCellErrors = false;
            this.studentView.Size = new System.Drawing.Size(500, 701);
            this.studentView.TabIndex = 3;
            this.studentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentView_CellContentClick);
            // 
            // studentView_ID
            // 
            this.studentView_ID.HeaderText = "ID";
            this.studentView_ID.Name = "studentView_ID";
            this.studentView_ID.ReadOnly = true;
            this.studentView_ID.Width = 43;
            // 
            // studentView_name
            // 
            this.studentView_name.HeaderText = "Name";
            this.studentView_name.Name = "studentView_name";
            this.studentView_name.Width = 60;
            // 
            // studentView_dept_name
            // 
            this.studentView_dept_name.HeaderText = "Dept.";
            this.studentView_dept_name.Name = "studentView_dept_name";
            this.studentView_dept_name.Width = 58;
            // 
            // studentView_tot_cred
            // 
            this.studentView_tot_cred.HeaderText = "Credits";
            this.studentView_tot_cred.Name = "studentView_tot_cred";
            this.studentView_tot_cred.Width = 64;
            // 
            // sql_connection
            // 
            this.sql_connection.BackColor = System.Drawing.Color.SeaShell;
            this.sql_connection.Controls.Add(this.groupBox4);
            this.sql_connection.Location = new System.Drawing.Point(4, 22);
            this.sql_connection.Name = "sql_connection";
            this.sql_connection.Padding = new System.Windows.Forms.Padding(3);
            this.sql_connection.Size = new System.Drawing.Size(1452, 710);
            this.sql_connection.TabIndex = 0;
            this.sql_connection.Text = "SQL Connection";
            this.sql_connection.Enter += new System.EventHandler(this.sql_connection_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MintCream;
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.database_name);
            this.groupBox4.Controls.Add(this.connPortBox);
            this.groupBox4.Controls.Add(this.label0);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.connect_button);
            this.groupBox4.Controls.Add(this.connHostBox);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.connection_status_label);
            this.groupBox4.Controls.Add(this.user_ID);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.password);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 701);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 84);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 13);
            this.label30.TabIndex = 10;
            this.label30.Text = "DB Name";
            // 
            // database_name
            // 
            this.database_name.Location = new System.Drawing.Point(66, 81);
            this.database_name.Name = "database_name";
            this.database_name.Size = new System.Drawing.Size(155, 20);
            this.database_name.TabIndex = 2;
            this.database_name.TextChanged += new System.EventHandler(this.database_name_TextChanged);
            // 
            // connPortBox
            // 
            this.connPortBox.Location = new System.Drawing.Point(297, 201);
            this.connPortBox.Name = "connPortBox";
            this.connPortBox.Size = new System.Drawing.Size(87, 20);
            this.connPortBox.TabIndex = 5;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(6, 291);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(94, 13);
            this.label0.TabIndex = 0;
            this.label0.Text = "Connection Status";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(265, 204);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 13);
            this.label29.TabIndex = 7;
            this.label29.Text = "Port";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(6, 323);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 6;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // connHostBox
            // 
            this.connHostBox.Location = new System.Drawing.Point(66, 201);
            this.connHostBox.Name = "connHostBox";
            this.connHostBox.Size = new System.Drawing.Size(155, 20);
            this.connHostBox.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 204);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 13);
            this.label28.TabIndex = 5;
            this.label28.Text = "Host / IP";
            // 
            // connection_status_label
            // 
            this.connection_status_label.AutoSize = true;
            this.connection_status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_status_label.ForeColor = System.Drawing.Color.Firebrick;
            this.connection_status_label.Location = new System.Drawing.Point(106, 289);
            this.connection_status_label.Name = "connection_status_label";
            this.connection_status_label.Size = new System.Drawing.Size(101, 15);
            this.connection_status_label.TabIndex = 1;
            this.connection_status_label.Text = "Not Connected";
            // 
            // user_ID
            // 
            this.user_ID.Location = new System.Drawing.Point(66, 42);
            this.user_ID.Name = "user_ID";
            this.user_ID.Size = new System.Drawing.Size(155, 20);
            this.user_ID.TabIndex = 0;
            this.user_ID.TextChanged += new System.EventHandler(this.user_ID_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.network_radioButton);
            this.groupBox6.Controls.Add(this.local_radioButton);
            this.groupBox6.Location = new System.Drawing.Point(9, 150);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(443, 45);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Connection Type";
            // 
            // network_radioButton
            // 
            this.network_radioButton.AutoSize = true;
            this.network_radioButton.Location = new System.Drawing.Point(259, 19);
            this.network_radioButton.Name = "network_radioButton";
            this.network_radioButton.Size = new System.Drawing.Size(65, 17);
            this.network_radioButton.TabIndex = 0;
            this.network_radioButton.Text = "Network";
            this.network_radioButton.UseVisualStyleBackColor = true;
            this.network_radioButton.CheckedChanged += new System.EventHandler(this.network_radioButton_CheckedChanged);
            // 
            // local_radioButton
            // 
            this.local_radioButton.AutoSize = true;
            this.local_radioButton.Checked = true;
            this.local_radioButton.Location = new System.Drawing.Point(57, 19);
            this.local_radioButton.Name = "local_radioButton";
            this.local_radioButton.Size = new System.Drawing.Size(71, 17);
            this.local_radioButton.TabIndex = 1;
            this.local_radioButton.TabStop = true;
            this.local_radioButton.Text = "Localhost";
            this.local_radioButton.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(297, 42);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(155, 20);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(238, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 3;
            this.label27.Text = "Password";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(17, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "User ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sql_connection);
            this.tabControl1.Controls.Add(this.students_tab);
            this.tabControl1.Controls.Add(this.reg_tab);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1460, 736);
            this.tabControl1.TabIndex = 0;
            // 
            // reg_tab
            // 
            this.reg_tab.BackColor = System.Drawing.Color.SeaShell;
            this.reg_tab.Controls.Add(this.studentHistoryBox);
            this.reg_tab.Controls.Add(this.studentCurrentEnrollBox);
            this.reg_tab.Controls.Add(this.availableClassBox);
            this.reg_tab.Controls.Add(this.shoppingCartBox);
            this.reg_tab.Controls.Add(this.studentInfoBox);
            this.reg_tab.Location = new System.Drawing.Point(4, 22);
            this.reg_tab.Name = "reg_tab";
            this.reg_tab.Padding = new System.Windows.Forms.Padding(3);
            this.reg_tab.Size = new System.Drawing.Size(1452, 710);
            this.reg_tab.TabIndex = 2;
            this.reg_tab.Text = "Registration";
            this.reg_tab.Enter += new System.EventHandler(this.reg_tab_Enter);
            // 
            // studentHistoryBox
            // 
            this.studentHistoryBox.BackColor = System.Drawing.Color.MintCream;
            this.studentHistoryBox.Controls.Add(this.courseHistDGV);
            this.studentHistoryBox.Location = new System.Drawing.Point(1010, 204);
            this.studentHistoryBox.Name = "studentHistoryBox";
            this.studentHistoryBox.Size = new System.Drawing.Size(438, 503);
            this.studentHistoryBox.TabIndex = 4;
            this.studentHistoryBox.TabStop = false;
            this.studentHistoryBox.Text = "Student\'s Course History";
            // 
            // courseHistDGV
            // 
            this.courseHistDGV.AllowUserToAddRows = false;
            this.courseHistDGV.AllowUserToResizeRows = false;
            this.courseHistDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.courseHistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseHistDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseHistCourseID,
            this.courseHistYear,
            this.courseHistTitle,
            this.courseHistDeptname,
            this.courseHistCredits,
            this.courseHistGrade});
            this.courseHistDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseHistDGV.Location = new System.Drawing.Point(3, 16);
            this.courseHistDGV.Name = "courseHistDGV";
            this.courseHistDGV.RowHeadersVisible = false;
            this.courseHistDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseHistDGV.ShowCellErrors = false;
            this.courseHistDGV.Size = new System.Drawing.Size(432, 484);
            this.courseHistDGV.TabIndex = 0;
            // 
            // courseHistCourseID
            // 
            this.courseHistCourseID.HeaderText = "Course ID";
            this.courseHistCourseID.Name = "courseHistCourseID";
            this.courseHistCourseID.Width = 79;
            // 
            // courseHistYear
            // 
            this.courseHistYear.HeaderText = "Year";
            this.courseHistYear.Name = "courseHistYear";
            this.courseHistYear.Width = 54;
            // 
            // courseHistTitle
            // 
            this.courseHistTitle.HeaderText = "Title";
            this.courseHistTitle.Name = "courseHistTitle";
            this.courseHistTitle.Width = 52;
            // 
            // courseHistDeptname
            // 
            this.courseHistDeptname.HeaderText = "Dept.";
            this.courseHistDeptname.Name = "courseHistDeptname";
            this.courseHistDeptname.Width = 58;
            // 
            // courseHistCredits
            // 
            this.courseHistCredits.HeaderText = "Credits";
            this.courseHistCredits.Name = "courseHistCredits";
            this.courseHistCredits.Width = 64;
            // 
            // courseHistGrade
            // 
            this.courseHistGrade.HeaderText = "Grade";
            this.courseHistGrade.Name = "courseHistGrade";
            this.courseHistGrade.Width = 61;
            // 
            // studentCurrentEnrollBox
            // 
            this.studentCurrentEnrollBox.BackColor = System.Drawing.Color.GhostWhite;
            this.studentCurrentEnrollBox.Controls.Add(this.currentDGV);
            this.studentCurrentEnrollBox.Location = new System.Drawing.Point(1010, 6);
            this.studentCurrentEnrollBox.Name = "studentCurrentEnrollBox";
            this.studentCurrentEnrollBox.Size = new System.Drawing.Size(438, 195);
            this.studentCurrentEnrollBox.TabIndex = 3;
            this.studentCurrentEnrollBox.TabStop = false;
            this.studentCurrentEnrollBox.Text = "Student\'s Current Enrollment";
            // 
            // currentDGV
            // 
            this.currentDGV.AllowUserToAddRows = false;
            this.currentDGV.AllowUserToResizeRows = false;
            this.currentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.currentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currentDGVColumn1,
            this.currentDGVColumn2,
            this.currentDGVColumn3,
            this.currentDGVColumn4,
            this.currentDGVColumn5,
            this.currentDGVColumn6});
            this.currentDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.currentDGV.Location = new System.Drawing.Point(3, 16);
            this.currentDGV.Name = "currentDGV";
            this.currentDGV.RowHeadersVisible = false;
            this.currentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentDGV.ShowCellErrors = false;
            this.currentDGV.Size = new System.Drawing.Size(432, 176);
            this.currentDGV.TabIndex = 1;
            // 
            // currentDGVColumn1
            // 
            this.currentDGVColumn1.HeaderText = "Course ID";
            this.currentDGVColumn1.Name = "currentDGVColumn1";
            this.currentDGVColumn1.Width = 79;
            // 
            // currentDGVColumn2
            // 
            this.currentDGVColumn2.HeaderText = "Section";
            this.currentDGVColumn2.Name = "currentDGVColumn2";
            this.currentDGVColumn2.Width = 68;
            // 
            // currentDGVColumn3
            // 
            this.currentDGVColumn3.HeaderText = "Title";
            this.currentDGVColumn3.Name = "currentDGVColumn3";
            this.currentDGVColumn3.Width = 52;
            // 
            // currentDGVColumn4
            // 
            this.currentDGVColumn4.HeaderText = "Dept.";
            this.currentDGVColumn4.Name = "currentDGVColumn4";
            this.currentDGVColumn4.Width = 58;
            // 
            // currentDGVColumn5
            // 
            this.currentDGVColumn5.HeaderText = "Credits";
            this.currentDGVColumn5.Name = "currentDGVColumn5";
            this.currentDGVColumn5.Width = 64;
            // 
            // currentDGVColumn6
            // 
            this.currentDGVColumn6.HeaderText = "Grade";
            this.currentDGVColumn6.Name = "currentDGVColumn6";
            this.currentDGVColumn6.Width = 61;
            // 
            // availableClassBox
            // 
            this.availableClassBox.BackColor = System.Drawing.Color.Cornsilk;
            this.availableClassBox.Controls.Add(this.availableDGV);
            this.availableClassBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.availableClassBox.Location = new System.Drawing.Point(487, 6);
            this.availableClassBox.Name = "availableClassBox";
            this.availableClassBox.Size = new System.Drawing.Size(520, 701);
            this.availableClassBox.TabIndex = 2;
            this.availableClassBox.TabStop = false;
            this.availableClassBox.Text = "Available Class Sections";
            // 
            // availableDGV
            // 
            this.availableDGV.AllowUserToAddRows = false;
            this.availableDGV.AllowUserToResizeRows = false;
            this.availableDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.availableDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.availableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.availableDGVcap,
            this.availableDGVcourse_id,
            this.availableDGVtitle,
            this.availableDGVsection,
            this.availableDGVdept,
            this.availableDGVbldg,
            this.availableDGVroom_num,
            this.availableDGVtime_slot,
            this.availableDGVcred});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availableDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.availableDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableDGV.Location = new System.Drawing.Point(3, 16);
            this.availableDGV.Name = "availableDGV";
            this.availableDGV.RowHeadersVisible = false;
            this.availableDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableDGV.ShowCellErrors = false;
            this.availableDGV.Size = new System.Drawing.Size(514, 682);
            this.availableDGV.TabIndex = 0;
            this.availableDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableDGV_RowEnter);
            // 
            // availableDGVcap
            // 
            this.availableDGVcap.HeaderText = "#";
            this.availableDGVcap.Name = "availableDGVcap";
            this.availableDGVcap.Width = 39;
            // 
            // availableDGVcourse_id
            // 
            this.availableDGVcourse_id.HeaderText = "ID";
            this.availableDGVcourse_id.Name = "availableDGVcourse_id";
            this.availableDGVcourse_id.Width = 43;
            // 
            // availableDGVtitle
            // 
            this.availableDGVtitle.HeaderText = "Title";
            this.availableDGVtitle.Name = "availableDGVtitle";
            this.availableDGVtitle.Width = 52;
            // 
            // availableDGVsection
            // 
            this.availableDGVsection.HeaderText = "Section";
            this.availableDGVsection.Name = "availableDGVsection";
            this.availableDGVsection.Width = 68;
            // 
            // availableDGVdept
            // 
            this.availableDGVdept.HeaderText = "Dept.";
            this.availableDGVdept.Name = "availableDGVdept";
            this.availableDGVdept.Width = 58;
            // 
            // availableDGVbldg
            // 
            this.availableDGVbldg.HeaderText = "Building";
            this.availableDGVbldg.Name = "availableDGVbldg";
            this.availableDGVbldg.Width = 69;
            // 
            // availableDGVroom_num
            // 
            this.availableDGVroom_num.HeaderText = "Room";
            this.availableDGVroom_num.Name = "availableDGVroom_num";
            this.availableDGVroom_num.Width = 60;
            // 
            // availableDGVtime_slot
            // 
            this.availableDGVtime_slot.HeaderText = "Time";
            this.availableDGVtime_slot.Name = "availableDGVtime_slot";
            this.availableDGVtime_slot.Width = 55;
            // 
            // availableDGVcred
            // 
            this.availableDGVcred.HeaderText = "Credits";
            this.availableDGVcred.Name = "availableDGVcred";
            this.availableDGVcred.Width = 64;
            // 
            // shoppingCartBox
            // 
            this.shoppingCartBox.BackColor = System.Drawing.Color.GhostWhite;
            this.shoppingCartBox.Controls.Add(this.goRegister);
            this.shoppingCartBox.Controls.Add(this.cartRemove);
            this.shoppingCartBox.Controls.Add(this.label1);
            this.shoppingCartBox.Controls.Add(this.prereqTest);
            this.shoppingCartBox.Controls.Add(this.prereqUnmet);
            this.shoppingCartBox.Controls.Add(this.prereqMet);
            this.shoppingCartBox.Controls.Add(this.addCart);
            this.shoppingCartBox.Controls.Add(this.cartTimeLabel);
            this.shoppingCartBox.Controls.Add(this.cartBldgRoomLabel);
            this.shoppingCartBox.Controls.Add(this.cartSecLabel);
            this.shoppingCartBox.Controls.Add(this.cartSemYearLabel);
            this.shoppingCartBox.Controls.Add(this.cartCreditsLabel);
            this.shoppingCartBox.Controls.Add(this.cartDeptLabel);
            this.shoppingCartBox.Controls.Add(this.cartTitleLabel);
            this.shoppingCartBox.Controls.Add(this.cartIDLabel);
            this.shoppingCartBox.Controls.Add(this.cartSeatsLabel);
            this.shoppingCartBox.Controls.Add(this.cartLabel9);
            this.shoppingCartBox.Controls.Add(this.cartLabel8);
            this.shoppingCartBox.Controls.Add(this.cartLabel7);
            this.shoppingCartBox.Controls.Add(this.cartLabel6);
            this.shoppingCartBox.Controls.Add(this.cartLabel5);
            this.shoppingCartBox.Controls.Add(this.cartLabel4);
            this.shoppingCartBox.Controls.Add(this.cartLabel3);
            this.shoppingCartBox.Controls.Add(this.cartLabel2);
            this.shoppingCartBox.Controls.Add(this.cartLabel1);
            this.shoppingCartBox.Controls.Add(this.cartDGV);
            this.shoppingCartBox.Location = new System.Drawing.Point(6, 137);
            this.shoppingCartBox.Name = "shoppingCartBox";
            this.shoppingCartBox.Size = new System.Drawing.Size(475, 570);
            this.shoppingCartBox.TabIndex = 1;
            this.shoppingCartBox.TabStop = false;
            this.shoppingCartBox.Text = "Shopping Cart";
            // 
            // prereqTest
            // 
            this.prereqTest.AutoSize = true;
            this.prereqTest.Location = new System.Drawing.Point(92, 161);
            this.prereqTest.Name = "prereqTest";
            this.prereqTest.Size = new System.Drawing.Size(10, 13);
            this.prereqTest.TabIndex = 27;
            this.prereqTest.Text = "-";
            // 
            // prereqUnmet
            // 
            this.prereqUnmet.AutoSize = true;
            this.prereqUnmet.BackColor = System.Drawing.Color.DarkRed;
            this.prereqUnmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prereqUnmet.ForeColor = System.Drawing.Color.MistyRose;
            this.prereqUnmet.Location = new System.Drawing.Point(120, 158);
            this.prereqUnmet.Name = "prereqUnmet";
            this.prereqUnmet.Size = new System.Drawing.Size(103, 16);
            this.prereqUnmet.TabIndex = 26;
            this.prereqUnmet.Text = "Prereq Unmet";
            // 
            // prereqMet
            // 
            this.prereqMet.AutoSize = true;
            this.prereqMet.BackColor = System.Drawing.Color.DarkGreen;
            this.prereqMet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prereqMet.ForeColor = System.Drawing.Color.Lime;
            this.prereqMet.Location = new System.Drawing.Point(120, 158);
            this.prereqMet.Name = "prereqMet";
            this.prereqMet.Size = new System.Drawing.Size(84, 16);
            this.prereqMet.TabIndex = 25;
            this.prereqMet.Text = "Prereq Met";
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(3, 388);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(116, 23);
            this.addCart.TabIndex = 24;
            this.addCart.Text = "Add Course to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // cartTimeLabel
            // 
            this.cartTimeLabel.AutoSize = true;
            this.cartTimeLabel.Location = new System.Drawing.Point(322, 129);
            this.cartTimeLabel.Name = "cartTimeLabel";
            this.cartTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.cartTimeLabel.TabIndex = 23;
            this.cartTimeLabel.Text = "-";
            // 
            // cartBldgRoomLabel
            // 
            this.cartBldgRoomLabel.AutoSize = true;
            this.cartBldgRoomLabel.Location = new System.Drawing.Point(322, 103);
            this.cartBldgRoomLabel.Name = "cartBldgRoomLabel";
            this.cartBldgRoomLabel.Size = new System.Drawing.Size(10, 13);
            this.cartBldgRoomLabel.TabIndex = 22;
            this.cartBldgRoomLabel.Text = "-";
            // 
            // cartSecLabel
            // 
            this.cartSecLabel.AutoSize = true;
            this.cartSecLabel.Location = new System.Drawing.Point(322, 51);
            this.cartSecLabel.Name = "cartSecLabel";
            this.cartSecLabel.Size = new System.Drawing.Size(10, 13);
            this.cartSecLabel.TabIndex = 21;
            this.cartSecLabel.Text = "-";
            // 
            // cartSemYearLabel
            // 
            this.cartSemYearLabel.AutoSize = true;
            this.cartSemYearLabel.Location = new System.Drawing.Point(322, 77);
            this.cartSemYearLabel.Name = "cartSemYearLabel";
            this.cartSemYearLabel.Size = new System.Drawing.Size(10, 13);
            this.cartSemYearLabel.TabIndex = 20;
            this.cartSemYearLabel.Text = "-";
            // 
            // cartCreditsLabel
            // 
            this.cartCreditsLabel.AutoSize = true;
            this.cartCreditsLabel.Location = new System.Drawing.Point(92, 129);
            this.cartCreditsLabel.Name = "cartCreditsLabel";
            this.cartCreditsLabel.Size = new System.Drawing.Size(10, 13);
            this.cartCreditsLabel.TabIndex = 19;
            this.cartCreditsLabel.Text = "-";
            // 
            // cartDeptLabel
            // 
            this.cartDeptLabel.AutoSize = true;
            this.cartDeptLabel.Location = new System.Drawing.Point(92, 103);
            this.cartDeptLabel.Name = "cartDeptLabel";
            this.cartDeptLabel.Size = new System.Drawing.Size(10, 13);
            this.cartDeptLabel.TabIndex = 18;
            this.cartDeptLabel.Text = "-";
            // 
            // cartTitleLabel
            // 
            this.cartTitleLabel.AutoSize = true;
            this.cartTitleLabel.Location = new System.Drawing.Point(92, 77);
            this.cartTitleLabel.Name = "cartTitleLabel";
            this.cartTitleLabel.Size = new System.Drawing.Size(10, 13);
            this.cartTitleLabel.TabIndex = 17;
            this.cartTitleLabel.Text = "-";
            // 
            // cartIDLabel
            // 
            this.cartIDLabel.AutoSize = true;
            this.cartIDLabel.Location = new System.Drawing.Point(92, 51);
            this.cartIDLabel.Name = "cartIDLabel";
            this.cartIDLabel.Size = new System.Drawing.Size(10, 13);
            this.cartIDLabel.TabIndex = 16;
            this.cartIDLabel.Text = "-";
            // 
            // cartSeatsLabel
            // 
            this.cartSeatsLabel.AutoSize = true;
            this.cartSeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartSeatsLabel.Location = new System.Drawing.Point(92, 25);
            this.cartSeatsLabel.Name = "cartSeatsLabel";
            this.cartSeatsLabel.Size = new System.Drawing.Size(11, 13);
            this.cartSeatsLabel.TabIndex = 15;
            this.cartSeatsLabel.Text = "-";
            // 
            // cartLabel9
            // 
            this.cartLabel9.AutoSize = true;
            this.cartLabel9.Location = new System.Drawing.Point(232, 129);
            this.cartLabel9.Name = "cartLabel9";
            this.cartLabel9.Size = new System.Drawing.Size(46, 13);
            this.cartLabel9.TabIndex = 14;
            this.cartLabel9.Text = "Timeslot";
            // 
            // cartLabel8
            // 
            this.cartLabel8.AutoSize = true;
            this.cartLabel8.Location = new System.Drawing.Point(232, 103);
            this.cartLabel8.Name = "cartLabel8";
            this.cartLabel8.Size = new System.Drawing.Size(83, 13);
            this.cartLabel8.TabIndex = 13;
            this.cartLabel8.Text = "Building / Room";
            // 
            // cartLabel7
            // 
            this.cartLabel7.AutoSize = true;
            this.cartLabel7.Location = new System.Drawing.Point(232, 77);
            this.cartLabel7.Name = "cartLabel7";
            this.cartLabel7.Size = new System.Drawing.Size(84, 13);
            this.cartLabel7.TabIndex = 12;
            this.cartLabel7.Text = "Semester / Year";
            // 
            // cartLabel6
            // 
            this.cartLabel6.AutoSize = true;
            this.cartLabel6.Location = new System.Drawing.Point(232, 51);
            this.cartLabel6.Name = "cartLabel6";
            this.cartLabel6.Size = new System.Drawing.Size(43, 13);
            this.cartLabel6.TabIndex = 11;
            this.cartLabel6.Text = "Section";
            // 
            // cartLabel5
            // 
            this.cartLabel5.AutoSize = true;
            this.cartLabel5.Location = new System.Drawing.Point(6, 129);
            this.cartLabel5.Name = "cartLabel5";
            this.cartLabel5.Size = new System.Drawing.Size(39, 13);
            this.cartLabel5.TabIndex = 10;
            this.cartLabel5.Text = "Credits";
            // 
            // cartLabel4
            // 
            this.cartLabel4.AutoSize = true;
            this.cartLabel4.Location = new System.Drawing.Point(6, 103);
            this.cartLabel4.Name = "cartLabel4";
            this.cartLabel4.Size = new System.Drawing.Size(62, 13);
            this.cartLabel4.TabIndex = 8;
            this.cartLabel4.Text = "Department";
            // 
            // cartLabel3
            // 
            this.cartLabel3.AutoSize = true;
            this.cartLabel3.Location = new System.Drawing.Point(6, 77);
            this.cartLabel3.Name = "cartLabel3";
            this.cartLabel3.Size = new System.Drawing.Size(27, 13);
            this.cartLabel3.TabIndex = 6;
            this.cartLabel3.Text = "Title";
            // 
            // cartLabel2
            // 
            this.cartLabel2.AutoSize = true;
            this.cartLabel2.Location = new System.Drawing.Point(6, 51);
            this.cartLabel2.Name = "cartLabel2";
            this.cartLabel2.Size = new System.Drawing.Size(54, 13);
            this.cartLabel2.TabIndex = 4;
            this.cartLabel2.Text = "Course ID";
            // 
            // cartLabel1
            // 
            this.cartLabel1.AutoSize = true;
            this.cartLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartLabel1.Location = new System.Drawing.Point(6, 25);
            this.cartLabel1.Name = "cartLabel1";
            this.cartLabel1.Size = new System.Drawing.Size(80, 13);
            this.cartLabel1.TabIndex = 2;
            this.cartLabel1.Text = "Seats Available";
            // 
            // cartDGV
            // 
            this.cartDGV.AllowUserToAddRows = false;
            this.cartDGV.AllowUserToResizeRows = false;
            this.cartDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cartDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartDGVcourseID,
            this.cartDGVtitle,
            this.cartDGVsection});
            this.cartDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cartDGV.Location = new System.Drawing.Point(3, 417);
            this.cartDGV.Name = "cartDGV";
            this.cartDGV.RowHeadersVisible = false;
            this.cartDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartDGV.ShowCellErrors = false;
            this.cartDGV.Size = new System.Drawing.Size(469, 150);
            this.cartDGV.TabIndex = 0;
            // 
            // cartDGVcourseID
            // 
            this.cartDGVcourseID.HeaderText = "Course ID";
            this.cartDGVcourseID.Name = "cartDGVcourseID";
            this.cartDGVcourseID.Width = 79;
            // 
            // cartDGVtitle
            // 
            this.cartDGVtitle.HeaderText = "Title";
            this.cartDGVtitle.Name = "cartDGVtitle";
            this.cartDGVtitle.Width = 52;
            // 
            // cartDGVsection
            // 
            this.cartDGVsection.HeaderText = "Section";
            this.cartDGVsection.Name = "cartDGVsection";
            this.cartDGVsection.Width = 68;
            // 
            // studentInfoBox
            // 
            this.studentInfoBox.BackColor = System.Drawing.Color.MintCream;
            this.studentInfoBox.Controls.Add(this.totcredLabel);
            this.studentInfoBox.Controls.Add(this.departmentLabel);
            this.studentInfoBox.Controls.Add(this.nameLabel);
            this.studentInfoBox.Controls.Add(this.iDLabel);
            this.studentInfoBox.Controls.Add(this.regTotcredLabel);
            this.studentInfoBox.Controls.Add(this.regDeptnameLabel);
            this.studentInfoBox.Controls.Add(this.regNameLabel);
            this.studentInfoBox.Controls.Add(this.regIDLabel);
            this.studentInfoBox.Location = new System.Drawing.Point(6, 6);
            this.studentInfoBox.Name = "studentInfoBox";
            this.studentInfoBox.Size = new System.Drawing.Size(475, 125);
            this.studentInfoBox.TabIndex = 0;
            this.studentInfoBox.TabStop = false;
            this.studentInfoBox.Text = "Student Information";
            // 
            // totcredLabel
            // 
            this.totcredLabel.AutoSize = true;
            this.totcredLabel.Location = new System.Drawing.Point(94, 104);
            this.totcredLabel.Name = "totcredLabel";
            this.totcredLabel.Size = new System.Drawing.Size(10, 13);
            this.totcredLabel.TabIndex = 7;
            this.totcredLabel.Text = "-";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(94, 77);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(10, 13);
            this.departmentLabel.TabIndex = 6;
            this.departmentLabel.Text = "-";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(94, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(10, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "-";
            // 
            // iDLabel
            // 
            this.iDLabel.AutoSize = true;
            this.iDLabel.Location = new System.Drawing.Point(94, 23);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(10, 13);
            this.iDLabel.TabIndex = 4;
            this.iDLabel.Text = "-";
            // 
            // regTotcredLabel
            // 
            this.regTotcredLabel.AutoSize = true;
            this.regTotcredLabel.Location = new System.Drawing.Point(6, 104);
            this.regTotcredLabel.Name = "regTotcredLabel";
            this.regTotcredLabel.Size = new System.Drawing.Size(65, 13);
            this.regTotcredLabel.TabIndex = 3;
            this.regTotcredLabel.Text = "Total credits";
            // 
            // regDeptnameLabel
            // 
            this.regDeptnameLabel.AutoSize = true;
            this.regDeptnameLabel.Location = new System.Drawing.Point(6, 77);
            this.regDeptnameLabel.Name = "regDeptnameLabel";
            this.regDeptnameLabel.Size = new System.Drawing.Size(62, 13);
            this.regDeptnameLabel.TabIndex = 2;
            this.regDeptnameLabel.Text = "Department";
            // 
            // regNameLabel
            // 
            this.regNameLabel.AutoSize = true;
            this.regNameLabel.Location = new System.Drawing.Point(6, 50);
            this.regNameLabel.Name = "regNameLabel";
            this.regNameLabel.Size = new System.Drawing.Size(35, 13);
            this.regNameLabel.TabIndex = 1;
            this.regNameLabel.Text = "Name";
            // 
            // regIDLabel
            // 
            this.regIDLabel.AutoSize = true;
            this.regIDLabel.Location = new System.Drawing.Point(6, 23);
            this.regIDLabel.Name = "regIDLabel";
            this.regIDLabel.Size = new System.Drawing.Size(18, 13);
            this.regIDLabel.TabIndex = 0;
            this.regIDLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Prereq ID";
            // 
            // cartRemove
            // 
            this.cartRemove.Location = new System.Drawing.Point(125, 388);
            this.cartRemove.Name = "cartRemove";
            this.cartRemove.Size = new System.Drawing.Size(75, 23);
            this.cartRemove.TabIndex = 29;
            this.cartRemove.Text = "Remove Course";
            this.cartRemove.UseVisualStyleBackColor = true;
            this.cartRemove.Click += new System.EventHandler(this.cartRemove_Click);
            // 
            // goRegister
            // 
            this.goRegister.Location = new System.Drawing.Point(397, 388);
            this.goRegister.Name = "goRegister";
            this.goRegister.Size = new System.Drawing.Size(75, 23);
            this.goRegister.TabIndex = 30;
            this.goRegister.Text = "Register";
            this.goRegister.UseVisualStyleBackColor = true;
            this.goRegister.Click += new System.EventHandler(this.goRegister_Click);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "391 University";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.students_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).EndInit();
            this.sql_connection.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.reg_tab.ResumeLayout(false);
            this.studentHistoryBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseHistDGV)).EndInit();
            this.studentCurrentEnrollBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentDGV)).EndInit();
            this.availableClassBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.availableDGV)).EndInit();
            this.shoppingCartBox.ResumeLayout(false);
            this.shoppingCartBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).EndInit();
            this.studentInfoBox.ResumeLayout(false);
            this.studentInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage students_tab;
        private DataGridView studentView;
        private TabPage sql_connection;
        private GroupBox groupBox4;
        private Label label30;
        private TextBox database_name;
        private TextBox connPortBox;
        private Label label0;
        private Label label29;
        private Button connect_button;
        private TextBox connHostBox;
        private Label label28;
        private Label connection_status_label;
        private TextBox user_ID;
        private GroupBox groupBox6;
        private RadioButton network_radioButton;
        private RadioButton local_radioButton;
        private TextBox password;
        private Label label27;
        private Label label26;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn studentView_ID;
        private DataGridViewTextBoxColumn studentView_name;
        private DataGridViewTextBoxColumn studentView_dept_name;
        private DataGridViewTextBoxColumn studentView_tot_cred;
        private TabPage reg_tab;
        private Button login_button;
        private GroupBox availableClassBox;
        private DataGridView availableDGV;
        private GroupBox shoppingCartBox;
        private GroupBox studentInfoBox;
        private DataGridView cartDGV;
        private GroupBox studentHistoryBox;
        private GroupBox studentCurrentEnrollBox;
        private Label regIDLabel;
        private Label regNameLabel;
        private Label regDeptnameLabel;
        private Label totcredLabel;
        private Label departmentLabel;
        private Label nameLabel;
        private Label iDLabel;
        private Label regTotcredLabel;
        private DataGridView courseHistDGV;
        private DataGridViewTextBoxColumn courseHistCourseID;
        private DataGridViewTextBoxColumn courseHistYear;
        private DataGridViewTextBoxColumn courseHistTitle;
        private DataGridViewTextBoxColumn courseHistDeptname;
        private DataGridViewTextBoxColumn courseHistCredits;
        private DataGridViewTextBoxColumn courseHistGrade;
        private DataGridView currentDGV;
        private DataGridViewTextBoxColumn currentDGVColumn1;
        private DataGridViewTextBoxColumn currentDGVColumn2;
        private DataGridViewTextBoxColumn currentDGVColumn3;
        private DataGridViewTextBoxColumn currentDGVColumn4;
        private DataGridViewTextBoxColumn currentDGVColumn5;
        private DataGridViewTextBoxColumn currentDGVColumn6;
        private DataGridViewTextBoxColumn availableDGVcap;
        private DataGridViewTextBoxColumn availableDGVcourse_id;
        private DataGridViewTextBoxColumn availableDGVtitle;
        private DataGridViewTextBoxColumn availableDGVsection;
        private DataGridViewTextBoxColumn availableDGVdept;
        private DataGridViewTextBoxColumn availableDGVbldg;
        private DataGridViewTextBoxColumn availableDGVroom_num;
        private DataGridViewTextBoxColumn availableDGVtime_slot;
        private DataGridViewTextBoxColumn availableDGVcred;
        private Label cartLabel9;
        private Label cartLabel8;
        private Label cartLabel7;
        private Label cartLabel6;
        private Label cartLabel5;
        private Label cartLabel4;
        private Label cartLabel3;
        private Label cartLabel2;
        private Label cartLabel1;
        private Label cartTimeLabel;
        private Label cartBldgRoomLabel;
        private Label cartSecLabel;
        private Label cartSemYearLabel;
        private Label cartCreditsLabel;
        private Label cartDeptLabel;
        private Label cartTitleLabel;
        private Label cartIDLabel;
        private Label cartSeatsLabel;
        private Button addCart;
        private Label prereqMet;
        private Label prereqUnmet;
        private Label prereqTest;
        private DataGridViewTextBoxColumn cartDGVcourseID;
        private DataGridViewTextBoxColumn cartDGVtitle;
        private DataGridViewTextBoxColumn cartDGVsection;
        private Label label1;
        private Button cartRemove;
        private Button goRegister;
    }
}

