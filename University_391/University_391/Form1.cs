using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace University_391
{
    public partial class Form1 : Form
    {
        public SqlConnectionStringBuilder dbBuilder;
        public SqlConnection dbConnection;
        public SqlCommand dbCommand;
        public SqlCommand dbCommand2;
        public SqlDataReader dbReader;
        public SqlTransaction dbTrans = null;
        public bool conn_flag = false;
        public bool isLocal = true;

        //Student properties
        public string student_ID;
        public string student_name;
        public string student_dept_name;
        public Int32 student_tot_cred;

        //Course & section properties
        public string seats;
        public string course_id;
        public string prereq_id;
        public string prereqOut;
        public string title;
        public string dept_name;
        public string credits;
        public string sec_id;
        public string semester = "Fall";
        public string year = "2021";
        public string grade = "NA";
        public string building;
        public string room_num;
        public string time_slot;
        public int prereqNum;

        public Form1()
        {
            InitializeComponent();
        }

    /*
    *  SQL CONNECTION *******************************************************************
    * 
    */
        //Handles the Database "Connect" button, populates students under that tab
        private void connect_button_Click(object sender, EventArgs e)
        {
            dbConnection = new SqlConnection();
            dbBuilder = new SqlConnectionStringBuilder();
            dbBuilder.UserID = user_ID.Text;
            dbBuilder.Password = password.Text;
            dbBuilder.InitialCatalog = database_name.Text;

            if (local_radioButton.Checked)
            {
                dbBuilder.DataSource = "(local)";
            }
            else if (network_radioButton.Checked)
            {
                dbBuilder.DataSource = connHostBox.Text + "," + connPortBox.Text;
            }

            if (dbConnection.State != ConnectionState.Open)
            {
                try
                {
                    dbConnection.ConnectionString = dbBuilder.ConnectionString;
                    dbConnection.Open();
                    dbCommand = new SqlCommand();
                    dbCommand.Connection = dbConnection;
                    if (dbConnection.State == ConnectionState.Open)
                    {
                        connection_status_label.ForeColor = Color.Green;
                        connection_status_label.Text = "Connected!";
                        conn_flag = true;
                        //Save these settings for next app run if they work
                        Properties.Settings.Default.user_id = user_ID.Text;
                        Properties.Settings.Default.password = password.Text;
                        Properties.Settings.Default.db_name = database_name.Text;
                        Properties.Settings.Default.isLocal = local_radioButton.Checked;
                        Properties.Settings.Default.host_IP = connHostBox.Text;
                        Properties.Settings.Default.port = connPortBox.Text;
                        Properties.Settings.Default.Save();

                        students_tab_populate();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        //Checks and opens the Database connection, and sets status indicator
        private void check_conn()
        {
            if (conn_flag)
            {
                try
                {
                    if (dbConnection.State != ConnectionState.Open)
                    {
                        dbConnection.ConnectionString = dbBuilder.ConnectionString;
                        dbConnection.Open();
                    }
                    connection_status_label.ForeColor = Color.Green;
                    connection_status_label.Text = "Connected!";
                    conn_flag = true;
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            } 
            else
            {
                connection_status_label.ForeColor = Color.Firebrick;
                connection_status_label.Text = "Not Connected";
                conn_flag = false;
            }

        }

        //Enables Network connection parameters
        private void network_radioButton_CheckedChanged(Object sender, EventArgs e)
        {
            connHostBox.Enabled = network_radioButton.Checked;
            connPortBox.Enabled = network_radioButton.Checked;
            connPortBox.Text = "1433";
        }

        //SQL Connection tab enter handler - Gets successful database settings from last run for convenience
        private void sql_connection_Enter(object sender, EventArgs e)
        {
            if (local_radioButton.Checked)
            {
                connPortBox.Enabled = false;
                connHostBox.Enabled = false;
            }
            check_conn();
            //Load successful settings from last run
            user_ID.Text = Properties.Settings.Default.user_id;
            password.Text = Properties.Settings.Default.password;
            database_name.Text = Properties.Settings.Default.db_name;
            isLocal = Properties.Settings.Default.isLocal;
            if (isLocal)
            {
                local_radioButton.Checked = true;
            }
            else
            {
                network_radioButton.Checked = true;
            }
            connHostBox.Text = Properties.Settings.Default.host_IP;
            connPortBox.Text = Properties.Settings.Default.port;
        }

    /*
    * REG ***********************************************************************
    *
    */

        //Registration tab enter handler - clears fields and refreshes the list of available sections
        private void reg_tab_Enter(object sender, EventArgs e)
        {
            reg_tab_clear();
            reg_available();
        }

        private void reg_tab_clear()
        {
            cartSeatsLabel.Text = "-";
            cartIDLabel.Text = "-";
            cartTitleLabel.Text = "-";
            cartDeptLabel.Text = "-";
            cartCreditsLabel.Text = "-";
            cartSecLabel.Text = "-";
            cartSemYearLabel.Text = "-";
            cartBldgRoomLabel.Text = "-";
            cartTimeLabel.Text = "-";
            course_id = "";
            prereq_id = "";
            prereqOut = "";
            prereqNum = 0;
            prereqMet.Visible = false;
            prereqUnmet.Visible = false;
            addCart.Enabled = false;

            cartDGV.Rows.Clear();
        }

        //Gets the student's course history
        private void reg_hist(string sID)
        {
            check_conn();
            if (conn_flag)
            {
                dbCommand = new SqlCommand(@"dbo.[get_student_hist]", dbConnection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@studentID", SqlDbType.NVarChar).Value = sID;
                dbReader = dbCommand.ExecuteReader();

                try
                {
                    courseHistDGV.Rows.Clear();
                    while (dbReader.Read())
                    {
                        courseHistDGV.Rows.Add(dbReader["course_id"].ToString(),
                                                dbReader["year"].ToString(),
                                                dbReader["title"].ToString(),
                                                dbReader["dept_name"].ToString(),
                                                dbReader["credits"].ToString(),
                                                dbReader["grade"].ToString());
                    }
                    courseHistDGV.AutoResizeColumns();
                    dbReader.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        //Gets the student's in-progress and enrolled courses
        private void reg_current(string sID)
        {
            check_conn();
            if (conn_flag)
            {
                dbCommand = new SqlCommand(@"dbo.[get_student_current]", dbConnection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@studentID", SqlDbType.NVarChar).Value = sID;
                dbReader = dbCommand.ExecuteReader();

                try
                {
                    currentDGV.Rows.Clear();
                    while (dbReader.Read())
                    {
                        currentDGV.Rows.Add(dbReader["course_id"].ToString(),
                                                dbReader["sec_id"].ToString(),
                                                dbReader["title"].ToString(),
                                                dbReader["dept_name"].ToString(),
                                                dbReader["credits"].ToString(),
                                                dbReader["grade"].ToString());
                    }
                    currentDGV.AutoResizeColumns();
                    dbReader.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        //Lists all the available course sections
        private void reg_available()
        {
            check_conn();
            if (conn_flag)
            {
                dbCommand = new SqlCommand(@"dbo.[get_available]", dbConnection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbReader = dbCommand.ExecuteReader();

                try
                {
                    availableDGV.Rows.Clear();
                    while (dbReader.Read())
                    {
                        availableDGV.Rows.Add(dbReader["capacity"].ToString(), 
                                                dbReader["course_id"].ToString(),
                                                dbReader["title"].ToString(),
                                                dbReader["sec_id"].ToString(),
                                                dbReader["dept_name"].ToString(),
                                                dbReader["building"].ToString(),
                                                dbReader["room_number"].ToString(),
                                                dbReader["time_slot_id"].ToString(),
                                                dbReader["credits"].ToString());
                    }
                    availableDGV.AutoResizeColumns();
                    availableDGV.ClearSelection();
                    dbReader.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        //Grabs course and section info from the list of available sections
        private void availableDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = availableDGV.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                seats = availableDGV.SelectedCells[0].Value.ToString().Trim();
                course_id = availableDGV.SelectedCells[1].Value.ToString().Trim();
                title = availableDGV.SelectedCells[2].Value.ToString().Trim();
                dept_name = availableDGV.SelectedCells[4].Value.ToString().Trim();
                credits = availableDGV.SelectedCells[8].Value.ToString().Trim();
                sec_id = availableDGV.SelectedCells[3].Value.ToString().Trim();
                building = availableDGV.SelectedCells[5].Value.ToString().Trim();
                room_num = availableDGV.SelectedCells[6].Value.ToString().Trim();
                time_slot = availableDGV.SelectedCells[7].Value.ToString().Trim();

                cartSeatsLabel.Text = (100 - Convert.ToInt32(seats)).ToString();
                cartIDLabel.Text = course_id;
                cartTitleLabel.Text = title;
                cartDeptLabel.Text = dept_name;
                cartCreditsLabel.Text = credits;
                cartSecLabel.Text = sec_id;
                cartSemYearLabel.Text = semester + " " + year;
                cartBldgRoomLabel.Text = building + " " + room_num;
                cartTimeLabel.Text = time_slot;

                checkPrereqs(course_id);
            }
        }

        //Checks if there is a prereq, or prereq is satisfied, when an available section is selected
        private void checkPrereqs(string cID)
        {
            if (!String.IsNullOrEmpty(cID))
            {
                dbCommand = new SqlCommand(@"dbo.[get_prereq]", dbConnection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@courseID", cID);
                dbCommand.Parameters.Add("@prereqID", SqlDbType.VarChar, 8);
                dbCommand.Parameters["@prereqID"].Direction = ParameterDirection.Output;

                int i = dbCommand.ExecuteNonQuery();

                prereqOut = Convert.ToString(dbCommand.Parameters["@prereqID"].Value);
                
                if (String.IsNullOrEmpty(prereqOut))
                {
                    prereqMet.Visible = false;
                    prereqUnmet.Visible = false;
                    prereqTest.Text = "No prereq";
                    addCart.Enabled = true;
                } else
                {
                    prereqTest.Text = prereqOut;
                    prereq_id = prereqOut;

                    dbCommand = new SqlCommand(@"dbo.[check_prereq]", dbConnection);
                    dbCommand.CommandType = CommandType.StoredProcedure;
                    dbCommand.Parameters.AddWithValue("@courseID", prereq_id);
                    dbCommand.Parameters.AddWithValue("@studentID", student_ID);
                    dbCommand.Parameters.Add("@result", SqlDbType.Int);
                    dbCommand.Parameters["@result"].Direction = ParameterDirection.Output;

                    i = dbCommand.ExecuteNonQuery();

                    prereqNum = Convert.ToInt32(dbCommand.Parameters["@result"].Value);

                    if (prereqNum >= 1)
                    {
                        prereqUnmet.Visible = false;
                        prereqMet.Visible = true;
                        addCart.Enabled = true;
                    } else
                    {
                        prereqMet.Visible = false;
                        prereqUnmet.Visible = true;
                        addCart.Enabled = false;
                    }
                }
            } else
            {
                MessageBox.Show("Select a class");
            }
        }

        //Add to cart button click handler
        private void addCart_Click(object sender, EventArgs e)
        {
            cartDGV.Rows.Add(course_id, title, sec_id);
            cartDGV.AutoResizeColumns();
        }

        //Remove course from cart
        private void cartRemove_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = cartDGV.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    try
                    {
                        cartDGV.Rows.RemoveAt(cartDGV.SelectedRows[0].Index);
                    }
                    catch (Exception e1)
                    {
                        //MessageBox.Show(e1.ToString(), "Error");
                    }
                }
            }
        }

        //Performs the registrations from the cart with SQL Transactions
        private void goRegister_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in cartDGV.Rows)
            {
                course_id = row.Cells[0].Value.ToString();
                sec_id = row.Cells[2].Value.ToString();

                dbTrans = dbConnection.BeginTransaction();
                try
                {
                    dbCommand = new SqlCommand(@"dbo.[check_section]", dbConnection);
                    dbCommand.Transaction = dbTrans;
                    dbCommand.CommandType = CommandType.StoredProcedure;
                    dbCommand.Parameters.AddWithValue("@courseID", course_id);
                    dbCommand.Parameters.AddWithValue("@secID", sec_id);
                    dbCommand.Parameters.AddWithValue("@semester", semester);
                    dbCommand.Parameters.AddWithValue("@year", year);
                    dbCommand.Parameters.Add("@result", SqlDbType.Int);
                    dbCommand.Parameters["@result"].Direction = ParameterDirection.Output;
                    dbCommand.ExecuteNonQuery();

                    dbCommand2 = new SqlCommand(@"dbo.[insert_takes]", dbConnection);
                    dbCommand2.Transaction = dbTrans;
                    dbCommand2.CommandType = CommandType.StoredProcedure;
                    dbCommand2.Parameters.AddWithValue("@studentID", student_ID);
                    dbCommand2.Parameters.AddWithValue("@courseID", course_id);
                    dbCommand2.Parameters.AddWithValue("@secID", sec_id);
                    dbCommand2.Parameters.AddWithValue("@semester", semester);
                    dbCommand2.Parameters.AddWithValue("@year", year);
                    dbCommand2.Parameters.AddWithValue("@grade", grade);
                    dbCommand2.Parameters.Add("@result", SqlDbType.Int);
                    dbCommand2.Parameters["@result"].Direction = ParameterDirection.Output;
                    dbCommand2.ExecuteNonQuery();

                    dbTrans.Commit();
                }
                catch (SqlException ex)
                {
                    dbTrans.Rollback();
                    Console.WriteLine(ex.ToString());
                }
            }
            reg_current(student_ID);
            reg_available();

            cartDGV.Rows.Clear();
            cartDGV.Refresh();
        }

        /*
        *  STUDENTS *******************************************************************
        * 
        */

        private void students_tab_Click(object sender, EventArgs e)
        {

        }

        private void students_tab_Enter(object sender, EventArgs e)
        {
            
        }

        //Login as student, switches to Registration tab
        private void login_button_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = studentView.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                student_ID = studentView.SelectedCells[0].Value.ToString().Trim();
                student_name = studentView.SelectedCells[1].Value.ToString().Trim();
                student_dept_name = studentView.SelectedCells[2].Value.ToString().Trim();
                student_tot_cred = Convert.ToInt32(studentView.SelectedCells[3].Value);

                iDLabel.Text = student_ID;
                nameLabel.Text = student_name;
                departmentLabel.Text = student_dept_name;
                totcredLabel.Text = student_tot_cred.ToString();

                reg_hist(student_ID);
                reg_current(student_ID);

                tabControl1.SelectedTab = reg_tab;
            }
        }

        //Called by the SQL Connect button to list active students, those that are listed within the last
        //5 years of the View_Prereqs maerialized view
        private void students_tab_populate()
        {
            check_conn();
            if (conn_flag)
            {
                dbCommand = new SqlCommand(@"dbo.[get_students]", dbConnection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbReader = dbCommand.ExecuteReader();

                try
                {
                    studentView.Rows.Clear();
                    while (dbReader.Read())
                    {
                        studentView.Rows.Add(dbReader["ID"].ToString(),
                                                dbReader["name"].ToString(),
                                                dbReader["dept_name"].ToString(),
                                                dbReader["tot_cred"].ToString());
                    }
                    studentView.AutoResizeColumns();
                    dbReader.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        private void studentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void user_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void database_name_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
