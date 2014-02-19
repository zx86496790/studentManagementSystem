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

namespace StudentManagementSystem
{
    public partial class formManagement : Form
    {
        int userId;
        string level;
        string name;
        int numberOfStudentInformation = 0;
        StudentInformation[] si;
        int count = 0;
        public formManagement(int userId,string level,string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.level = level;
            this.name = name;
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
                    si = new StudentInformation[numberOfStudentInformation+100];
                    sqlcmd = new OleDbCommand(@"select * from studentsInformation", objConnection);//sql statement     
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        while (reader.Read()) //important otherwise may not find data
                        {
                            si[count] = new StudentInformation(Convert.ToInt32(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), Convert.ToDecimal(reader[4].ToString()), reader[5].ToString());//get value from specific field 
                            lstStudentsInformation.Items.Add(si[count].studentName);
                            count++;
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
            txtStudentInformationStudentName.Text = si[selectedIndex].studentName;
            txtStudentInformationPhoneNumber.Text = si[selectedIndex].phoneNumber;
            txtStudentInformationStudentProgram.Text = si[selectedIndex].studentProgram;
            numStudentInformationGPA.Value = si[selectedIndex].GPA;
            calStudentInformationGraduationDate.Text = si[selectedIndex].graduationDate;
        }
    }
}
