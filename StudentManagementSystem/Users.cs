using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Users
    {
        private int userID;
        private string userName;
        private string userPassword;
        private string userLevel;
        private string createDate;
        private string lastLogin;

        public Users(int userID, string userName, string userPassword, string userLevel, string createDate, string lastLogin)
        {
            this.userID = userID;
            this.userName = userName;
            this.userPassword = userPassword;
            this.userLevel = userLevel;
            this.createDate = createDate;
            this.lastLogin = lastLogin;
 
        }

        public string LASTLOGIN
        {
            get { return lastLogin; }
            set { lastLogin = value; }
        }
        

        public string CREATEDATE
        {
            get { return createDate; }
            set { createDate = value; }
        }
        

        public string USERLEVEL
        {
            get { return userLevel; }
            set { userLevel = value; }
        }
        

        public string USERPASSWORD
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        

        public string USERNAME
        {
            get { return userName; }
            set { userName = value; }
        }
        
        public int USERID
        {
            get { return userID; }
            set { userID = value; }
        }
        

    }
}
