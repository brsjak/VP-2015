using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /*
    Author: Damjan Miloshevski
    E-mail: contact@damjanmiloshevski.mk, d.miloshevski@gmail.com
    Web: http://damjanmiloshevski.mk
    Skype: damjan.milosevski
    LinkedIn: https://mk.linkedin.com/in/damjanmiloshevski
    GitHub: https://github.com/damsii
    */
    public class Subject
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Subject()
        {
            //default ctor
        }
        public Subject(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Grade);
        }
    }
}
