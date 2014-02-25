using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace StudentManagementSystem
{
    public partial class formManagement : Form
    {
        int userId;
        string level;
        string name;
        ArrayList si=new ArrayList();
        ArrayList r = new ArrayList();
        ArrayList us = new ArrayList();
        public formManagement(int userId,string level,string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.level = level;
            this.name = name;
            //load database and retrive data from students information table then show them in program
            try
            {
                string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;";  //link to access connection string 
                strConnection += @"Data Source = C:\Users\zsen\Desktop\StudentManagementSystem\StudentManagementSystem\project.accdb ";  //point where is your access file
                using (OleDbConnection objConnection = new OleDbConnection(strConnection))
                {
                    objConnection.Open();  //open connection
                    OleDbCommand sqlcmd = new OleDbCommand(@"select count(*) from studentsInformation", objConnection);
                    sqlcmd = new OleDbCommand(@"select * from studentsInformation", objConnection);//sql statement     
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        while (reader.Read()) //important otherwise may not find data
                        {
                            si.Add( new StudentInformation(Convert.ToInt32(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToDecimal(reader[4].ToString()), reader[5].ToString()));//get value from specific field 
                            //lstStudentsInformation.Items.Add(((StudentInformation)si[count]).studentName);
                           // count++;
                        }
                        foreach(StudentInformation studentInformation in si)
                        {
                            lstStudentsInformation.Items.Add(studentInformation.studentID + " " + studentInformation.studentName);
                           // lstStudentsInformation.se
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            //load database and retrive data from change record table then show them in program
            try
            {
                string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;";  //link to access connection string 
                strConnection += @"Data Source = C:\Users\zsen\Desktop\StudentManagementSystem\StudentManagementSystem\project.accdb ";  //point where is your access file
                using (OleDbConnection objConnection = new OleDbConnection(strConnection))
                {
                    objConnection.Open();  //open connection
                    OleDbCommand sqlcmd = new OleDbCommand(@"select count(*) from records", objConnection);
                    sqlcmd = new OleDbCommand(@"select * from records", objConnection);//sql statement     
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        while (reader.Read()) //important otherwise may not find data
                        {
                            r.Add(new Record(Convert.ToInt32(reader[0].ToString()), Convert.ToInt32(reader[1].ToString()), Convert.ToInt32(reader[2].ToString()), reader[3].ToString()));
                        }
                        foreach (Record record in r)
                        {
                            lstChangeRecord.Items.Add(record.RECORDID+" user id "+record.USERID + " modified " + record.STUDENTID + " in " + record.MODIFYDATE.Substring(0, 10));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            //load database and retrive data from users table then show them in program
            try
            {
                string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;";  //link to access connection string 
                strConnection += @"Data Source = C:\Users\zsen\Desktop\StudentManagementSystem\StudentManagementSystem\project.accdb ";  //point where is your access file
                using (OleDbConnection objConnection = new OleDbConnection(strConnection))
                {
                    objConnection.Open();  //open connection
                    OleDbCommand sqlcmd = new OleDbCommand(@"select count(*) from users", objConnection);
                    sqlcmd = new OleDbCommand(@"select * from users", objConnection);//sql statement     
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        while (reader.Read()) //important otherwise may not find data
                        {
                            us.Add(new Users(Convert.ToInt32(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
                        }
                        foreach (Users users in us)
                        {
                            lstUser.Items.Add(users.USERID+" "+users.USERNAME + " level is " + users.USERLEVEL);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        private void formManagement_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + name;
            if (level == "admin")
                lblLevel.Text = "Your level is " + level;
        }


        private void lstStudentsInformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstStudentsInformation.SelectedIndex;
            if (selectedIndex != -1)
            {
                txtStudentInformationStudentName.Text = ((StudentInformation)si[selectedIndex]).studentName;
                txtStudentInformationPhoneNumber.Text = ((StudentInformation)si[selectedIndex]).phoneNumber;
                txtStudentInformationStudentProgram.Text = ((StudentInformation)si[selectedIndex]).studentProgram;
                numStudentInformationGPA.Value = ((StudentInformation)si[selectedIndex]).GPA;
                calStudentInformationGraduationDate.Text = ((StudentInformation)si[selectedIndex]).graduationDate;
            }
        }
        private void lstChangeRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstChangeRecord.SelectedIndex;
            if (selectedIndex != -1)
            {
                numChangeRecordUserID.Value = ((Record)r[selectedIndex]).USERID;
                numChangeRecordStudentID.Value = ((Record)r[selectedIndex]).STUDENTID;
                calRecordModifiedDate.Text = ((Record)r[selectedIndex]).MODIFYDATE;
            } 
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstUser.SelectedIndex;
            if (selectedIndex != -1)
            {
                txtUserName.Text = ((Users)us[selectedIndex]).USERNAME;
                txtUserLevel.Text = ((Users)us[selectedIndex]).USERLEVEL;
                calUserCreatDate.Text = ((Users)us[selectedIndex]).CREATEDATE;
                calLastLoginDate.Text = ((Users)us[selectedIndex]).LASTLOGIN;
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab==tabPage1)
            {
                if (lstStudentsInformation.SelectedIndex == -1)
                {
                    MessageBox.Show("No record is selected, please make sure you have selected one before you click the button", "Error");
                }
                else
                {
                    string[] temp=lstStudentsInformation.SelectedItem.ToString().Split(' ');
                    int id = Convert.ToInt32(temp[0]);
                    try
                    {
                        string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;";  //link to access connection string 
                        strConnection += @"Data Source = C:\Users\zsen\Desktop\StudentManagementSystem\StudentManagementSystem\project.accdb ";  //point where is your access file
                        using (OleDbConnection objConnection = new OleDbConnection(strConnection))
                        {
                            objConnection.Open();  //open connection
                            OleDbCommand sqlcmd = new OleDbCommand(@"delete * from studentsInformation where studentID="+id, objConnection);//sql statement     
                            int numberOfResult=sqlcmd.ExecuteNonQuery();
                            if (numberOfResult == 1)
                            {
                                MessageBox.Show("Record has been successfully deleted");
                            }
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.StackTrace);
                    }
                    lstStudentsInformation.Items.RemoveAt(lstStudentsInformation.SelectedIndex);
                    txtStudentInformationPhoneNumber.Text = "";
                    txtStudentInformationStudentName.Text = "";
                    txtStudentInformationStudentProgram.Text = "";
                    numStudentInformationGPA.Value = 0;
                    calStudentInformationGraduationDate.Text = "";
                    
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                if (lstChangeRecord.SelectedIndex == -1)
                {
                    MessageBox.Show("No record is selected, please make sure you have selected one before you click the button", "Error");
                }
                else
                {
                    string[] temp = lstChangeRecord.SelectedItem.ToString().Split(' ');
                    int id = Convert.ToInt32(temp[0]);
                    try
                    {
                        string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;";  //link to access connection string 
                        strConnection += @"Data Source = C:\Users\zsen\Desktop\StudentManagementSystem\StudentManagementSystem\project.accdb ";  //point where is your access file
                        using (OleDbConnection objConnection = new OleDbConnection(strConnection))
                        {
                            objConnection.Open();  //open connection
                            OleDbCommand sqlcmd = new OleDbCommand(@"delete * from records where recordID=" + id, objConnection);//sql statement     
                            int numberOfResult = sqlcmd.ExecuteNonQuery();
                            if (numberOfResult == 1)
                            {
                                MessageBox.Show("Record has been successfully deleted");
                            }
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.StackTrace);
                    }
                    lstChangeRecord.Items.RemoveAt(lstChangeRecord.SelectedIndex);
                    numChangeRecordStudentID.Value = 0;
                    numChangeRecordUserID.Value = 0;
                    calRecordModifiedDate.Text = "";
                }
            }
            else 
            {
                if (lstUser.SelectedIndex == -1)
                {
                    MessageBox.Show("No record is selected, please make sure you have selected one before you click the button", "Error");
                }
                else
                {
                    string[] temp = lstUser.SelectedItem.ToString().Split(' ');
                    int id = Convert.ToInt32(temp[0]);
                    try
                    {
                        string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;";  //link to access connection string 
                        strConnection += @"Data Source = C:\Users\zsen\Desktop\StudentManagementSystem\StudentManagementSystem\project.accdb ";  //point where is your access file
                        using (OleDbConnection objConnection = new OleDbConnection(strConnection))
                        {
                            objConnection.Open();  //open connection
                            OleDbCommand sqlcmd = new OleDbCommand(@"delete * from users where userID=" + id, objConnection);//sql statement     
                            int numberOfResult = sqlcmd.ExecuteNonQuery();
                            if (numberOfResult == 1)
                            {
                                MessageBox.Show("Record has been successfully deleted");
                            }
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.StackTrace);
                    }
                    lstUser.Items.RemoveAt(lstUser.SelectedIndex);
                    txtUserLevel.Text = "";
                    txtUserName.Text = "";
                    calLastLoginDate.Text = "";
                    calUserCreatDate.Text = "";
                }
            }
        }
    }
}
