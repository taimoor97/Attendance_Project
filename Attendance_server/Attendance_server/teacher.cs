using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attendance_server
{
    public class teacher
    {
        private string username;
        private string email;
        private string password;
        private string s_question;
        private string answer;
        private string qualification;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
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

        public string S_question
        {
            get
            {
                return s_question;
            }

            set
            {
                s_question = value;
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

        public string Qualification
        {
            get
            {
                return qualification;
            }

            set
            {
                qualification = value;
            }
        }
    }
}