using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class StudentInformation
    {
        public StudentInformation(int studentID, string studentName, string phoneNumber, string studentProgram, decimal GPA, string graduationDate)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.phoneNumber = phoneNumber;
            this.studentProgram = studentProgram;
            this.GPA = GPA;
            this.graduationDate = graduationDate;
        }
        public int studentID { get; set; }
        public string studentName { get; set; }
        public string phoneNumber { get; set; }
        public string studentProgram { get; set; }
        public decimal GPA { get; set; }
        public string graduationDate { get; set; }
    }
}
