using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students2_Taci
{
   public class Subject
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Subject(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public override string ToString()
        {
            return String.Format("{0} ({1})",Name,Grade);
        }
    }
}
