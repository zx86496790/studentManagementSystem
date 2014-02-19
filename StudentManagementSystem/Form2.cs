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
        int numberOfStudentInformation = 0;
        int numberOfRecords = 0;
        int numberOfUsers = 0;
        ArrayList si=new ArrayList();
        ArrayList r = new ArrayList();
        ArrayList us = new ArrayList();
        //StudentInformation[] si;
        //Record[] r;
        //Users[] us;
        //int count = 0;
        //int recordCount = 0;
        //int userCount = 0;
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
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        if (reader.Read()) //important otherwise may not find data
                        {
                            numberOfStudentInformation = reader.GetInt32(0);
                        }
                    }
                   // si = new StudentInformation[numberOfStudentInformation+100];
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
                            lstStudentsInformation.Items.Add(studentInformation.studentName);
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
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        if (reader.Read()) //important otherwise may not find data
                        {
                            numberOfRecords = reader.GetInt32(0);
                        }
                    }
                    //r = new Record[numberOfRecords + 100];
                    sqlcmd = new OleDbCommand(@"select * from records", objConnection);//sql statement     
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        while (reader.Read()) //important otherwise may not find data
                        {
                            r.Add(new Record(Convert.ToInt32(reader[0].ToString()), Convert.ToInt32(reader[1].ToString()), Convert.ToInt32(reader[2].ToString()), reader[3].ToString()));
                            //r[recordCount] = new Record(Convert.ToInt32(reader[0].ToString()), Convert.ToInt32(reader[1].ToString()), Convert.ToInt32(reader[2].ToString()), reader[3].ToString());//get value from specific field 
                            //lstChangeRecord.Items.Add(((Record)r[recordCount]).USERID + " modified " + ((Record)r[recordCount]).STUDENTID + " in " + ((Record)r[recordCount]).MODIFYDATE.Substring(0, 10));
                            //recordCount++;
                        }
                        foreach (Record record in r)
                        {
                            lstChangeRecord.Items.Add(record.USERID + " modified " + record.STUDENTID + " in " + record.MODIFYDATE.Substring(0, 10));
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
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        if (reader.Read()) //important otherwise may not find data
                        {
                            numberOfUsers = reader.GetInt32(0);
                        }
                    }
                    // us = new Users[numberOfUsers + 100];
                    sqlcmd = new OleDbCommand(@"select * from users", objConnection);//sql statement     
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        while (reader.Read()) //important otherwise may not find data
                        {
                            //us[userCount] = new Users(Convert.ToInt32(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());//get value from specific field 
                            //lstUser.Items.Add(((Users)us[userCount]).USERNAME + " level is " + ((Users)us[userCount]).USERLEVEL);
                            //userCount++;
                            us.Add(new Users(Convert.ToInt32(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
                        }
                        foreach (Users users in us)
                        {
                            lstUser.Items.Add(users.USERNAME + " level is " + users.USERLEVEL);
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
            txtStudentInformationStudentName.Text = ((StudentInformation)si[selectedIndex]).studentName;
            txtStudentInformationPhoneNumber.Text = ((StudentInformation)si[selectedIndex]).phoneNumber;
            txtStudentInformationStudentProgram.Text = ((StudentInformation)si[selectedIndex]).studentProgram;
            numStudentInformationGPA.Value = ((StudentInformation)si[selectedIndex]).GPA;
            calStudentInformationGraduationDate.Text = ((StudentInformation)si[selectedIndex]).graduationDate;
        }

        private void lstChangeRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstChangeRecord.SelectedIndex;
            numChangeRecordUserID.Value = ((Record)r[selectedIndex]).USERID;
            numChangeRecordStudentID.Value = ((Record)r[selectedIndex]).STUDENTID;
            calRecordModifiedDate.Text = ((Record)r[selectedIndex]).MODIFYDATE;
                
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstUser.SelectedIndex;
            txtUserName.Text = ((Users)us[selectedIndex]).USERNAME;
            txtUserLevel.Text = ((Users)us[selectedIndex]).USERLEVEL;
            calUserCreatDate.Text = ((Users)us[selectedIndex]).CREATEDATE;
            calLastLoginDate.Text = ((Users)us[selectedIndex]).LASTLOGIN;
        }
    }
}
