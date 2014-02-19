using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Record
    {
        private int userID;
        private int studentID;
        private string modifyDate;

        public string MODIFYDATE
        {
            get { return modifyDate; }
            set { modifyDate = value; }
        }
        

        public int STUDENTID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        
        public int USERID
        {
            get { return userID; }
            set { userID = value; }
        }
        
    }
}
