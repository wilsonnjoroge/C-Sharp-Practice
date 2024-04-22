using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objec_Methods
{
    internal class Students
    {
        public string name;
        public string subject;
        public int marks;

        public Students (string aName, string asubject, int aMarks)
        {
            name = aName;   
            subject = asubject;
            marks = aMarks;
        }

        public bool hasPassed ()
        {
            if (marks >= 50)
            {
                return true;

            } else
            {
                return false;    
            }
        }
    }
}
