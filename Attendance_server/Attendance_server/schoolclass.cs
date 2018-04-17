using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attendance_server
{
    public class @class
    {
        private string s_class;
        private string subject;
       private bool check;

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

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }


        public bool Check
        {
            get
            {
                return check;
            }

            set
            {
                check = value;
            }
        }
    }
}