using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attendance_server
{
    public class student
    {
        private string name;
        private string email;
        private string password;
        private string question;
        private string answer;
        private string s_class;
        private string attendance;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        public string S_class
        {
            get
            {
                return s_class;
            }

            set
            {
                s_class = value;
            }
        }

        public string Attendance
        {
            get
            {
                return attendance;
            }

            set
            {
                attendance = value;
            }
        }
    }
}