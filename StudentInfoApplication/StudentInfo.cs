using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    class StudentInfo
    {
        private string studentID;
        private string firstName;
        private string lastName;

        public StudentInfo()
        {
            this.studentID = "";
            this.firstName = "";
            this.lastName = "";
        }

        public StudentInfo(string studentID, string firstName, string lastName)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string StudentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

    }
}
