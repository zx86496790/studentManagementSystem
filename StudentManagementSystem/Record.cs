using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Record
    {
        public Record(int recordID,int userID,int studentID,string modifyDate)
        {
            this.recordID = recordID;
            this.userID = userID;
            this.studentID = studentID;
            this.modifyDate = modifyDate;
        }
        private int recordID;
        private int userID;
        private int studentID;
        private string modifyDate;

        public int RECORDID
        {
            get { return recordID; }
            set { recordID = value; }
        }
        
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
