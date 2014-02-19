using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace StudentManagementSystem
{
    public partial class formLogin : Form
    {
        int count = 0;
        int numberOfUsers = 0;
        Users[] users = null;
        public formLogin()
        {
            InitializeComponent();
           try{
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
                    users = new Users[numberOfUsers];
                    sqlcmd = new OleDbCommand(@"select * from users", objConnection);//sql statement     
                    using (OleDbDataReader reader = sqlcmd.ExecuteReader())//execute query
                    {
                        while (reader.Read()) //important otherwise may not find data
                        {
                            users[count++] = new Users(Convert.ToInt32(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString());//get value from specific field 
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void cbkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else 
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("User name cannot be empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password cannot be empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string level = "";
                string name = "";
                int userId = 0;
                bool flag = false;
                byte[] result = Encoding.Default.GetBytes(txtPassword.Text.Trim());
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);
                string password=BitConverter.ToString(output).Replace("-", "");
                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i] != null)
                    {
                        if (users[i].USERNAME == txtUserName.Text && users[i].USERPASSWORD == password.ToLower())
                        {
                            flag = true;
                            userId = users[i].USERID;
                            name = users[i].USERNAME;
                            level = users[i].USERLEVEL;
                        }
                    }
                }
                    if (flag == true)
                    {
                            formManagement fm = new formManagement(userId,level,name);
                            fm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User name or password is wrong, please check");
                    }
            }
        }
        }

    }

